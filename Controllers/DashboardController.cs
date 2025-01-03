using Labels_KM49.Data;
using Microsoft.AspNetCore.Mvc;
using Labels_KM49.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Labels_KM49.Models;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Runtime.InteropServices;
using OfficeOpenXml;
using System.IO;
using Humanizer;
using System.Globalization;

namespace Labels_KM49.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ModelContext _context;
        private readonly PilotosContext _contextPilotos;

        /// <summary>
        /// Dependency Injection 
        /// Get Context's and other iniatiling vars
        /// </summary>
        /// <param name="context"></param>
        /// <param name="contextPilotos"></param>
        public DashboardController(ModelContext context, PilotosContext contextPilotos)
        {
            _context = context;
            _contextPilotos = contextPilotos;
        }
        DateTime dateTime = DateTime.Now;
        DateTime fInicio = new DateTime(2023, 6, 28);
        long sbs2, sbs22, lastG2, sbs24, buffej, getEJSec, lastG2Vin;
        double buffTime;
        string color;
        string getLastVin;
        string formattedTime;
        /// <summary>
        /// Obtiene los datos de SQL Server y actualiza los datos de Oracle cada 10 minutos o cuando el usuario lo decide.
        /// </summary>
        /// <param name="isUpdate"></param>
        /// <returns></returns>
        public async Task<IActionResult> Index(bool isUpdate, string sheetName)
        {
            List<PilotosList> pilotosLists = new List<PilotosList>();
            List<Ejlist> EjList = new List<Ejlist>();
            //var update = await _contextPilotos.DashData.AnyAsync();
            //var countDash = await _contextPilotos.DashData.CountAsync();
            //string tableName = "[Pilotos].[dbo].[DashData]";

            if (sheetName != null)
            {
                bool kmEFA = sheetName.Contains("kmEsinFA");
                bool kmFAG = sheetName.Contains("kmFAsinG");
                bool kmAll = sheetName.Contains("kmAll");
                bool EJFAG = sheetName.Contains("EJEsinG");

                // Configurar el contexto de la licencia de EPPlus
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Guardar el archivo en un MemoryStream
                var memoryStream = new MemoryStream();
                // Obtener los datos desde tu contexto
                if (kmEFA)
                {
                    var kmEsinFa = _contextPilotos.EsinFas.ToList();
                    // Abrir el archivo Excel y trabajar con EPPlus
                    try
                    {
                        using (var pck = new ExcelPackage(memoryStream))
                        {
                            var sheet = pck.Workbook.Worksheets.Add("km49 E sin FA");

                            // Agregar encabezados
                            sheet.Cells[1, 1].Value = "Creation";
                            sheet.Cells[1, 2].Value = "Sequence";
                            sheet.Cells[1, 3].Value = "Vin";
                            sheet.Cells[1, 4].Value = "Type";
                            sheet.Cells[1, 5].Value = "Color";
                            sheet.Cells[1, 6].Value = "Full Vin";

                            // Agregar datos de la lista
                            for (int i = 0; i < kmEsinFa.Count; i++)
                            {
                                sheet.Cells[i + 2, 1].Value = kmEsinFa[i].Creation;
                                sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                sheet.Cells[i + 2, 2].Value = kmEsinFa[i].Seuquence;
                                sheet.Cells[i + 2, 3].Value = kmEsinFa[i].Vin;
                                sheet.Cells[i + 2, 4].Value = kmEsinFa[i].Type;
                                sheet.Cells[i + 2, 5].Value = kmEsinFa[i].Color;
                                sheet.Cells[i + 2, 6].Value = kmEsinFa[i].FullVin;
                            }

                            // Autoajustar columnas para el contenido
                            sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                            pck.Save();
                        }
                        memoryStream.Position = 0;
                        string fileName = $"KM49 E sin FA {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}.xlsx";

                        // Devolver el archivo Excel como FileResult
                        return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                        return null; // Manejar el error apropiadamente según tus necesidades
                    }
                }

                if (kmFAG)
                {
                    var kmFasinFA = _contextPilotos.FasinGs.ToList();
                    // Abrir el archivo Excel y trabajar con EPPlus
                    try
                    {
                        using (var pck = new ExcelPackage(memoryStream))
                        {
                            var sheet = pck.Workbook.Worksheets.Add("KM49 FA sin G");

                            // Agregar encabezados
                            sheet.Cells[1, 1].Value = "Creation";
                            sheet.Cells[1, 2].Value = "Sequence";
                            sheet.Cells[1, 3].Value = "Vin";
                            sheet.Cells[1, 4].Value = "Type";
                            sheet.Cells[1, 5].Value = "Color";
                            sheet.Cells[1, 6].Value = "Full Vin";

                            // Agregar datos de la lista
                            for (int i = 0; i < kmFasinFA.Count; i++)
                            {
                                sheet.Cells[i + 2, 1].Value = kmFasinFA[i].Creation;
                                sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                sheet.Cells[i + 2, 2].Value = kmFasinFA[i].Sequence;
                                sheet.Cells[i + 2, 3].Value = kmFasinFA[i].Vin;
                                sheet.Cells[i + 2, 4].Value = kmFasinFA[i].Type;
                                sheet.Cells[i + 2, 5].Value = kmFasinFA[i].Color;
                                sheet.Cells[i + 2, 6].Value = kmFasinFA[i].FullVin;
                            }

                            // Autoajustar columnas para el contenido
                            sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                            pck.Save();
                        }
                        memoryStream.Position = 0;
                        string fileName = $"KM49 FA sin G {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}.xlsx";

                        // Devolver el archivo Excel como FileResult
                        return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                        return null; // Manejar el error apropiadamente según tus necesidades
                    }
                }

                if (kmAll)
                {
                    List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();
                    var EJEsinFA = _contextPilotos.Ejlists.ToList();
                    var ordenar = pilotosList.OrderByDescending(x => x.Creation).Take(600).ToList();
                    // Abrir el archivo Excel y trabajar con EPPlus
                    try
                    {
                        using (var pck = new ExcelPackage(memoryStream))
                        {
                            var sheet = pck.Workbook.Worksheets.Add("All KM49");

                            // Agregar encabezados
                            sheet.Cells[1, 1].Value = "Creation";
                            sheet.Cells[1, 2].Value = "Sequence";
                            sheet.Cells[1, 3].Value = "Vin";
                            sheet.Cells[1, 4].Value = "Type";
                            sheet.Cells[1, 5].Value = "Color";
                            sheet.Cells[1, 6].Value = "Full Vin";

                            // Agregar datos de la lista
                            for (int i = 0; i < EJEsinFA.Count; i++)
                            {
                                sheet.Cells[i + 2, 1].Value = EJEsinFA[i].Creation;
                                sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                sheet.Cells[i + 2, 2].Value = EJEsinFA[i].Sequence;
                                sheet.Cells[i + 2, 3].Value = EJEsinFA[i].Vin;
                                sheet.Cells[i + 2, 4].Value = EJEsinFA[i].Type;
                                sheet.Cells[i + 2, 5].Value = EJEsinFA[i].Color;
                                sheet.Cells[i + 2, 6].Value = EJEsinFA[i].FullVin;
                            }

                            // Autoajustar columnas para el contenido
                            sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                            pck.Save();
                        }
                        memoryStream.Position = 0;

                        string fileName = $"Pilotos KM49 {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}.xlsx";
                        // Devolver el archivo Excel como FileResult
                        return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                        return null; // Manejar el error apropiadamente según tus necesidades
                    }
                }

                if (EJFAG)
                {
                    var EJFAsinG = _contextPilotos.EjfasinGs.ToList();
                    // Abrir el archivo Excel y trabajar con EPPlus
                    try
                    {
                        using (var pck = new ExcelPackage(memoryStream))
                        {
                            var sheet = pck.Workbook.Worksheets.Add("EJ FA sin G");

                            // Agregar encabezados
                            sheet.Cells[1, 1].Value = "Creation";
                            sheet.Cells[1, 2].Value = "Sequence";
                            sheet.Cells[1, 3].Value = "Vin";
                            sheet.Cells[1, 4].Value = "Type";
                            sheet.Cells[1, 5].Value = "Color";
                            sheet.Cells[1, 6].Value = "Full Vin";

                            // Agregar datos de la lista
                            for (int i = 0; i < EJFAsinG.Count; i++)
                            {
                                sheet.Cells[i + 2, 1].Value = EJFAsinG[i].Creation;
                                sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                                sheet.Cells[i + 2, 2].Value = EJFAsinG[i].Sequence;
                                sheet.Cells[i + 2, 3].Value = EJFAsinG[i].Vin;
                                sheet.Cells[i + 2, 4].Value = EJFAsinG[i].Type;
                                sheet.Cells[i + 2, 5].Value = EJFAsinG[i].Color;
                                sheet.Cells[i + 2, 6].Value = EJFAsinG[i].FullVin;
                            }

                            // Autoajustar columnas para el contenido
                            sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                            pck.Save();
                        }
                        memoryStream.Position = 0;

                        string fileName = $"EJ FA sin G {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}.xlsx";

                        // Devolver el archivo Excel como FileResult
                        return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                        return null; // Manejar el error apropiadamente según tus necesidades
                    }
                }
            }
            //if (countDash >= 500)
            //{
            //    await _contextPilotos.Database.ExecuteSqlRawAsync($"TRUNCATE TABLE{tableName}");
            //    return RedirectToAction(nameof(Index));
            //}

            //if (update == false)
            //{
            //    isUpdate = true;
            //}

            if (isUpdate)
            {
                await getData();
                var sw = new Stopwatch();
                sw.Start();
                List<PilotosList> getKM = await _contextPilotos.PilotosLists.OrderByDescending(x => x.Id).ToListAsync();
                List<Ejlist> getEJ = await _contextPilotos.Ejlists.OrderByDescending(x => x.Id).ToListAsync();

                var lastGetKM = getKM.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                var lastGetEJ = getEJ.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                List<Km49E> getKMe = await _contextPilotos.Km49Es.ToListAsync();
                List<Km49Fa> getKMFA = await _contextPilotos.Km49Fas.ToListAsync();
                List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();
                List<PilotoViewModel> KMe = new List<PilotoViewModel>();
                List<PilotoViewModel> KMFa = new List<PilotoViewModel>();
                var getG2 = await _context.JTransferspackets.Where(g2 => g2.TspData.Contains("SP")
                && g2.TspData.Contains("G2")
                && g2.TspStatus.Contains("Done")
                && g2.TspTcreation >= dateTime.AddDays(-1))
                    .OrderByDescending(g2 => g2.TspTcreation)
                    .FirstOrDefaultAsync();

                var lastSecG2 = "";
                var lasSecG2Vin = "";

                if (getG2 != null)
                {
                    lastSecG2 = getG2.TspData.Substring(33, 7);
                    lastG2 = long.Parse(lastSecG2);

                    lasSecG2Vin = getG2.TspData.Substring(10, 8);
                }

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
                        Nempleado = item.Nempleado
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
                        Color = item.Color
                    };

                    pilotosList.Add(add);
                }

                var getEsinFA = _contextPilotos.EsinFas.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                var getFAsinG = _contextPilotos.FasinGs.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                ViewBag.km49EsinFA = getEsinFA.OrderByDescending(t => t.Id).ToList();
                ViewBag.km49FAsinG = getFAsinG.OrderByDescending(t => t.Id).ToList();

                ViewBag.KMTotal = lastGetKM.Count();
                ViewBag.KME = getEsinFA.Count();
                ViewBag.KMFA = getFAsinG.Count();

                var getEJEsinFA = _contextPilotos.EjesinFas.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                var getEJFAsinG = _contextPilotos.EjfasinGs.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                ViewBag.EJTotal = lastGetEJ.Count();
                ViewBag.EJE = getEJEsinFA.Count();

                ViewBag.EJEsinFa = getEJEsinFA.Count();
                ViewBag.EJSinFAList = getEJEsinFA;

                ViewBag.EJFAsinG = getEJFAsinG.Count();
                ViewBag.EJFAsinGlIST = getEJFAsinG;


                // Ordenar pilotosList por Creation de forma descendente
                var ordenar = pilotosList.OrderByDescending(x => x.Creation).Take(50).ToList();

                var getLastNOSendKM = await _contextPilotos.PilotosLists.Where(x => x.Enviado == null).OrderByDescending(x => x.Id).ToListAsync();

                if (getLastNOSendKM.Count() != 0)
                {
                    var lastKMBuff = getLastNOSendKM.OrderByDescending(x => x.Creation).Last();
                    string getSecEJB = lastKMBuff.Suquence.ToString();
                    getLastVin = lastKMBuff.Vin.ToString();

                    getEJSec = long.Parse(getSecEJB);

                    buffej = ((getEJSec - lastG2) / 10) + 38;

                    buffTime = (buffej / 42.0f);
                }
                else
                {
                    ViewBag.Uinstaladas = 0;
                }

                ViewBag.bufferPilotos = buffej;
                ViewBag.buffG2 = lastG2;
                ViewBag.buffG2VIN = lasSecG2Vin;
                ViewBag.buffGdonsend = getEJSec;
                ViewBag.lastVinGnoSend = getLastVin;
                ViewBag.BuffTime = buffTime.Hours();

                sw.Stop();

                Console.Write($"Tiempo de ejecucion: {sw.Elapsed} ");

                return View(ordenar);

                //////////////////////////

            }
            else
            {
                var sw = new Stopwatch();
                sw.Start();
                List<PilotosList> getKM = await _contextPilotos.PilotosLists.OrderByDescending(x => x.Id).ToListAsync();
                List<Ejlist> getEJ = await _contextPilotos.Ejlists.OrderByDescending(x => x.Id).ToListAsync();

                var lastGetKM = getKM.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                var lastGetEJ = getEJ.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                //List<Km49E> getKMe = await _contextPilotos.Km49Es.ToListAsync();
                //List<Km49Fa> getKMFA = await _contextPilotos.Km49Fas.ToListAsync();
                List<PilotoViewModel> pilotosList = new List<PilotoViewModel>();
                //List<PilotoViewModel> KMe = new List<PilotoViewModel>();
                //List<PilotoViewModel> KMFa = new List<PilotoViewModel>();
                var getG2 = await _context.JTransferspackets.Where(g2 => g2.TspData.Contains("SP") 
                && g2.TspData.Contains("G2")
                && g2.TspStatus.Contains("Done")
                && g2.TspTcreation >= dateTime.AddDays(-5))
                    .OrderByDescending(g2 => g2.TspTcreation)
                    .FirstOrDefaultAsync();

                var lastSecG2 = "";
                var lasSecG2Vin = "";

                if (getG2 != null)
                {
                    lastSecG2 = getG2.TspData.Substring(33, 7);
                    lastG2 = long.Parse(lastSecG2);

                    lasSecG2Vin = getG2.TspData.Substring(10,8);
                }

                // Convertir elementos de getKM en PilotoViewModel y agregar a pilotosList
                foreach (var item in lastGetKM)
                {
                    PilotoViewModel add = new PilotoViewModel
                    {
                        Creation = (DateTime)item.Creation,
                        Vin = item.Vin,
                        Sequence = (long)item.Suquence,
                        Color = item.Color,
                        Enviado = item.Enviado,
                        Nempleado = item.Nempleado
                    };

                    pilotosList.Add(add);
                }

                // Convertir elementos de getEJ en PilotoViewModel y agregar a pilotosList
                //foreach (var item in lastGetEJ)
                //{
                //    PilotoViewModel add = new PilotoViewModel
                //    {
                //        Creation = (DateTime)item.Creation,
                //        Vin = item.Vin,
                //        type = item.Type,
                //        Sequence = (long)item.Sequence,
                //        FullVin = item.FullVin,
                //        Color = item.Color
                //    };

                //    pilotosList.Add(add);
                //}

                //var getEsinFA = _contextPilotos.EsinFas.GroupBy(x => x.Id).Select(g => g.First()).ToList();
                //var getFAsinG = _contextPilotos.FasinGs.GroupBy(x => x.Id).Select(g => g.First()).ToList();

                //ViewBag.km49EsinFA = getEsinFA.OrderByDescending(t => t.Creation).ToList();
                //ViewBag.km49FAsinG = getFAsinG.OrderByDescending(t => t.Creation).ToList();

                ViewBag.KMTotal = lastGetKM.Count();
                //ViewBag.KME = getEsinFA.Count();
                //ViewBag.KMFA = getFAsinG.Count();

                //var getEJEsinFA = _contextPilotos.EjesinFas.GroupBy(x => x.Vin).Select(g => g.First()).ToList();
                //var getEJFAsinG = _contextPilotos.EjfasinGs.GroupBy(x => x.Vin).Select(g => g.First()).ToList();

                //ViewBag.EJTotal = lastGetEJ.Count();
                //ViewBag.EJE = getEJEsinFA.Count();

                //ViewBag.EJEsinFa = getEJEsinFA.Count();
                //ViewBag.EJSinFAList = getEJEsinFA;

                //ViewBag.EJFAsinG = getEJFAsinG.Count();
                //ViewBag.EJFAsinGlIST = getEJFAsinG;


                // Ordenar pilotosList por Creation de forma descendente
                var ordenar = pilotosList.OrderByDescending(x => x.Creation).Take(50).ToList();

                var getLastNOSendKM = await _contextPilotos.PilotosLists.Where(x => x.Enviado == null).OrderByDescending(x => x.Id).ToListAsync();

                if (getLastNOSendKM.Count() != 0)
                {
                    var lastKMBuff = getLastNOSendKM.OrderByDescending(x => x.Id).Last();
                    string getSecEJB = lastKMBuff.Suquence.ToString();
                    getLastVin = lastKMBuff.Vin.ToString();

                    getEJSec = long.Parse(getSecEJB);

                    buffej = ((getEJSec - lastG2) / 10) + 38;

                    buffTime = (buffej / 42.0f);
                    formattedTime = TimeSpan.FromHours(buffTime).ToString(@"hh\:mm");
                }
                else
                {
                    ViewBag.Uinstaladas = 0;
                }

                ViewBag.bufferPilotos = buffej;
                ViewBag.buffG2 = lastG2;
                ViewBag.buffG2VIN = lasSecG2Vin;
                ViewBag.buffGdonsend = getEJSec;
                ViewBag.lastVinGnoSend = getLastVin;
                ViewBag.BuffTime = formattedTime;

                sw.Stop();

                Console.Write($"Tiempo de ejecucion: {sw.Elapsed} ");

                return View(ordenar);

            }
        }

        public async Task<List<PilotosList>> getData()
        {
            //getLast Piloto Save.
            var lastRegistroSQLServer = await _contextPilotos.PilotosLists.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            
            var lasRegstroOracle = await _context.JTransferspackets.Where(x => x.TspData.Contains("KMX")
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

                    List<Models.JTransferspacket> jitKM49 = await _context.JTransferspackets
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

                            // Crear un objeto PilotosList con los datos correspondientes
                            PilotosList piloto = new PilotosList
                            {
                                Vin = subs[0],
                                Type = "KM",
                                Suquence = sbs2,
                                FullVin = subs.Last(),
                                Color = color,
                                Creation = jitKM49[i].TspTcreation
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
                //Update apartir de la ultima fecha registrada.
                Console.WriteLine("Update data ");
                List<Models.JTransferspacket> jitKM49 = await _context.JTransferspackets
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

                        // Crear un objeto PilotosList con los datos correspondientes
                        PilotosList piloto = new PilotosList
                        {
                            Vin = subs[0],
                            Type = "KM",
                            Suquence = sbs2,
                            FullVin = subs.Last(),
                            Color = color,
                            Creation = jitKM49[i].TspTcreation
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

            List<PilotosList> noUpdateData = null;

            return noUpdateData;

        }

        public async Task<List<Ejlist>> getEJData()
        {
            var lasRegistroEJList = await _contextPilotos.Ejlists.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            var lasEJOracle = await _context.JTransferspackets.Where(x => x.TspData.Contains("SP")
                && x.TspData.Contains("EJ")
                && x.TspData.Contains("X8W")
                && x.TspData.Contains("G ")
                && x.TspTcreation >= dateTime.AddDays(-10))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            if (lasRegistroEJList != null && lasEJOracle != null)
            {
                if (lasRegistroEJList.Creation < lasEJOracle.TspTcreation)
                {
                    //Update EJ Data since lastDate
                    List<JTransferspacket> jitEJ = await _context.JTransferspackets
                        .Where(x => x.TspData.Contains("SP")
                        && x.TspData.Contains("EJ")
                        && x.TspData.Contains("X8W")
                        && x.TspData.Contains("G ")
                        && x.TspTcreation > lasRegistroEJList.Creation)
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
                else
                {
                    Console.WriteLine("No hacer nadota");
                }
            }
            else
            {
                //Update EJ Data since lastDate
                List<JTransferspacket> jitEJ = await _context.JTransferspackets
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

        public async Task<List<DashDatum>> getDashData()
        {
            List<DashDatum> data = new List<DashDatum>();
            var isEmpty = await _contextPilotos.DashData.OrderByDescending(x => x.LastUpdate).LastOrDefaultAsync();
            var lastKM = await _context.JTransferspackets.Where(x => x.TspData.Contains("KMX")
                && x.TspData.Contains("X8V")
                && x.TspData.Contains("G ")
                && x.TspData.Contains("3C4RJNA")
                && x.TspTcreation >= dateTime.AddDays(-10))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            var lastEJ = await _context.JTransferspackets.Where(x => x.TspData.Contains("SP")
                && x.TspData.Contains("EJ")
                && x.TspData.Contains("G ")
                && x.TspTcreation >= dateTime.AddDays(-10))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            if (isEmpty != null)
            {
                //Obtener Datos
                //KM49 E
                int km49E = await _contextPilotos.Km49Es.CountAsync();
                //KM49 FA
                int km49FA = await _contextPilotos.Km49Fas.CountAsync();
                //EJ E
                int ejE = await _context.JTransferspackets
                    .Where(x => x.TspData.Contains("EJ")
                    && x.TspData.Contains("X8W")
                    && x.TspData.Contains("E ")
                    && x.TspTcreation > lastEJ.TspTcreation
                    ).CountAsync();
                //EJ G2
                int ejG2 = await _context.JTransferspackets
                    .Where(x => x.TspData.Contains("EJ")
                    && x.TspData.Contains("X8W")
                    && x.TspData.Contains("G2")
                    && x.TspTcreation > lastEJ.TspTcreation
                    ).CountAsync();
                //Cargarlos a la lista.
                DashDatum dashData = new DashDatum
                {
                    Kme = km49E,
                    Kmfa = km49FA,
                    Eje = ejE,
                    Ejfa = ejG2,
                    LastUpdate = DateTime.Now
                };
                data.Add(dashData);
            }
            else
            {
                //Obtener Datos
                //KM49 E
                int km49E = await _contextPilotos.Km49Es.CountAsync();
                //KM49 FA
                int km49FA = await _contextPilotos.Km49Fas.CountAsync();
                //EJ E
                int ejE = await _context.JTransferspackets
                    .Where(x => x.TspData.Contains("EJ")
                    && x.TspData.Contains("X8W")
                    && x.TspData.Contains("E ")
                    && x.TspTcreation >= fInicio
                    ).CountAsync();
                //EJ G2
                int ejG2 = await _context.JTransferspackets
                    .Where(x => x.TspData.Contains("EJ")
                    && x.TspData.Contains("X8W")
                    && x.TspData.Contains("G2")
                    && x.TspTcreation >= fInicio
                    ).CountAsync();
                //Cargarlos a la lista.
                DashDatum dashData = new DashDatum
                {
                    Kme = km49E,
                    Kmfa = km49FA,
                    Eje = ejE,
                    Ejfa = ejG2,
                    LastUpdate = DateTime.Now
                };
                data.Add(dashData);
            }
            return data;
        }

        public async Task<List<Km49Fa>> getKMFa()
        {
            var asqlFA = _contextPilotos.Km49Fas.Count();
            var lasFA = await _contextPilotos.Km49Fas.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            List<Km49Fa> data = new List<Km49Fa>();

            if (asqlFA != 0)
            {
                var values = _context.JTransferspackets
                .Where(x => x.TspData.Contains("KMX")
                    && x.TspData.Contains("X8V")
                    && x.TspData.Contains("FA")
                    && x.TspTcreation >= lasFA.Creation
                    ).ToList();

                List<Km49Fa> listkmFA = new();
                {
                    for (int i = 0; i < values.Count; i++)
                    {
                        int creationYear = values[i].TspTcreation.Year;
                        bool isYear2023 = creationYear == 2023;
                        int getYear = isYear2023 ? 2023 : 2024;
                        string yearIndex = getYear.ToString();

                        // Data Transform
                        System.String[] delimiters = { "  ", " ", ".", "KMX", "SPT40313", yearIndex, "0000" };
                        string vins = values[i].TspData.ToString();
                        string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        sbs2 = long.Parse(subs[2]);

                        bool was = values[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                        bool sse = values[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                        bool gw7 = values[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                        bool kxj = values[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                        bool zr6 = values[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                        bool mbj = values[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                        bool lps = values[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                        // Crear un objeto PilotosList con los datos correspondientes
                        Km49Fa piloto = new Km49Fa
                        {
                            Vin = subs[0],
                            Type = "KM",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = color,
                            Creation = values[i].TspTcreation
                        };

                        // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                        if (!piloto.Vin.Contains("KM"))
                        {
                            listkmFA.Add(piloto);
                        }
                    }
                }

                List<Km49Fa> uniqueDataList = listkmFA
                        .GroupBy(x => x.Vin)
                        .Select(g => g.First())
                        .ToList();
                return uniqueDataList;

            }
            else
            {
                var values = _context.JTransferspackets
                .Where(x => x.TspData.Contains("KMX")
                    && x.TspData.Contains("X8V")
                    && x.TspData.Contains("FA")
                    && x.TspTcreation >= fInicio
                    ).ToList();

                List<Km49Fa> listkmFA = new();
                {
                    for (int i = 0; i < values.Count; i++)
                    {
                        int creationYear = values[i].TspTcreation.Year;
                        bool isYear2023 = creationYear == 2023;
                        int getYear = isYear2023 ? 2023 : 2024;
                        string yearIndex = getYear.ToString();

                        // Data Transform
                        System.String[] delimiters = { "  ", " ", ".", "KMX", "SPT40313", yearIndex, "0000" };
                        string vins = values[i].TspData.ToString();
                        string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        sbs2 = long.Parse(subs[2]);

                        bool was = values[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                        bool sse = values[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                        bool gw7 = values[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                        bool kxj = values[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                        bool zr6 = values[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                        bool mbj = values[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                        bool lps = values[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";
                        // Crear un objeto PilotosList con los datos correspondientes
                        Km49Fa piloto = new Km49Fa
                        {
                            Vin = subs[0],
                            Type = "KM",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = color,
                            Creation = values[i].TspTcreation
                        };

                        // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                        if (!piloto.Vin.Contains("KM"))
                        {
                            listkmFA.Add(piloto);
                        }
                    }
                }

                List<Km49Fa> uniqueDataList = listkmFA
                        .GroupBy(x => x.Vin)
                        .Select(g => g.First())
                        .ToList();
                return uniqueDataList;
            }

        }

        public async Task<List<Km49E>> getKMFe()
        {
            var asqlFe = _contextPilotos.Km49Es.Count();
            var lasFe = await _contextPilotos.Km49Es.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            var lasRegstroOracle = await _context.JTransferspackets.Where(x => x.TspData.Contains("KMX")
                && x.TspData.Contains("X8V")
                && x.TspData.Contains("E")
                && x.TspTcreation >= dateTime.AddDays(-10))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();
            List<Km49E> data = new List<Km49E>();

            if (lasFe != null && lasRegstroOracle != null)
            {
                if (lasFe.Creation < lasRegstroOracle.TspTcreation)
                {
                    var values = _context.JTransferspackets
                    .Where(x => x.TspData.Contains("KMX")
                    && x.TspData.Contains("X8V")
                    && x.TspData.Contains("E ")
                    && x.TspTcreation >= lasFe.Creation
                    ).ToList();

                    List<Km49E> listkmFE = new();
                    {
                        for (int i = 0; i < values.Count; i++)
                        {
                            int creationYear = values[i].TspTcreation.Year;
                            bool isYear2023 = creationYear == 2023;
                            int getYear = isYear2023 ? 2023 : 2024;
                            string yearIndex = getYear.ToString();

                            // Data Transform
                            System.String[] delimiters = { "  ", " ", ".", "KMX", "SPT40313", yearIndex, "0000" };
                            string vins = values[i].TspData.ToString();
                            string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                            sbs2 = long.Parse(subs[2]);

                            //Data Load to my Objet
                            // Verificar si el primer elemento contiene "ST"
                            bool isST = subs[0].Contains("ST");

                            // Determinar el índice de Color según la condición
                            int colorIndex = isST ? 48 : 50;

                            bool was = values[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                            bool sse = values[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                            bool gw7 = values[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                            bool kxj = values[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                            bool zr6 = values[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                            bool mbj = values[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                            bool lps = values[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";

                            // Crear un objeto PilotosList con los datos correspondientes
                            Km49E piloto = new Km49E
                            {
                                Vin = subs[0],
                                Type = "KM",
                                Seuquence = sbs2,
                                FullVin = subs.Last(),
                                Color = color,
                                Creation = values[i].TspTcreation
                            };

                            // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                            if (!piloto.Vin.Contains("KM"))
                            {
                                listkmFE.Add(piloto);
                            }
                        }
                    }

                    List<Km49E> uniqueDataList = listkmFE
                            .GroupBy(x => x.Vin)
                            .Select(g => g.First())
                            .ToList();
                    return uniqueDataList;
                }
            }
            else
            {
                var values = _context.JTransferspackets
                .Where(x => x.TspData.Contains("KMX")
                    && x.TspData.Contains("X8V")
                    && x.TspData.Contains("E ")
                    && x.TspTcreation >= fInicio
                    ).ToList();

                List<Km49E> listkmFE = new();
                {
                    for (int i = 0; i < values.Count; i++)
                    {
                        int creationYear = values[i].TspTcreation.Year;
                        bool isYear2023 = creationYear == 2023;
                        int getYear = isYear2023 ? 2023 : 2024;
                        string yearIndex = getYear.ToString();

                        // Data Transform
                        System.String[] delimiters = { "  ", " ", ".", "KMX", "SPT40313", yearIndex, "0000" };
                        string vins = values[i].TspData.ToString();
                        string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                        sbs2 = long.Parse(subs[2]);

                        //Data Load to my Objet
                        // Verificar si el primer elemento contiene "ST"
                        bool isST = subs[0].Contains("ST");

                        // Determinar el índice de Color según la condición
                        int colorIndex = isST ? 48 : 50;

                        bool was = values[i].TspData.Contains("WAS"); if (was == true) color = "WAS";
                        bool sse = values[i].TspData.Contains("SSE"); if (sse == true) color = "SSE";
                        bool gw7 = values[i].TspData.Contains("GW7"); if (gw7 == true) color = "GW7";
                        bool kxj = values[i].TspData.Contains("KXJ"); if (kxj == true) color = "KXJ";
                        bool zr6 = values[i].TspData.Contains("ZR6"); if (zr6 == true) color = "ZR6";
                        bool mbj = values[i].TspData.Contains("MBJ"); if (mbj == true) color = "MBJ";
                        bool lps = values[i].TspData.Contains("LPS"); if (lps == true) color = "LPS";
                        // Crear un objeto PilotosList con los datos correspondientes
                        Km49E piloto = new Km49E
                        {
                            Vin = subs[0],
                            Type = "KM",
                            Seuquence = sbs2,
                            FullVin = subs.Last(),
                            Color = color,
                            Creation = values[i].TspTcreation
                        };

                        // Añadir el objeto a la lista solo si no contiene "KM" en Vin
                        if (!piloto.Vin.Contains("KM"))
                        {
                            listkmFE.Add(piloto);
                        }
                    }
                }

                List<Km49E> uniqueDataList = listkmFE
                        .GroupBy(x => x.Vin)
                        .Select(g => g.First())
                        .ToList();
                return uniqueDataList;
            }

            List<Km49E> noUpdateData = null;

            return noUpdateData;
        }

        public async Task<List<EjE>> getEJFe()
        {
            var lasRegistroEJList = await _contextPilotos.EjEs.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            var lasEJOracle = await _context.JTransferspackets.Where(x => x.TspData.Contains("SP")
                && x.TspData.Contains("EJ")
                && x.TspData.Contains("X8W")
                && x.TspData.Contains("E ")
                && x.TspTcreation >= dateTime.AddDays(-50))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            if (lasRegistroEJList != null && lasEJOracle != null)
            {
                if (lasRegistroEJList.Creation < lasEJOracle.TspTcreation)
                {
                    //Update EJ Data since lastDate
                    List<JTransferspacket> jitEJ = await _context.JTransferspackets
                        .Where(x => x.TspData.Contains("SP")
                        && x.TspData.Contains("EJ")
                        && x.TspData.Contains("X8W")
                        && x.TspData.Contains("E ")
                        && x.TspTcreation > lasRegistroEJList.Creation)
                        .ToListAsync();
                    List<EjE> Ejlist = new();
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

                            EjE piloto = new EjE
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

                    List<EjE> uniqueDataList = Ejlist
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
                List<JTransferspacket> jitEJ = await _context.JTransferspackets
                    .Where(x => x.TspData.Contains("SP")
                    && x.TspData.Contains("EJ")
                    && x.TspData.Contains("X8W")
                    && x.TspData.Contains("E ")
                    && x.TspTcreation >= fInicio)
                    .ToListAsync();
                List<EjE> Ejlist = new();
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

                        EjE piloto = new EjE
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


                List<EjE> uniqueDataList = Ejlist
                    .GroupBy(x => x.Vin)
                    .Select(g => g.First())
                    .ToList();

                return uniqueDataList;
            }

            List<EjE> noUpdateData = null;

            return noUpdateData;
        }

        public async Task<List<EjFa>> getEJFa()
        {
            var lasRegistroEJList = await _contextPilotos.EjEs.OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            var lasEJOracle = await _context.JTransferspackets.Where(x => x.TspData.Contains("SP")
                && x.TspData.Contains("EJ")
                && x.TspData.Contains("X8W")
                && x.TspData.Contains("FA")
                && x.TspTcreation >= dateTime.AddDays(-25))
                    .OrderByDescending(x => x.TspTcreation)
                    .FirstOrDefaultAsync();

            if (lasRegistroEJList != null && lasEJOracle != null)
            {
                if (lasRegistroEJList.Creation < lasEJOracle.TspTcreation)
                {
                    //Update EJ Data since lastDate
                    List<JTransferspacket> jitEJ = await _context.JTransferspackets
                        .Where(x => x.TspData.Contains("SP")
                        && x.TspData.Contains("EJ")
                        && x.TspData.Contains("X8W")
                        && x.TspData.Contains("FA")
                        && x.TspTcreation > lasRegistroEJList.Creation)
                        .ToListAsync();
                    List<EjFa> Ejlist = new();
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

                            EjFa piloto = new EjFa
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

                    List<EjFa> uniqueDataList = Ejlist
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
                List<JTransferspacket> jitEJ = await _context.JTransferspackets
                    .Where(x => x.TspData.Contains("SP")
                    && x.TspData.Contains("EJ")
                    && x.TspData.Contains("X8W")
                    && x.TspData.Contains("FA")
                    && x.TspTcreation >= fInicio)
                    .ToListAsync();
                List<EjFa> Ejlist = new();
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

                        EjFa piloto = new EjFa
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


                List<EjFa> uniqueDataList = Ejlist
                    .GroupBy(x => x.Vin)
                    .Select(g => g.First())
                    .ToList();

                return uniqueDataList;
            }

            List<EjFa> noUpdateData = null;

            return noUpdateData;
        }

        public async Task LoadData()
        {

            List<PilotosList> dataList = await getData();
            List<Ejlist> ejDataList = await getEJData();
            List<DashDatum> dashList = await getDashData();
            List<Km49Fa> getKMFA = await getKMFa();
            List<Km49E> getKMFevar = await getKMFe();
            List<EjE> getEJE = await getEJFe();
            List<EjFa> getEJFaList = await getEJFa();
            //int opnContext = _contextPilotos.PilotosLists.Count();
            //int opnEJContext = _contextPilotos.Ejlists.Count();
            //int openDash = _contextPilotos.DashData.Count();
            //int openKMFA = _contextPilotos.Km49Fas.Count();
            //int openKMFEVar = _contextPilotos.Km49Es.Count();
            //int openEJE = _contextPilotos.EjEs.Count();
            //int openEJFA = _contextPilotos.EjFas.Count();
            //List<DashDatum> dashList2 = await getDashData();


            int batchSize = 10;

            if (dataList != null)
            {
                var keysKm = dataList.Select(obj => obj.Suquence).ToList();
                var regCurrents = _contextPilotos.Ejlists.Where(reg => keysKm.Contains(reg.Sequence)).ToList();
                var regInsertkm = dataList.Where(obj => !regCurrents.Any(reg => reg.Sequence == obj.Suquence)).ToList();
                //Batch Processing 
                for (int i = 0; i < regInsertkm.Count; i += batchSize)
                {
                    List<PilotosList> batch = regInsertkm.Skip(i).Take(batchSize).ToList();

                    foreach (var item in batch)
                    {
                        _contextPilotos.Add(item);
                    }

                    await _contextPilotos.SaveChangesAsync();
                }
            }

            if (ejDataList != null)
            {
                var keys = ejDataList.Select(obj => obj.Sequence).ToList();
                var regCurrents = _contextPilotos.Ejlists.Where(reg => keys.Contains(reg.Sequence)).ToList();
                var regInsert = ejDataList.Where(obj => !regCurrents.Any(reg => reg.Sequence == obj.Sequence)).ToList();

                if (regInsert != null)
                {
                    //Batch Processing 
                    for (int i = 0; i < regInsert.Count; i += batchSize)
                    {
                        List<Ejlist> batch = regInsert.Skip(i).Take(batchSize).ToList();

                        foreach (var item in batch)
                        {
                            _contextPilotos.Add(item);
                        }

                        await _contextPilotos.SaveChangesAsync();
                    }
                }

            }

            //if (dashList != null)
            //{
            //    var currentData = await _contextPilotos.DashData.FindAsync(1);

            //    if (currentData != null)
            //    {
            //        DashDatum unionData = new DashDatum()
            //        {
            //            Kme = currentData.Kme,
            //            Kmfa = currentData.Kmfa,
            //            Eje = currentData.Eje + dashList[0].Eje,
            //            Ejfa = currentData.Ejfa + dashList[0].Ejfa,
            //            LastUpdate = DateTime.Now
            //        };
            //        dashList2.Add(unionData);
            //        try
            //        {
            //            _contextPilotos.Update(unionData);
            //            await _contextPilotos.SaveChangesAsync();
            //        }
            //        catch (DbUpdateConcurrencyException)
            //        {
            //            Console.WriteLine("Error");
            //        }
            //    }
            //    else
            //    {
            //        var data = dashList.ToList();

            //        foreach (var item in data)
            //        {
            //            _contextPilotos.Add(item);
            //            await _contextPilotos.SaveChangesAsync();
            //        }

            //    }
            //}

            if (getKMFA != null)
            {
                var keysKm = getKMFA.Select(obj => obj.Sequence).ToList();
                var regCurrents = _contextPilotos.Km49Fas.Where(reg => keysKm.Contains(reg.Sequence)).ToList();
                var regInsertkm = getKMFA.Where(obj => !regCurrents.Any(reg => reg.Sequence == obj.Sequence)).ToList();
                //Batch Processing 
                for (int i = 0; i < regInsertkm.Count; i += batchSize)
                {
                    List<Km49Fa> batch = regInsertkm.Skip(i).Take(batchSize).ToList();

                    foreach (var item in batch)
                    {
                        _contextPilotos.Add(item);
                    }

                    await _contextPilotos.SaveChangesAsync();
                }
            }

            if (getKMFevar != null)
            {
                var keysKm = getKMFevar.Select(obj => obj.Seuquence).ToList();
                var regCurrents = _contextPilotos.Km49Es.Where(reg => keysKm.Contains(reg.Seuquence)).ToList();
                var regInsertkm = getKMFevar.Where(obj => !regCurrents.Any(reg => reg.Seuquence == obj.Seuquence)).ToList();
                //Batch Processing 
                for (int i = 0; i < regInsertkm.Count; i += batchSize)
                {
                    List<Km49E> batch = regInsertkm.Skip(i).Take(batchSize).ToList();

                    foreach (var item in batch)
                    {
                        _contextPilotos.Add(item);
                    }

                    await _contextPilotos.SaveChangesAsync();
                }
            }

            if (getEJE != null)
            {
                var keysKm = getEJE.Select(obj => obj.Sequence).ToList();
                var regCurrents = _contextPilotos.Km49Es.Where(reg => keysKm.Contains(reg.Seuquence)).ToList();
                var regInsertkm = getEJE.Where(obj => !regCurrents.Any(reg => reg.Seuquence == obj.Sequence)).ToList();
                //Batch Processing 
                for (int i = 0; i < regInsertkm.Count; i += batchSize)
                {
                    List<EjE> batch = regInsertkm.Skip(i).Take(batchSize).ToList();

                    foreach (var item in batch)
                    {
                        _contextPilotos.Add(item);
                    }

                    await _contextPilotos.SaveChangesAsync();
                }
            }

            if (getEJFaList != null)
            {
                var keysKm = getEJFaList.Select(obj => obj.Vin).ToList();
                var regCurrents = _contextPilotos.Km49Es.Where(reg => keysKm.Contains(reg.Vin)).ToList();
                var regInsertkm = getEJFaList.Where(obj => !regCurrents.Any(reg => reg.Vin == obj.Vin)).ToList();
                //Batch Processing 
                for (int i = 0; i < regInsertkm.Count; i += batchSize)
                {
                    List<EjFa> batch = regInsertkm.Skip(i).Take(batchSize).ToList();

                    foreach (var item in batch)
                    {
                        _contextPilotos.Add(item);
                    }

                    await _contextPilotos.SaveChangesAsync();
                }
            }
        }

        public ActionResult getExcel(string sheetName)
        {
            // Configurar el contexto de la licencia de EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            // Definir la ruta del archivo
            string path_Excel = Directory.GetCurrentDirectory() + @"\Templates\ejemplo.xlsx";

            // Verificar si el archivo está en uso
            if (IsFileInUse(path_Excel))
            {
                Console.WriteLine("El archivo está siendo usado por otro proceso.");
                return null; // No se puede descargar el archivo si está en uso
            }
            else
            {
                // Obtener los datos desde tu contexto
                var kmEsinFa = _contextPilotos.EsinFas.ToList();
                // Guardar el archivo en un MemoryStream
                var memoryStream = new MemoryStream();
                // Abrir el archivo Excel y trabajar con EPPlus
                try
                {
                    using (var pck = new ExcelPackage(memoryStream))
                    {
                        var sheet = pck.Workbook.Worksheets.Add("Ejemplo");

                        // Agregar encabezados
                        sheet.Cells[1, 1].Value = "Creation";
                        sheet.Cells[1, 2].Value = "Sequence";
                        sheet.Cells[1, 3].Value = "Vin";
                        sheet.Cells[1, 4].Value = "Type";
                        sheet.Cells[1, 5].Value = "Color";
                        sheet.Cells[1, 6].Value = "Full Vin";

                        // Agregar datos de la lista
                        for (int i = 0; i < kmEsinFa.Count; i++)
                        {
                            sheet.Cells[i + 2, 1].Value = kmEsinFa[i].Creation;
                            sheet.Cells[i + 2, 1].Style.Numberformat.Format = "MM/dd/yyyy hh:mm tt"; // Formato de fecha y hora
                            sheet.Cells[i + 2, 2].Value = kmEsinFa[i].Sequence;
                            sheet.Cells[i + 2, 3].Value = kmEsinFa[i].Vin;
                            sheet.Cells[i + 2, 4].Value = kmEsinFa[i].Type;
                            sheet.Cells[i + 2, 5].Value = kmEsinFa[i].Color;
                            sheet.Cells[i + 2, 6].Value = kmEsinFa[i].FullVin;
                        }

                        // Autoajustar columnas para el contenido
                        sheet.Cells[sheet.Dimension.Address].AutoFitColumns();

                        pck.Save();
                    }
                    memoryStream.Position = 0;

                    // Devolver el archivo Excel como FileResult
                    return File(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Lista.xlsx");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error al intentar abrir o guardar el archivo: " + ex.Message);
                    return null; // Manejar el error apropiadamente según tus necesidades
                }
            }
        }

        // Método para verificar si el archivo está en uso
        private bool IsFileInUse(string filePath)
        {
            try
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                {
                    stream.Close();
                }
            }
            catch (IOException)
            {
                return true; // El archivo está en uso
            }
            return false; // El archivo no está en uso
        }
    }
}