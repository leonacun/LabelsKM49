using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Labels_KM49.Data;
using Labels_KM49.Models;

namespace Labels_KM49.Controllers
{
    public class JPrintersController : Controller
    {
        private readonly ModelContext _context;

        public JPrintersController(ModelContext context)
        {
            _context = context;
        }

        // GET: JPrinters
        public async Task<IActionResult> Index()
        {
            var modelContext = _context.JPrinters.Include(j => j.PriPrinterset).Include(j => j.PriRedirprinter).Where(p => p.PriDialect.Contains("ZPL"));
            return View(await modelContext.ToListAsync());
        }

        // GET: JPrinters/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null || _context.JPrinters == null)
            {
                return NotFound();
            }

            var jPrinter = await _context.JPrinters
                .Include(j => j.PriPrinterset)
                .Include(j => j.PriRedirprinter)
                .FirstOrDefaultAsync(m => m.PriId == id);
            if (jPrinter == null)
            {
                return NotFound();
            }

            return View(jPrinter);
        }

        // GET: JPrinters/Create
        public IActionResult Create()
        {
            ViewData["PriPrintersetId"] = new SelectList(_context.JPrintersets, "PrisId", "PrisId");
            ViewData["PriRedirprinterId"] = new SelectList(_context.JPrinters, "PriId", "PriId");
            return View();
        }

        // POST: JPrinters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PriId,PriPrintersetId,PriRedirprinterId,PriTcreation,PriTupdate,PriKey,PriDescr,PriProtocol,PriDialect,PriConfig,PriTemplate,PriIseditable,PriOsqueue,PriUrl")] JPrinter jPrinter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jPrinter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PriPrintersetId"] = new SelectList(_context.JPrintersets, "PrisId", "PrisId", jPrinter.PriPrintersetId);
            ViewData["PriRedirprinterId"] = new SelectList(_context.JPrinters, "PriId", "PriId", jPrinter.PriRedirprinterId);
            return View(jPrinter);
        }

        // GET: JPrinters/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null || _context.JPrinters == null)
            {
                return NotFound();
            }

            var jPrinter = await _context.JPrinters.FindAsync(id);
            if (jPrinter == null)
            {
                return NotFound();
            }
            ViewData["PriPrintersetId"] = new SelectList(_context.JPrintersets, "PrisId", "PrisId", jPrinter.PriPrintersetId);
            ViewData["PriRedirprinterId"] = new SelectList(_context.JPrinters, "PriId", "PriId", jPrinter.PriRedirprinterId);
            return View(jPrinter);
        }

        // POST: JPrinters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("PriId,PriPrintersetId,PriRedirprinterId,PriTcreation,PriTupdate,PriKey,PriDescr,PriProtocol,PriDialect,PriConfig,PriTemplate,PriIseditable,PriOsqueue,PriUrl")] JPrinter jPrinter)
        {
            if (id != jPrinter.PriId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jPrinter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JPrinterExists(jPrinter.PriId))
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
            ViewData["PriPrintersetId"] = new SelectList(_context.JPrintersets, "PrisId", "PrisId", jPrinter.PriPrintersetId);
            ViewData["PriRedirprinterId"] = new SelectList(_context.JPrinters, "PriId", "PriId", jPrinter.PriRedirprinterId);
            return View(jPrinter);
        }

        // GET: JPrinters/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null || _context.JPrinters == null)
            {
                return NotFound();
            }

            var jPrinter = await _context.JPrinters
                .Include(j => j.PriPrinterset)
                .Include(j => j.PriRedirprinter)
                .FirstOrDefaultAsync(m => m.PriId == id);
            if (jPrinter == null)
            {
                return NotFound();
            }

            return View(jPrinter);
        }

        // POST: JPrinters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            if (_context.JPrinters == null)
            {
                return Problem("Entity set 'ModelContext.JPrinters'  is null.");
            }
            var jPrinter = await _context.JPrinters.FindAsync(id);
            if (jPrinter != null)
            {
                _context.JPrinters.Remove(jPrinter);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JPrinterExists(decimal id)
        {
          return (_context.JPrinters?.Any(e => e.PriId == id)).GetValueOrDefault();
        }
    }
}
