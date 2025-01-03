using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labels_KM49.Data;
using Labels_KM49.Models;
using Labels_KM49.Models.ViewModels;
using System.Net.NetworkInformation;
using System.Linq.Dynamic;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace Labels_KM49.Controllers
{
    public class numberPartsController : Controller
    {
        private readonly ModelContext _context;

        public numberPartsController(ModelContext context)
        {
            _context = context;
        }

        // GET: numberParts
        public async Task<IActionResult> Index()
        {
            var time = DateTime.Now;

            IQueryable<JTransferspacketViewModel> 
            query = (from d in _context.JTransferspackets
            select new JTransferspacketViewModel
            {
                TspId = d.TspId,
                TspTcreation = d.TspTcreation,
                TspStatus = d.TspStatus,
                TspData = d.TspData

            });

            if (Request.ContentType != null)
            {
                var daysPost = Request.Form["days"].FirstOrDefault();
                var entriesPost = Request.Form["entries"].FirstOrDefault();
                var search = Request.Form["search"].FirstOrDefault();
                int days = 1;
                Int32.TryParse(daysPost, out days);
                int entries = 1;
                Int32.TryParse(entriesPost, out entries);

                if (search != "") query = query.Where(x => x.TspData.Contains(search));
                //if (search.Contains("*")) queryGenerator(search);
                query = query.Where(x => x.TspTcreation > time.AddDays(-days));
                ViewBag.recordsTotal = query.Count();

                return View(await query.OrderByDescending(m => m.TspTcreation).Take(entries).ToListAsync());
            }
            else
            {
                query = query.Where(x => x.TspTcreation > time.AddDays(-1));

                ViewBag.recordsTotal = query.Count();
                return View(await query.OrderByDescending(m => m.TspTcreation).Take(10).ToListAsync());
            }
            
        }

        private static string queryGenerator(string search)
        {
            string consulta = "";
            //Get list
            var plus = "&&";
            string[] filters = search.Split('*', StringSplitOptions.RemoveEmptyEntries);


            // Generar consulta 
            int cnt = filters.Length;

            for (int i = 0; i <= filters.Count(); i++)
            {
                string initFilter = "filters[" + i + "] ";
                consulta = "(x => x.TspData.Contains(" + filters[0] + ") )";
            }

            return consulta;
        }

    }
}

