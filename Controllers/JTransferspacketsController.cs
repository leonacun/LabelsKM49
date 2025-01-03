using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labels_KM49.Data;
using Labels_KM49.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using RawPrint;
using System.Net.Sockets;
using System.Text;
using Microsoft.Win32.SafeHandles;
using System.Data.SqlTypes;
using System.Net;
using Humanizer;
using static Labels_KM49.Controllers.JTransferspacketsController;
using Labels_KM49.Models.ViewModels;

namespace Labels_KM49.Controllers
{
    public class JTransferspacketsController : Controller
    {
        private readonly ModelContext _context;

        public JTransferspacketsController(ModelContext context)
        {
            _context = context;
        }

        // GET: JTransferspackets Data Extract
        public async Task<IActionResult> Index (string vin, string sequence, string fullvin, string color, string type, string ipAddres)
        {
            var time = DateTime.Now;
            int port = 9100;
            string part = "";
            long sbs2;

            var jitKM49 = _context.JTransferspackets
                          .Include(n => n.TspConnection)
                          .OrderByDescending(x => x.TspTcreation)
                          .Where(x => x.TspData.Contains("KMX")
                          && x.TspData.Contains("X8W")
                          && x.TspData.Contains("G ")
                          && x.TspData.Contains("3C4RJNA")
                          && x.TspTcreation > time.AddDays(-30))
                          .Take(100)
                          .ToList();

            var jitEJ = _context.JTransferspackets
                          .Include(n => n.TspConnection)
                          .OrderByDescending(x => x.TspTcreation)
                          .Where(x => x.TspData.Contains("SP")
                          && x.TspData.Contains("EJ")
                          && x.TspData.Contains("X8U")
                          && x.TspData.Contains("G ")
                          && x.TspData.Contains("3C4RJAC")
                          && x.TspTcreation > time.AddDays(-30))
                          .Take(100)
                          .ToList();

            List<PilotoViewModel> listaPilotos = new();
            {
                for (int i = 0; i < jitKM49.Count(); i++)
                {
                    // Data Transform
                    String[] delimiters = { "  ", " ", ".", "KMX", "SPT40313", "2024", "0000" };
                    string vins = jitKM49[i].TspData.ToString();
                    string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    sbs2 = long.Parse(subs[2]);

                    //Data Load to my Objet
                    if (subs[0].Contains("ST"))
                    {
                        PilotoViewModel piloto = new PilotoViewModel
                        {
                            Vin = subs[0],
                            type = "KM",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = subs[48],
                            Creation = jitKM49[i].TspTcreation
                        };
                        if (piloto.Vin.Contains("KM")) { }
                        else
                        {
                            listaPilotos.Add(piloto);

                        }
                    }
                    else
                    {
                        PilotoViewModel piloto = new PilotoViewModel
                        {
                            Vin = subs[0],
                            type = "KM",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = subs[46],
                            Creation = jitKM49[i].TspTcreation
                        };
                        if (piloto.Vin.Contains("KM")) { }
                        else
                        {
                            listaPilotos.Add(piloto);

                        }
                    }

                }
                for (int i = 0; i < jitEJ.Count(); i++)
                {
                    // Data Transform
                    String[] delimiters = { "  ", " ", ".", "SPT40313", "EJ", "2024", "0000" };
                    string vins = jitEJ[i].TspData.ToString();
                    string[] subs = vins.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    sbs2 = long.Parse(subs[2]);
                    //Data Load to my Objet
                    if (subs.Length <= 35)
                    {
                        PilotoViewModel piloto = new PilotoViewModel
                        {
                            Vin = subs[0],
                            type = "EJ",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = subs[33],
                            Creation = jitEJ[i].TspTcreation
                        };
                        listaPilotos.Add(piloto);
                    }
                    else
                    {
                        PilotoViewModel piloto = new PilotoViewModel
                        {
                            Vin = subs[0],
                            type = "EJ",
                            Sequence = sbs2,
                            FullVin = subs.Last(),
                            Color = subs[34],
                            Creation = jitEJ[i].TspTcreation
                        };
                        listaPilotos.Add(piloto);
                    }
                }
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
                bool MBJ = color.Contains("MBJ"); bool KXJ = color.Contains("KXJ"); 
                bool GW7 = color.Contains("GW7"); bool SSE = color.Contains("SSE");
                bool WAS = color.Contains("WAS"); bool ZR6 = color.Contains("ZR6");
                bool LPS = color.Contains("LPS");

                ZplPrinter zplPrinter = new ZplPrinter();

                if (EJMBJ)
                {
                    string FrontDesc = "Front Fascia Hydro Blue";
                    string RearDesc = "Rear Fascia Hydro Blue";

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (EJKXJ)
                {
                    string FrontDesc = "Front Fascia Diamond Black";
                    string RearDesc = "Rear Fascia Diamond Black";

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (EJGW7)
                {
                    string FrontDesc = "Front Fascia Bright White";
                    string RearDesc = "Rear Fascia Bright White";

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);

                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (EJSSE)
                {
                    string FrontDesc = "Front Fascia Silver Zynith";
                    string RearDesc = "Rear Fascia Silver Zynith";

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (EJWAS)
                {
                    string FrontDesc = "Front Fascia Baltic Gray";
                    string RearDesc = "Rear Fascia Baltic Gray";

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (EJZR6)
                {
                    string FrontDesc = "Front Fascia Red Hot";
                    string RearDesc = "Rear Fascia Red Hot";

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (EJLPS)
                {
                    string FrontDesc = "Front Fascia Fantom Blue";
                    string RearDesc = "Rear Fascia Fantom Blue";

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
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
                    return RedirectToAction("Index", "JTransferspackets");

                }
                
                if (KXJ) {
                    part = "7KM79KXJAA";
                    string HoodDesc = "Hood Applique Diamond Black";
                    string FrontDesc = "KM49 Front Fascia Diamond Black";
                    string RearDesc = "KM49 Rear Fascia Diamond Black";
                    string LGDesc = "KIT KM49 LG Diamond Black";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (GW7) {
                    part = "7KM79GW7AA";
                    string HoodDesc = "Hood Applique Bright White";
                    string FrontDesc = "KM49 Front Fascia Bright White";
                    string RearDesc = "KM49 Rear Fascia Bright White";
                    string LGDesc = "KIT KM49 LG Bright White";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
                }

                if (SSE) {
                    part = "7KM79SSEAA";
                    string HoodDesc = "Hood Applique Silver Zynith";
                    string FrontDesc = "KM49 Front Fascia Silver Zynith";
                    string RearDesc = "KM49 Rear Fascia Silver Zynith";
                    string LGDesc = "KIT KM49 LG Silver Zynith";


                    zplPrinter.PrintHood(ipAddres, port, part, HoodDesc, vin, sequence, fullvin);

                    zplPrinter.PrintFascias(ipAddres, port, FrontDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, RearDesc, vin, sequence, fullvin);
                    zplPrinter.PrintFascias(ipAddres, port, LGDesc, vin, sequence, fullvin);
                    return RedirectToAction("Index", "JTransferspackets");
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
                    return RedirectToAction("Index", "JTransferspackets");
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
                    return RedirectToAction("Index", "JTransferspackets");
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
                    return RedirectToAction("Index", "JTransferspackets");
                }

                return RedirectToAction("Index", "JTransferspackets");
            }
            else
            {
                return View(listaPilotos.OrderByDescending(x => x.Creation));
            }
        }
        public class ZplPrinter
        {
            public void PrintHood(string ipAddress, int port, string part, string description, string vin, string sequence, string fullvin)
            {
                try
                {
                    var dateTime = DateTime.Now;
                    var date = dateTime.ToString("MM/dd/yyyy");
                    var time = dateTime.ToString("HH:mm:ss");

                    string ZPLString = "";
                    string path_label = Directory.GetCurrentDirectory() + @"\Templates\HoodAplique.txt";
                    using (TcpClient client = new TcpClient())
                    {
                        client.Connect(ipAddress, port);
                        using (StreamWriter writer = new StreamWriter(client.GetStream()))
                        {
                            using (StreamReader sr = new StreamReader(path_label))
                            {
                                ZPLString = sr.ReadToEnd();
                                ZPLString = ZPLString.Replace("@date", date);
                                ZPLString = ZPLString.Replace("@time", time);
                                ZPLString = ZPLString.Replace("@part", part);
                                ZPLString = ZPLString.Replace("@description", description);
                                ZPLString = ZPLString.Replace("@vin", vin);
                                ZPLString = ZPLString.Replace("@sequence", sequence);
                                ZPLString = ZPLString.Replace("@fullvin", fullvin);

                                writer.Write(ZPLString);
                                ZPLString = sr.ReadToEnd();
                                writer.Flush();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al imprimir: " + ex.Message);
                }
            }

            public void PrintKM74NP(string ipAddress, int port, string part, string description, string vin, string sequence, string fullvin)
            {
                try
                {
                    var dateTime = DateTime.Now;
                    var date = dateTime.ToString("MM/dd/yyyy");
                    var time = dateTime.ToString("HH:mm:ss");

                    string ZPLString = "";
                    string path_label = Directory.GetCurrentDirectory() + @"\Templates\KM74NP.txt";
                    using (TcpClient client = new TcpClient())
                    {
                        client.Connect(ipAddress, port);
                        using (StreamWriter writer = new StreamWriter(client.GetStream()))
                        {
                            using (StreamReader sr = new StreamReader(path_label))
                            {
                                ZPLString = sr.ReadToEnd();
                                ZPLString = ZPLString.Replace("@date", date);
                                ZPLString = ZPLString.Replace("@time", time);
                                ZPLString = ZPLString.Replace("@part", part);
                                ZPLString = ZPLString.Replace("@description", description);
                                ZPLString = ZPLString.Replace("@vin", vin);
                                ZPLString = ZPLString.Replace("@sequence", sequence);
                                ZPLString = ZPLString.Replace("@fullvin", fullvin);

                                writer.Write(ZPLString);
                                ZPLString = sr.ReadToEnd();
                                writer.Flush();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al imprimir: " + ex.Message);
                }
            }

            public void PrintFascias(string ipAddress, int port, string description, string vin, string sequence, string fullvin)
            {
                try
                {
                    var dateTime = DateTime.Now;
                    var date = dateTime.ToString("MM/dd/yyyy");
                    var time = dateTime.ToString("HH:mm:ss");

                    string ZPLString = "";
                    string path_label = Directory.GetCurrentDirectory() + @"\Templates\Fascias.txt";
                    using (TcpClient client = new TcpClient())
                    {
                        client.Connect(ipAddress, port);
                        using (StreamWriter writer = new StreamWriter(client.GetStream()))
                        {
                            using (StreamReader sr = new StreamReader(path_label))
                            {
                                ZPLString = sr.ReadToEnd();
                                ZPLString = ZPLString.Replace("@date", date);
                                ZPLString = ZPLString.Replace("@time", time);
                                ZPLString = ZPLString.Replace("@description", description);
                                ZPLString = ZPLString.Replace("@vin", vin);
                                ZPLString = ZPLString.Replace("@sequence", sequence);
                                ZPLString = ZPLString.Replace("@fullvin", fullvin);

                                writer.Write(ZPLString);
                                ZPLString = sr.ReadToEnd();
                                writer.Flush();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al imprimir: " + ex.Message);
                }
            }
        }
        
        
    }

}