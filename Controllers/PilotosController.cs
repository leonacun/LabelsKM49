using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labels_KM49.Data;
using Labels_KM49.Models;
using static Labels_KM49.Controllers.JTransferspacketsController;
using Labels_KM49.Models.ViewModels;
using NuGet.Packaging.Licenses;
using Labels_KM49.Controllers;
using System.Drawing;
using OfficeOpenXml;
using System.Globalization;
using NuGet.Packaging;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oracle.ManagedDataAccess.Client;
using System.Data;

//Este es el Home
namespace Labels_KM49.Controllers
{
    public class PilotosController : Controller
    {
        private readonly PilotosContext _context;
        private readonly ModelContext _modelContext;

        public PilotosController(PilotosContext context, ModelContext modelContext)
        {
            _context = context;
            _modelContext = modelContext;
        }
        DateTime fInicio = new DateTime(2023, 6, 28);
        DateTime dateTime = DateTime.Now;
        long sbs2, sbs22;
        string color;
        string rrLwrF;
        string frLwrF;
        // GET: Pilotos
        public async Task<IActionResult> Index(string vin, string sequence, string fullvin, string color, string type, string ipAddres, string search, bool isUpdate, bool isDownload, string dType, string dstartDate, string dendDate, bool allTime, bool allData, string eyePart, string frontlwr, string rearlwr)
        {
            var dateTime = DateTime.Now;
            int port = 9100;
            string part = "";

            if (isDownload)
            {
                // Configurar el contexto de la licencia de EPPlus
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Guardar el archivo en un MemoryStream
                var memoryStream = new MemoryStream();
                // Obtener los datos desde tu contexto
                DateTime startDate = fInicio;
                DateTime endDate = dateTime;

                if (!allTime)
                {
                    startDate = DateTime.ParseExact(dstartDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    endDate = DateTime.ParseExact(dendDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    endDate = endDate.AddHours(23).AddMinutes(59).AddSeconds(59);
                }

                string dateName = "Del " + startDate + " al " + endDate;
                string nameSheet = dType + " vines " + dateName;

                if (dType != "all")
                {
                    if (dType == "KM49")
                    {
                        await LoadData();
                        var getKM = await _context.PilotosLists.OrderByDescending(x => x.Id).ToListAsync();
                        List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();

                        var lastGetKM = getKM.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                        // Convertir elementos de getKM en PilotoViewModel y agregar a pilotosList
                        foreach (var item in lastGetKM)
                        {

                            PilotoViewModel add = new PilotoViewModel
                            {
                                Creation = (DateTime)item.Creation,
                                Vin = item.Vin,
                                type = item.Type,
                                Sequence = (long)item.Suquence,
                                FullVin = item.FullVin,
                                Color = item.Color,
                                Enviado = item.Enviado,
                                Nempleado = item.Nempleado,
                                Bpart = item.Bpart
                            };

                            pilotosList.Add(add);
                        }

                        // Ordenar pilotosList por Creation de forma descendente
                        var ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate && t.Enviado != null).ToList();

                        if (allData)
                        {
                            ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate).ToList();
                        }

                        // Abrir el archivo Excel y trabajar con EPPlus
                        try
                        {
                            using (var pck = new ExcelPackage(memoryStream))
                            {
                                var sheet = pck.Workbook.Worksheets.Add(dType);

                                // Agregar encabezados
                                sheet.Cells[1, 1].Value = "Creation";
                                sheet.Cells[1, 2].Value = "Sequence";
                                sheet.Cells[1, 3].Value = "Vin";
                                sheet.Cells[1, 4].Value = "Type";
                                sheet.Cells[1, 5].Value = "Color";
                                sheet.Cells[1, 6].Value = "Full Vin";
                                sheet.Cells[1, 7].Value = "Bpart";

                                // Agregar datos de la lista
                                for (int i = 0; i < ordenar.Count; i++)
                                {
                                    sheet.Cells[i + 2, 1].Value = ordenar[i].Creation;
                                    sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                    sheet.Cells[i + 2, 2].Value = ordenar[i].Sequence;
                                    sheet.Cells[i + 2, 3].Value = ordenar[i].Vin;
                                    sheet.Cells[i + 2, 4].Value = ordenar[i].type;
                                    sheet.Cells[i + 2, 5].Value = ordenar[i].Color;
                                    sheet.Cells[i + 2, 6].Value = ordenar[i].FullVin;
                                    sheet.Cells[i + 2, 7].Value = ordenar[i].Bpart;
                                }

                                // Autoajustar columnas para el contenido
                                sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                                pck.Save();
                            }
                            memoryStream.Position = 0;

                            // Devolver el archivo Excel como FileResult
                            return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nameSheet + ".xlsx");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                            return null; // Manejar el error apropiadamente según tus necesidades
                        }
                    }

                    if (dType == "EJ")
                    {
                        await LoadData();

                        var getEJ = await _context.Ejlists.OrderByDescending(x => x.Id).ToListAsync();
                        List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();

                        var lastGetEJ = getEJ.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                        // Convertir elementos de getEJ en PilotoViewModel y agregar a pilotosList
                        foreach (var item in lastGetEJ)
                        {
                            PilotoViewModel add = new PilotoViewModel
                            {
                                Creation = (DateTime)item.Creation,
                                Vin = item.Vin,
                                type = item.Type,
                                Sequence = (long)item.Sequence,
                                FullVin = item.FullVin,
                                Color = item.Color,
                                Enviado = item.Enviado,
                                Nempleado = item.Nempleado
                            };

                            pilotosList.Add(add);
                        }

                        // Ordenar pilotosList por Creation de forma descendente
                        var ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate && t.Enviado != null).ToList();

                        if (allData)
                        {
                            ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate).ToList();
                        }

                        // Configurar el contexto de la licencia de EPPlus
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        try
                        {
                            using (var pck = new ExcelPackage(memoryStream))
                            {
                                var sheet = pck.Workbook.Worksheets.Add(dType);

                                // Agregar encabezados
                                sheet.Cells[1, 1].Value = "Creation";
                                sheet.Cells[1, 2].Value = "Sequence";
                                sheet.Cells[1, 3].Value = "Vin";
                                sheet.Cells[1, 4].Value = "Type";
                                sheet.Cells[1, 5].Value = "Color";
                                sheet.Cells[1, 6].Value = "Full Vin";

                                // Agregar datos de la lista
                                for (int i = 0; i < ordenar.Count; i++)
                                {
                                    sheet.Cells[i + 2, 1].Value = ordenar[i].Creation;
                                    sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                    sheet.Cells[i + 2, 2].Value = ordenar[i].Sequence;
                                    sheet.Cells[i + 2, 3].Value = ordenar[i].Vin;
                                    sheet.Cells[i + 2, 4].Value = ordenar[i].type;
                                    sheet.Cells[i + 2, 5].Value = ordenar[i].Color;
                                    sheet.Cells[i + 2, 6].Value = ordenar[i].FullVin;
                                }

                                // Autoajustar columnas para el contenido
                                sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                                pck.Save();
                            }
                            memoryStream.Position = 0;

                            // Devolver el archivo Excel como FileResult
                            return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nameSheet + ".xlsx");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                            return null; // Manejar el error apropiadamente según tus necesidades
                        }

                    }

                    if (dType == "KM74")
                    {
                        await LoadData();

                        var getKM74 = await _context.Km74s.OrderByDescending(x => x.Id).ToListAsync();
                        List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();

                        var lastGetKM74 = getKM74.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                        // Convertir elementos de getEJ en PilotoViewModel y agregar a pilotosList
                        foreach (var item in lastGetKM74)
                        {
                            PilotoViewModel add = new PilotoViewModel
                            {
                                Creation = (DateTime)item.Creation,
                                Vin = item.Vin,
                                type = item.Type,
                                Sequence = (long)item.Sequence,
                                FullVin = item.FullVin,
                                Color = item.Color,
                                Enviado = item.Enviado,
                                Nempleado = item.Nempleado
                            };

                            pilotosList.Add(add);
                        }

                        // Ordenar pilotosList por Creation de forma descendente
                        var ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate && t.Enviado != null).ToList();

                        if (allData)
                        {
                            ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate).ToList();
                        }

                        // Configurar el contexto de la licencia de EPPlus
                        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                        try
                        {
                            using (var pck = new ExcelPackage(memoryStream))
                            {
                                var sheet = pck.Workbook.Worksheets.Add(dType);

                                // Agregar encabezados
                                sheet.Cells[1, 1].Value = "Creation";
                                sheet.Cells[1, 2].Value = "Sequence";
                                sheet.Cells[1, 3].Value = "Vin";
                                sheet.Cells[1, 4].Value = "Type";
                                sheet.Cells[1, 5].Value = "Color";
                                sheet.Cells[1, 6].Value = "Full Vin";

                                // Agregar datos de la lista
                                for (int i = 0; i < ordenar.Count; i++)
                                {
                                    sheet.Cells[i + 2, 1].Value = ordenar[i].Creation;
                                    sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                    sheet.Cells[i + 2, 2].Value = ordenar[i].Sequence;
                                    sheet.Cells[i + 2, 3].Value = ordenar[i].Vin;
                                    sheet.Cells[i + 2, 4].Value = ordenar[i].type;
                                    sheet.Cells[i + 2, 5].Value = ordenar[i].Color;
                                    sheet.Cells[i + 2, 6].Value = ordenar[i].FullVin;
                                }

                                // Autoajustar columnas para el contenido
                                sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                                pck.Save();
                            }
                            memoryStream.Position = 0;

                            // Devolver el archivo Excel como FileResult
                            return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nameSheet + ".xlsx");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                            return null; // Manejar el error apropiadamente según tus necesidades
                        }

                    }
                }
                else
                {
                    await LoadData();

                    var getKM = await _context.PilotosLists.OrderByDescending(x => x.Id).ToListAsync();
                    var getEJ = await _context.Ejlists.OrderByDescending(x => x.Id).ToListAsync();
                    List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();

                    var lastGetKM = getKM.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                    var lastGetEJ = getEJ.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                    // Convertir elementos de getKM en PilotoViewModel y agregar a pilotosList
                    foreach (var item in lastGetKM)
                    {

                        PilotoViewModel add = new PilotoViewModel
                        {
                            Creation = (DateTime)item.Creation,
                            Vin = item.Vin,
                            type = item.Type,
                            Sequence = (long)item.Suquence,
                            FullVin = item.FullVin,
                            Color = item.Color,
                            Enviado = item.Enviado,
                            Nempleado = item.Nempleado,
                            Bpart = item.Bpart
                        };

                        pilotosList.Add(add);
                    }

                    // Convertir elementos de getEJ en PilotoViewModel y agregar a pilotosList
                    foreach (var item in lastGetEJ)
                    {
                        PilotoViewModel add = new PilotoViewModel
                        {
                            Creation = (DateTime)item.Creation,
                            Vin = item.Vin,
                            type = item.Type,
                            Sequence = (long)item.Sequence,
                            FullVin = item.FullVin,
                            Color = item.Color,
                            Enviado = item.Enviado,
                            Nempleado = item.Nempleado
                        };

                        pilotosList.Add(add);
                    }

                    // Ordenar pilotosList por Creation de forma descendente
                    var ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate && t.Enviado != null).ToList();

                    if (allData)
                    {
                        ordenar = pilotosList.OrderByDescending(x => x.Creation).Where(t => t.Creation >= startDate && t.Creation <= endDate).ToList();
                    }

                    // Abrir el archivo Excel y trabajar con EPPlus
                    try
                    {
                        using (var pck = new ExcelPackage(memoryStream))
                        {
                            var sheet = pck.Workbook.Worksheets.Add(dType);

                            // Agregar encabezados
                            sheet.Cells[1, 1].Value = "Creation";
                            sheet.Cells[1, 2].Value = "Sequence";
                            sheet.Cells[1, 3].Value = "Vin";
                            sheet.Cells[1, 4].Value = "Type";
                            sheet.Cells[1, 5].Value = "Color";
                            sheet.Cells[1, 6].Value = "Full Vin";
                            sheet.Cells[1, 7].Value = "Bpart";

                            // Agregar datos de la lista
                            for (int i = 0; i < ordenar.Count; i++)
                            {
                                sheet.Cells[i + 2, 1].Value = ordenar[i].Creation;
                                sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                sheet.Cells[i + 2, 2].Value = ordenar[i].Sequence;
                                sheet.Cells[i + 2, 3].Value = ordenar[i].Vin;
                                sheet.Cells[i + 2, 4].Value = ordenar[i].type;
                                sheet.Cells[i + 2, 5].Value = ordenar[i].Color;
                                sheet.Cells[i + 2, 6].Value = ordenar[i].FullVin;
                                sheet.Cells[i + 2, 7].Value = ordenar[i].Bpart;
                            }

                            // Autoajustar columnas para el contenido
                            sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                            pck.Save();
                        }
                        memoryStream.Position = 0;

                        // Devolver el archivo Excel como FileResult
                        return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", nameSheet + ".xlsx");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                        return null; // Manejar el error apropiadamente según tus necesidades
                    }
                }
            }

            if (search != null)
            {
                bool advanceFilter = search.Contains("*");
                var split_Search = search.Split('*');
                List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();

                foreach (var itemsplit in split_Search)
                {
                    Console.WriteLine(itemsplit);
                    var getKM = await _context.PilotosLists.Where(x => x.Vin.Contains(itemsplit)).OrderByDescending(x => x.Id).ToListAsync();
                    var getEJ = await _context.Ejlists.Where(x => x.Vin.Contains(itemsplit)).OrderByDescending(x => x.Id).ToListAsync();

                    foreach (var item in getKM)
                    {

                        PilotoViewModel add = new PilotoViewModel
                        {
                            Creation = (DateTime)item.Creation,
                            Vin = item.Vin,
                            type = item.Type,
                            Sequence = (long)item.Suquence,
                            FullVin = item.FullVin,
                            Color = item.Color,
                            Enviado = item.Enviado,
                            Nempleado = item.Nempleado,
                            Bpart = item.Bpart
                        };

                        pilotosList.Add(add);
                    }

                    // Convertir elementos de getEJ en PilotoViewModel y agregar a pilotosList
                    foreach (var item in getEJ)
                    {
                        PilotoViewModel add = new PilotoViewModel
                        {
                            Creation = (DateTime)item.Creation,
                            Vin = item.Vin,
                            type = item.Type,
                            Sequence = (long)item.Sequence,
                            FullVin = item.FullVin,
                            Color = item.Color,
                            Enviado = item.Enviado,
                            Nempleado = item.Nempleado
                        };

                        pilotosList.Add(add);
                    }

                }

                // Ordenar pilotosList por Creation de forma descendente
                var ordenar = pilotosList.OrderByDescending(x => x.Creation).Take(100).ToList();

                return ordenar != null ?
                          View(ordenar) :
                          Problem("Entity set 'PilotosContext.PilotosLists'  is null.");

            }

            if (vin != null)
            {
                bool EJMBJ = type.Contains("EJ") && color.Contains("MBJ");
                bool EJGW7 = type.Contains("EJ") && color.Contains("GW7");
                bool EJKXJ = type.Contains("EJ") && color.Contains("KXJ");
                bool EJSSE = type.Contains("EJ") && color.Contains("SSE");
                bool EJWAS = type.Contains("EJ") && color.Contains("WAS");
                bool EJZR6 = type.Contains("EJ") && color.Contains("ZR6");
                bool EJLPS = type.Contains("EJ") && color.Contains("LPS");
                bool KM74MBJ = type.Contains("KM74") && color.Contains("MBJ");
                bool KM74GW7 = type.Contains("KM74") && color.Contains("GW7");
                bool KM74KXJ = type.Contains("KM74") && color.Contains("KXJ");
                bool KM74SSE = type.Contains("KM74") && color.Contains("SSE");
                bool KM74WAS = type.Contains("KM74") && color.Contains("WAS");
                bool KM74ZR6 = type.Contains("KM74") && color.Contains("ZR6");
                bool KM74LPS = type.Contains("KM74") && color.Contains("LPS");
                bool MBJ = type.Contains("KM49") && color.Contains("MBJ"); 
                bool KXJ = type.Contains("KM49") && color.Contains("KXJ");
                bool GW7 = type.Contains("KM49") && color.Contains("GW7"); 
                bool SSE = type.Contains("KM49") && color.Contains("SSE");
                bool WAS = type.Contains("KM49") && color.Contains("WAS"); 
                bool ZR6 = type.Contains("KM49") && color.Contains("ZR6");
                bool LPS = type.Contains("KM49") && color.Contains("LPS");

                ZplPrinter zplPrinter = new ZplPrinter();

                if (EJMBJ)
                {
                    string FrontDesc = "Front Fascia Hydro Blue";
                    string RearDesc = "Rear Fascia Hydro Blue";

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (EJKXJ)
                {
                    string FrontDesc = "Front Fascia Diamond Black";
                    string RearDesc = "Rear Fascia Diamond Black";

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (EJGW7)
                {
                    string FrontDesc = "Front Fascia Bright White";
                    string RearDesc = "Rear Fascia Bright White";

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);

                    return RedirectToAction("Index", "Pilotos");
                }

                if (EJSSE)
                {
                    string FrontDesc = "Front Fascia Silver Zynith";
                    string RearDesc = "Rear Fascia Silver Zynith";

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (EJWAS)
                {
                    string FrontDesc = "Front Fascia Baltic Gray";
                    string RearDesc = "Rear Fascia Baltic Gray";

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (EJZR6)
                {
                    string FrontDesc = "Front Fascia Red Hot";
                    string RearDesc = "Rear Fascia Red Hot";

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (EJLPS)
                {
                    string FrontDesc = "Front Fascia Fantom Blue";
                    string RearDesc = "Rear Fascia Fantom Blue";

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (MBJ)
                {
                    part = "7KM79MBJAA";
                    string HoodDesc = "Hood Applique Hydro Blue";
                    string FrontDesc = "KM49 Front Fascia Hydro Blue";
                    string RearDesc = "KM49 Rear Fascia Hydro Blue";
                    string LGDesc = "KIT KM49 LG HYDRO BLUE";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (KXJ)
                {
                    part = "7KM79KXJAA";
                    string HoodDesc = "Hood Applique Diamond Black";
                    string FrontDesc = "KM49 Front Fascia Diamond Black";
                    string RearDesc = "KM49 Rear Fascia Diamond Black";
                    string LGDesc = "KIT KM49 LG Diamond Black";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (GW7)
                {
                    string partEYEBROW = "7KM79GW7AA";
                    string UpperFRPart = "7LB46GW7AB";
                    string UpperRRPart = "7LB71GW7AC";

                    string EyeDesc = "EyeBrow Bright White";
                    string FrontDesc = "KM49 Front Fascia Bright White";
                    string RearDesc = "KM49 Rear Fascia Bright White";
                    string LGDesc = "KIT KM49 LG Bright White";


                    zplPrinter.PrintHood(ipAddres, port, partEYEBROW, EyeDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, UpperFRPart, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, UpperRRPart, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (SSE)
                {
                    part = "7KM79SSEAA";
                    string HoodDesc = "Hood Applique Silver Zynith";
                    string FrontDesc = "KM49 Front Fascia Silver Zynith";
                    string RearDesc = "KM49 Rear Fascia Silver Zynith";
                    string LGDesc = "KIT KM49 LG Silver Zynith";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (WAS)
                {
                    part = "7KM79WASAA";
                    string HoodDesc = "Hood Applique Baltic Gray";
                    string FrontDesc = "KM49 Front Fascia Baltic Gray";
                    string RearDesc = "KM49 Rear Fascia Baltic Gray";
                    string LGDesc = "KIT KM49 LG Baltic Gray";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (ZR6)
                {
                    part = "7KM79ZR6AA";
                    string HoodDesc = "Hood Applique Red Hot";
                    string FrontDesc = "KM49 Front Fascia Red Hot";
                    string RearDesc = "KM49 Rear Fascia Red Hot";
                    string LGDesc = "KIT KM49 LG Red Hot";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (LPS)
                {
                    part = "7KM79LPSAA";
                    string HoodDesc = "Hood Applique Fantom Blue";
                    string FrontDesc = "KM49 Front Fascia Fantom Blue";
                    string RearDesc = "KM49 Rear Fascia Fantom Blue";
                    string LGDesc = "KIT KM49 LG Fantom Blue";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");
                }

                if (KM74MBJ)
                {
                    string HoodDesc = "EyeBrow Hydro Blue";
                    string FrontDesc = "KM74 Front Fascia Hydro Blue";
                    string RearDesc = "KM74 Rear Fascia Hydro Blue";
                    string LGDesc = "KIT KM74 LG HYDRO BLUE";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, part, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, part, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (KM74GW7)
                {
                    string HoodDesc = "EyeBrow Bright White";
                    string FrontDesc = "KM74 Front Fascia Bright White";
                    string RearDesc = "KM74 Rear Fascia Bright White";
                    string LGDesc = "KIT KM74 LG Bright White";

                    zplPrinter.PrintHood(ipAddres, port, eyePart, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (KM74KXJ)
                {
                    string HoodDesc = "EyeBrow  Diamond Black";
                    string FrontDesc = "KM74 Front Fascia Diamond Black";
                    string RearDesc = "KM74 Rear Fascia Diamond Black";
                    string LGDesc = "KIT KM74 LG Diamond Black";

                    zplPrinter.PrintHood(ipAddres, port, eyePart, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (KM74SSE)
                {
                    string HoodDesc = "EyeBrow Silver Zynith";
                    string FrontDesc = "KM74 Front Fascia Silver Zynith";
                    string RearDesc = "KM74 Rear Fascia Silver Zynith";
                    string LGDesc = "KIT KM74 LG Silver Zynith";

                    zplPrinter.PrintHood(ipAddres, port, eyePart, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (KM74WAS)
                {
                    string HoodDesc = "EyeBrow Baltic Gray";
                    string FrontDesc = "KM74 Front Fascia Baltic Gray";
                    string RearDesc = "KM74 Rear Fascia Baltic Gray";
                    string LGDesc = "KIT KM74 LG Baltic Gray";

                    zplPrinter.PrintHood(ipAddres, port, eyePart, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (KM74ZR6)
                {
                    string HoodDesc = "EyeBrow Red Hot";
                    string FrontDesc = "KM74 Front Fascia Red Hot";
                    string RearDesc = "KM74 Rear Fascia Red Hot";
                    string LGDesc = "KIT KM74 LG Red Hot";

                    zplPrinter.PrintHood(ipAddres, port, eyePart, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                if (KM74LPS)
                {
                    string HoodDesc = "EyeBrow Fantom Blue";
                    string FrontDesc = "KM74 Front Fascia Fantom Blue";
                    string RearDesc = "KM74 Rear Fascia Fantom Blue";
                    string LGDesc = "KIT KM74 LG Fantom Blue";

                    zplPrinter.PrintHood(ipAddres, port, eyePart, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintKM74NP(ipAddres, port, frontlwr, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintKM74NP(ipAddres, port, rearlwr, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "Pilotos");

                }

                return RedirectToAction("Index", "Pilotos");
            }
            else
            {
                await LoadData();

                // Obtener los parámetros enviados por DataTables
                var draw = HttpContext.Request.Query["draw"].FirstOrDefault() ?? "1";
                var start = int.Parse(HttpContext.Request.Query["start"].FirstOrDefault() ?? "0");
                var length = int.Parse(HttpContext.Request.Query["length"].FirstOrDefault() ?? "10");
                var searchValue = HttpContext.Request.Query["search[value]"].FirstOrDefault();
                var sortColumnIndex = HttpContext.Request.Query["order[0][column]"].FirstOrDefault();
                var sortColumnDir = HttpContext.Request.Query["order[0][dir]"].FirstOrDefault();


                List<PilotosList> getKM = await _context.PilotosLists.OrderByDescending(x => x.Id).Take(1000).ToListAsync();
                var getEJ = await _context.Ejlists.OrderByDescending(x => x.Id).ToListAsync();
                var getKM74 = await _context.Km74s.OrderByDescending(x => x.Id).ToListAsync();
                List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();

                var lastGetKM = getKM.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                var lastGetEJ = getEJ.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                var lastGetKM74 = getKM74.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                // Convertir elementos de getKM en PilotoViewModel y agregar a pilotosList
                foreach (var item in lastGetKM)
                {

                    PilotoViewModel add = new PilotoViewModel
                    {
                        Creation = (DateTime)item.Creation,
                        Vin = item.Vin,
                        type = item.Type,
                        Sequence = (long)item.Suquence,
                        FullVin = item.FullVin,
                        Color = item.Color,
                        Enviado = item.Enviado,
                        Nempleado = item.Nempleado,
                        Bpart = item.Bpart
                    };

                    pilotosList.Add(add);
                }

                // Convertir elementos de getKM en PilotoViewModel y agregar a pilotosList
                foreach (var item in getKM74)
                {

                    PilotoViewModel add = new PilotoViewModel
                    {
                        Creation = (DateTime)item.Creation,
                        Vin = item.Vin,
                        type = item.Type,
                        Sequence = (long)item.Sequence,
                        FullVin = item.FullVin,
                        Color = item.Color,
                        Enviado = item.Enviado,
                        Nempleado = item.Nempleado,
                        FrUppEyeBrow = item.FrUppEyeBrow,
                        FrtLwrFascia = item.FrtLwrFascia,
                        RrLwrFascia = item.RrLwrFascia
                    };

                    pilotosList.Add(add);
                }

                // Convertir elementos de getEJ en PilotoViewModel y agregar a pilotosList
                foreach (var item in lastGetEJ)
                {
                    PilotoViewModel add = new PilotoViewModel
                    {
                        Creation = (DateTime)item.Creation,
                        Vin = item.Vin,
                        type = item.Type,
                        Sequence = (long)item.Sequence,
                        FullVin = item.FullVin,
                        Color = item.Color,
                        Enviado = item.Enviado,
                        Nempleado = item.Nempleado,
                        FrtLwrFascia = item.FrtLwrFascia,
                        RrLwrFascia = item.RrLwrFasca
                    };

                    pilotosList.Add(add);
                }

                var count = pilotosList.Count();

                // Ordenar pilotosList por Creation de forma descendente
                var ordenar = pilotosList.OrderByDescending(x => x.Creation).Take(count).ToList();

                //var filteredData = ordenar.Skip(start).Take(length).ToList();

                //// Preparar la respuesta
                //var response = new DataTableResponseViewModel<PilotoViewModel>
                //{
                //    Draw = int.Parse(draw),
                //    RecordsTotal = ordenar.Count(),
                //    RecordsFiltered = ordenar.Count(),
                //    Data = filteredData
                //};

                //return Json(response);

                return ordenar != null ?
                          View(ordenar) :
                          Problem("Entity set 'PilotosContext.PilotosLists'  is null.");

            }

        }

        // GET: Pilotos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PilotosLists == null)
            {
                return NotFound();
            }

            var pilotosList = await _context.PilotosLists
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pilotosList == null)
            {
                return NotFound();
            }

            return View(pilotosList);
        }

        // GET: Pilotos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PilotosLists == null)
            {
                return NotFound();
            }

            var pilotosList = await _context.PilotosLists.FindAsync(id);
            if (pilotosList == null)
            {
                return NotFound();
            }
            return View(pilotosList);
        }

        // POST: Pilotos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Suquence,Vin,Creation,FullVin,Color,Type,Id,Enviado,Nempleado")] PilotosList pilotosList)
        {
            if (id != pilotosList.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pilotosList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PilotosListExists(pilotosList.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pilotosList);
        }

        public async Task<IActionResult> Edit2(string vin, string enviado, int nempleado, string type)
        {
            if (type.Contains("KM49"))
            {
                await _context.Database.ExecuteSqlRawAsync(
                    "UPDATE [PilotosList] SET [Enviado] = @p0, [NEmpleado] = @p1 WHERE Vin = @p2",
                    enviado, nempleado, vin);
            }
            else if (type.Contains("KM74"))
            {
                await _context.Database.ExecuteSqlRawAsync(
                    "UPDATE [Pilotos].[dbo].[KM74] SET [Enviado] = @p0, [NEmpleado] = @p1 WHERE Vin = @p2",
                    enviado, nempleado, vin);
            }
            else
            {
                await _context.Database.ExecuteSqlRawAsync(
                    "UPDATE [EJList] SET [Enviado] = @p0, [NEmpleado] = @p1 WHERE Vin = @p2",
                    enviado, nempleado, vin);
                Console.WriteLine("Se ejecuto");
            }

            return RedirectToAction(nameof(Index));
        }


        private bool PilotosListExists(int id)
        {
          return (_context.PilotosLists?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<string> GetSubjectNo(string orderNo)
        {
            string result = null;
            string sqlQuery = @"
            SELECT S_NO 
            FROM JITTOE.J_SUBJECTCOMPELEM 
            INNER JOIN J_SUBJECT ON S_ID=SCE_USEDSUBJECT_ID
            WHERE SCE_SUBJECTCOMP_ID=
            (SELECT SC_ID FROM JITTOE.J_SUBJECTCOMP WHERE SC_PRODUCEDSUBJECT_ID=
            (SELECT S_ID FROM J_SUBJECT 
            WHERE S_NO=(SELECT S_NO FROM J_ORDER 
            INNER JOIN J_ORDERENTRY ON O_ID = OE_ORDER_ID 
            INNER JOIN J_SUBJECT ON S_ID = OE_SUBJECT_ID
            INNER JOIN J_SUBJECTTYPE ON S_SUBJECTTYPE_ID = STY_ID
            WHERE O_NO = :orderNo AND STY_ID = 701) AND S_COMPANY_ID=1))
            AND S_SUBJECTTYPE_ID=702";

            using (var command = _modelContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = sqlQuery;
                command.Parameters.Add(new OracleParameter("orderNo", orderNo));

                try
                {
                    _modelContext.Database.OpenConnection();

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            result = reader.GetString(0);
                        }
                    }
                }
                finally
                {
                    _modelContext.Database.CloseConnection();
                }
            }

            return result;
        }
            
        public async Task<List<PilotosList>> getData()
        {
            //getLast Piloto Save.
            var lastRegistroSQLServer = await _context.PilotosLists.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            //GetLas Oracle Piloto.
            
            var lasRegstroOracle = await _modelContext.JTransferspackets.Where(x => x.TspData.Contains("KMX")
                && x.TspData.Contains("X8V")
                && x.TspData.Contains("G ")
                && x.TspTcreation >= dateTime.AddDays(-5))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            if (lastRegistroSQLServer != null && lasRegstroOracle != null)
            {
                if (lastRegistroSQLServer.Creation < lasRegstroOracle.TspTcreation)
                {
                    //Update apartir de la ultima fecha registrada.
                    Console.WriteLine("Update data ");

                    List<Models.JTransferspacket> jitKM49 = await _modelContext.JTransferspackets
                        .Where(x => x.TspData.Contains("KMX")
                        && x.TspData.Contains("X8V")
                        && x.TspData.Contains("G ")
                        && x.TspTcreation > lastRegistroSQLServer.Creation)
                        .ToListAsync();

                    List<PilotosList> listaPilotos = new();
                    {
                        for (int i = 0; i < jitKM49.Count(); i++)
                        {
                            int creationYear = jitKM49[i].TspTcreation.Year;
                            bool isYear2023 = creationYear == 2023;
                            int getYear = isYear2023 ? 2023 : 2024;
                            string yearIndex = getYear.ToString();

                            // Data Transform
                            System.String[] delimiters = { "  ", " ", ".", "KMX", "SPT40313", yearIndex, "0000" };
                            string vins = jitKM49[i].TspData.ToString();
                            string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                            sbs2 = long.Parse(subs[2]);

                            bool was = jitKM49[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                            bool sse = jitKM49[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                            bool gw7 = jitKM49[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                            bool kxj = jitKM49[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                            bool zr6 = jitKM49[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                            bool mbj = jitKM49[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                            bool lps = jitKM49[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                            //add Bpart LG
                            string orderNo = subs[0];
                            var resultTest = await GetSubjectNo(orderNo);

                            // Crear un objeto PilotosList con los datos correspondientes
                            PilotosList piloto = new PilotosList
                            {
                                Vin = subs[0],
                                Type = "KM49",
                                Suquence = sbs2,
                                FullVin = subs.Last(),
                                Color = color,
                                Creation = jitKM49[i].TspTcreation,
                                Bpart = resultTest
                            };

                            // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                            if (!piloto.Vin.Contains("KM"))
                            {
                                listaPilotos.Add(piloto);
                            }

                        }

                    }

                    List<PilotosList> uniqueDataList = listaPilotos
                        .GroupBy(x => x.Vin)
                        .Select(g => g.First())
                        .ToList();
                    return uniqueDataList;
                }
            }
            else
            {
                if (lastRegistroSQLServer == null)
                {
                    //Update apartir de la ultima fecha registrada.
                    Console.WriteLine("Update data ");
                    List<Models.JTransferspacket> jitKM49 = await _modelContext.JTransferspackets
                        .Where(x => x.TspData.Contains("KMX")
                        && x.TspData.Contains("X8V")
                        && x.TspData.Contains("G ")
                        && x.TspTcreation >= fInicio)
                        .ToListAsync();

                    List<PilotosList> listaPilotos = new();
                    {
                        for (int i = 0; i < jitKM49.Count(); i++)
                        {
                            int creationYear = jitKM49[i].TspTcreation.Year;
                            bool isYear2023 = creationYear == 2023;
                            int getYear = isYear2023 ? 2023 : 2024;
                            string yearIndex = getYear.ToString();

                            // Data Transform
                            System.String[] delimiters = { "  ", " ", ".", "KMX", "SPT40313", yearIndex, "0000" };
                            string vins = jitKM49[i].TspData.ToString();
                            string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                            sbs2 = long.Parse(subs[2]);

                            bool was = jitKM49[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                            bool sse = jitKM49[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                            bool gw7 = jitKM49[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                            bool kxj = jitKM49[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                            bool zr6 = jitKM49[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                            bool mbj = jitKM49[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                            bool lps = jitKM49[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                            //add Bpart LG
                            string orderNo = subs[0];

                            var resultTest = await GetSubjectNo(orderNo);

                            // Crear un objeto PilotosList con los datos correspondientes
                            PilotosList piloto = new PilotosList
                            {
                                Vin = subs[0],
                                Type = "KM49",
                                Suquence = sbs2,
                                FullVin = subs.Last(),
                                Color = color,
                                Creation = jitKM49[i].TspTcreation,
                                Enviado = "1",
                                Nempleado = 0,
                                Bpart = resultTest
                            };

                            // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                            if (!piloto.Vin.Contains("KM"))
                            {
                                listaPilotos.Add(piloto);
                            }
                        }
                    }

                    List<PilotosList> uniqueDataList = listaPilotos
                        .GroupBy(x => x.Vin)
                        .Select(g => g.First())
                        .ToList();
                    return uniqueDataList;
                }
                
            }

            List<PilotosList> noUpdateData = null;

            return noUpdateData;

        }

        public async Task<List<Km74>> getKM74Data()
        {
            //getLast Piloto Save.
            var lastRegistroSQLServer = await _context.Km74s.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            //GetLas Oracle Piloto.

            var lasRegstroOracle = await _modelContext.JTransferspackets.Where(x => x.TspData.Contains("KMJ")
                && x.TspData.Contains("X8V")
                && x.TspData.Contains("G ")
                && x.TspTcreation >= dateTime.AddDays(-15))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            if (lastRegistroSQLServer != null && lasRegstroOracle != null)
            {
                if (lastRegistroSQLServer.Creation < lasRegstroOracle.TspTcreation)
                {
                    //Update apartir de la ultima fecha registrada.
                    Console.WriteLine("Update data ");

                    List<Models.JTransferspacket> jitKM74 = await _modelContext.JTransferspackets
                        .Where(x => x.TspData.Contains("KMJ")
                        && x.TspData.Contains("X8U")
                        && x.TspData.Contains("G ")
                        && x.TspTcreation > lastRegistroSQLServer.Creation)
                        .ToListAsync();

                    List<Models.JTransferspacket> jitKM74X8W = await _modelContext.JTransferspackets
                        .Where(x => x.TspData.Contains("KMJ")
                        && x.TspData.Contains("X8W")
                        && x.TspData.Contains("G ")
                        && x.TspTcreation > lastRegistroSQLServer.Creation)
                        .ToListAsync();

                    List<Km74> listaPilotos = new();
                    {
                        for (int i = 0; i < jitKM74.Count(); i++)
                        {
                            int creationYear = jitKM74[i].TspTcreation.Year;
                            bool isYear2023 = creationYear == 2023;
                            bool isYear2024 = creationYear == 2024;
                            int getYear = isYear2023 ? 2023 : (isYear2024 ? 2024 : 2025);
                            string yearIndex = getYear.ToString();

                            // Data Transform
                            System.String[] delimiters = { "  ", " ", ".", "KMJ", "SPT40313", yearIndex, "0000", "001", "002" };
                            string vins = jitKM74[i].TspData.ToString();
                            string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                            sbs2 = long.Parse(subs[2]);

                            bool was = jitKM74[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                            bool sse = jitKM74[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                            bool gw7 = jitKM74[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                            bool kxj = jitKM74[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                            bool zr6 = jitKM74[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                            bool mbj = jitKM74[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                            bool lps = jitKM74[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                            // Insertar numero de parte si existe.
                            bool lwrRear1 = jitKM74[i].TspData.Contains("68574661AA"); if (lwrRear1 == true) rrLwrF = "68705244AA";
                            bool lwrRear2 = jitKM74[i].TspData.Contains("68705244AA"); if (lwrRear2 == true) rrLwrF = "68705244AA";
                            bool lwrRear3 = jitKM74[i].TspData.Contains("68574662AA"); if (lwrRear3 == true) rrLwrF = "68574662AA";
                            bool lwrRear4 = jitKM74[i].TspData.Contains("68644688AA"); if (lwrRear4 == true) rrLwrF = "68644688AA";

                            // Crear un objeto PilotosList con los datos correspondientes
                            Km74 piloto = new Km74
                            {
                                Vin = subs[0],
                                Type = "KM74",
                                Sequence = sbs2,
                                FullVin = subs.Last(),
                                Color = color,
                                Creation = jitKM74[i].TspTcreation,
                                RrLwrFascia = rrLwrF
                            };

                            // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                            if (!piloto.Vin.Contains("KM"))
                            {
                                listaPilotos.Add(piloto);
                            }

                        }

                    }

                    List<Km74> listaPilotosX8W = new List<Km74>();
                    for (int i = 0; i < jitKM74X8W.Count(); i++)
                    {
                        int creationYear = jitKM74X8W[i].TspTcreation.Year;
                        bool isYear2023 = creationYear == 2023;
                        int getYear = isYear2023 ? 2023 : 2024;
                        string yearIndex = getYear.ToString();

                        // Data Transform
                        string[] delimiters = { "  ", " ", ".", "KMJ", "SPT40313", yearIndex, "0000", "001", "002" };
                        string vins = jitKM74X8W[i].TspData.ToString();
                        string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        long sbs2 = long.Parse(subs[2]);

                        bool was = jitKM74X8W[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                        bool sse = jitKM74X8W[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                        bool gw7 = jitKM74X8W[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                        bool kxj = jitKM74X8W[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                        bool zr6 = jitKM74X8W[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                        bool mbj = jitKM74X8W[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                        bool lps = jitKM74X8W[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                        //Insertar numero de parte si existe.
                        bool lwrFront1 = jitKM74[i].TspData.Contains("7KL52GXHAA"); if (lwrFront1 == true) frLwrF = "7KL52GXHAA";
                        bool lwrFront2 = jitKM74[i].TspData.Contains("68667445AA"); if (lwrFront2 == true) frLwrF = "68667445AA";
                        bool lwrFront3 = jitKM74[i].TspData.Contains("68667446AA"); if (lwrFront3 == true) frLwrF = "68667446AA";
                        bool lwrFront4 = jitKM74[i].TspData.Contains("68667801AA"); if (lwrFront4 == true) frLwrF = "68667801AA";

                        // Create a Km74 object with the corresponding data
                        Km74 piloto = new Km74
                        {
                            Vin = subs[0],
                            Type = "KM74",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = color,
                            Creation = jitKM74X8W[i].TspTcreation,
                            FrtLwrFascia = frLwrF,
                            FrUppEyeBrow = subs[subs.Count() - 2]
                        };

                        // Add the object to the list only if Vin does not contain "KM"
                        if (!piloto.Vin.Contains("KM"))
                        {
                            listaPilotosX8W.Add(piloto);
                        }
                    }

                    foreach (var item in listaPilotosX8W)
                    {
                        var existingItem = listaPilotos.FirstOrDefault(x => x.Vin == item.Vin);
                        if (existingItem != null)
                        {
                            existingItem.FrtLwrFascia = item.FrtLwrFascia;
                            existingItem.FrUppEyeBrow = item.FrUppEyeBrow;
                        }
                        else
                        {
                            listaPilotos.Add(item);
                        }
                    }


                    List<Km74> uniqueDataList = listaPilotos
                        .GroupBy(x => x.Vin)
                        .Select(g => g.First())
                        .ToList();
                    return uniqueDataList;
                }
            }
            else
            {
                //Update apartir de la ultima fecha registrada.
                Console.WriteLine("Update data ");
                List<Models.JTransferspacket> jitKM74 = await _modelContext.JTransferspackets
                    .Where(x => x.TspData.Contains("KMJ")
                    && x.TspData.Contains("X8V")
                    && x.TspData.Contains("G ")
                    && x.TspTcreation >= fInicio)
                    .ToListAsync();

                List<Km74> listaPilotos = new();
                {
                    for (int i = 0; i < jitKM74.Count(); i++)
                    {
                        int creationYear = jitKM74[i].TspTcreation.Year;
                        bool isYear2023 = creationYear == 2023;
                        int getYear = isYear2023 ? 2023 : 2024;
                        string yearIndex = getYear.ToString();

                        // Data Transform
                        System.String[] delimiters = { "  ", " ", ".", "KMJ", "SPT40313", yearIndex, "0000" };
                        string vins = jitKM74[i].TspData.ToString();
                        string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        sbs2 = long.Parse(subs[2]);

                        bool was = jitKM74[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                        bool sse = jitKM74[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                        bool gw7 = jitKM74[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                        bool kxj = jitKM74[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                        bool zr6 = jitKM74[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                        bool mbj = jitKM74[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                        bool lps = jitKM74[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                        // Crear un objeto PilotosList con los datos correspondientes
                        Km74 piloto = new Km74
                        {
                            Vin = subs[0],
                            Type = "KM74",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = color,
                            Creation = jitKM74[i].TspTcreation
                        };

                        // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                        if (!piloto.Vin.Contains("KM"))
                        {
                            listaPilotos.Add(piloto);
                        }
                    }
                }

                List<Km74> uniqueDataList = listaPilotos
                    .GroupBy(x => x.Vin)
                    .Select(g => g.First())
                    .ToList();
                return uniqueDataList;
            }

            List<Km74> noUpdateData = null;

            return noUpdateData;

        }

        public async Task<List<Ejlist>> getEJData()
        {
            var lasRegistroEJList = await _context.Ejlists.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            var lasEJOracle = await _modelContext.JTransferspackets.Where(x => x.TspData.Contains("SP")
                && x.TspData.Contains("EJ")
                && x.TspData.Contains("X8W")
                && x.TspData.Contains("G ")
                && x.TspTcreation >= dateTime.AddDays(-15))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            if (lasRegistroEJList != null && lasEJOracle != null)
            {
                if (lasRegistroEJList.Creation < lasEJOracle.TspTcreation)
                {
                    //Update EJ Data since lastDate
                    List<JTransferspacket> jitEJ = await _modelContext.JTransferspackets
                        .Where(x => x.TspData.Contains("SP")
                        && x.TspData.Contains("EJ")
                        && x.TspData.Contains("X8W")
                        && x.TspData.Contains("G ")
                        && x.TspTcreation > lasRegistroEJList.Creation)
                        .ToListAsync();

                    List<JTransferspacket> jitEJX8U = await _modelContext.JTransferspackets
                        .Where(x => x.TspData.Contains("SP")
                        && x.TspData.Contains("EJ")
                        && x.TspData.Contains("X8U")
                        && x.TspData.Contains("G ")
                        && x.TspTcreation > lasRegistroEJList.Creation)
                        .ToListAsync();

                    List<Ejlist> Ejlist = new();
                    {
                        for (int i = 0; i < jitEJ.Count(); i++)
                        {
                            // Data Transform
                            System.String[] delimiters = { "  ", " ", ".", "SPT40313", "EJ", "2024", "0000", "001", "002" };
                            string vins = jitEJ[i].TspData.ToString();
                            string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                            sbs22 = long.Parse(subs[2]);

                            bool was = jitEJ[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                            bool sse = jitEJ[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                            bool gw7 = jitEJ[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                            bool kxj = jitEJ[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                            bool zr6 = jitEJ[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                            bool mbj = jitEJ[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                            bool lps = jitEJ[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                            Ejlist piloto = new Ejlist
                            {
                                Vin = subs[0],
                                Type = "EJ",
                                Sequence = sbs22,
                                FullVin = subs.Last(),
                                Color = color,
                                Creation = jitEJ[i].TspTcreation,
                                FrtLwrFascia = subs[subs.Count() - 14],
                                RrLwrFasca = subs[subs.Count() - 6]

                            };
                            Ejlist.Add(piloto);
                        }
                    }

                    List<Ejlist> uniqueDataList = Ejlist
                        .GroupBy(x => x.Vin)
                        .Select(g => g.First())
                        .ToList();

                    return uniqueDataList;
                }
                else
                {
                    Console.WriteLine("No hacer nadota");
                }
            }
            else
            {
                //Update EJ Data since lastDate
                List<JTransferspacket> jitEJ = await _modelContext.JTransferspackets
                    .Where(x => x.TspData.Contains("SP")
                    && x.TspData.Contains("EJ")
                    && x.TspData.Contains("X8W")
                    && x.TspData.Contains("G ")
                    && x.TspTcreation >= fInicio)
                    .ToListAsync();
                List<Ejlist> Ejlist = new();
                {
                    for (int i = 0; i < jitEJ.Count(); i++)
                    {
                        // Data Transform
                        System.String[] delimiters = { "  ", " ", ".", "SPT40313", "EJ", "2024", "0000" };
                        string vins = jitEJ[i].TspData.ToString();
                        string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        sbs22 = long.Parse(subs[2]);

                        bool was = jitEJ[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                        bool sse = jitEJ[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                        bool gw7 = jitEJ[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                        bool kxj = jitEJ[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                        bool zr6 = jitEJ[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                        bool mbj = jitEJ[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                        bool lps = jitEJ[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                        //Data Load to my Objet
                        Ejlist piloto = new Ejlist
                        {
                            Vin = subs[0],
                            Type = "EJ",
                            Sequence = sbs22,
                            FullVin = subs.Last(),
                            Color = color,
                            Creation = jitEJ[i].TspTcreation
                        };
                        Ejlist.Add(piloto);

                    }
                }


                List<Ejlist> uniqueDataList = Ejlist
                    .GroupBy(x => x.Vin)
                    .Select(g => g.First())
                    .ToList();

                return uniqueDataList;
            }

            List<Ejlist> noUpdateData = null;

            return noUpdateData;
        }

        public async Task LoadData()
        {
            List<PilotosList> dataList = await getData();
            List<Ejlist> ejDataList = await getEJData();
            List<Km74> KM74List = await getKM74Data();

            int batchSize = 10;

            if (dataList != null)
            {
                var keysKm = dataList.Select(obj => obj.Suquence).ToList();
                var regCurrents = _context.Ejlists.Where(reg => keysKm.Contains(reg.Sequence)).ToList();
                var regInsertkm = dataList.Where(obj => !regCurrents.Any(reg => reg.Sequence == obj.Suquence)).ToList();
                //Batch Processing 
                for (int i = 0; i < regInsertkm.Count; i += batchSize)
                {
                    List<PilotosList> batch = regInsertkm.Skip(i).Take(batchSize).ToList();

                    foreach (var item in batch)
                    {
                        _context.Add(item);
                    }

                    await _context.SaveChangesAsync();
                }
            }

            if (KM74List != null)
            {
                var keysKm = KM74List.Select(obj => obj.Sequence).ToList();
                var regCurrents = _context.Km74s.Where(reg => keysKm.Contains(reg.Sequence)).ToList();
                var regInsertkm = KM74List.Where(obj => !regCurrents.Any(reg => reg.Sequence == obj.Sequence)).ToList();
                //Batch Processing 
                for (int i = 0; i < regInsertkm.Count; i += batchSize)
                {
                    List<Km74> batch = regInsertkm.Skip(i).Take(batchSize).ToList();

                    foreach (var item in batch)
                    {
                        _context.Add(item);
                    }

                    await _context.SaveChangesAsync();
                }
            }

            if (ejDataList != null)
            {
                var keys = ejDataList.Select(obj => obj.Sequence).ToList();
                var regCurrents = _context.Ejlists.Where(reg => keys.Contains(reg.Sequence)).ToList();
                var regInsert = ejDataList.Where(obj => !regCurrents.Any(reg => reg.Sequence == obj.Sequence)).ToList();

                if (regInsert != null)
                {
                    //Batch Processing 
                    for (int i = 0; i < regInsert.Count; i += batchSize)
                    {
                        List<Ejlist> batch = regInsert.Skip(i).Take(batchSize).ToList();

                        foreach (var item in batch)
                        {
                            _context.Add(item);
                        }

                        await _context.SaveChangesAsync();
                    }
                }

            }
        }

    }
}
