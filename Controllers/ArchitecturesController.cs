using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MLOps_Dashboard.Models;

namespace MLOps_Dashboard.Controllers
{
    public class ArchitecturesController : Controller
    {
        private readonly MLOpsContext _context;

        public ArchitecturesController(MLOpsContext context)
        {
            _context = context;
        }

        // GET: Architectures
        public async Task<IActionResult> Index()
        {
            return View(await _context.Architectures.ToListAsync());
        }

        // GET: Architectures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var architecture = await _context.Architectures
                .FirstOrDefaultAsync(m => m.Id == id);
            if (architecture == null)
            {
                return NotFound();
            }

            return View(architecture);
        }

        // GET: Architectures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Architectures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] Architecture architecture)
        {
            if (ModelState.IsValid)
            {
                _context.Add(architecture);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(architecture);
        }

        // GET: Architectures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var architecture = await _context.Architectures.FindAsync(id);
            if (architecture == null)
            {
                return NotFound();
            }
            return View(architecture);
        }

        // POST: Architectures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] Architecture architecture)
        {
            if (id != architecture.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(architecture);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArchitectureExists(architecture.Id))
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
            return View(architecture);
        }

        // GET: Architectures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var architecture = await _context.Architectures
                .FirstOrDefaultAsync(m => m.Id == id);
            if (architecture == null)
            {
                return NotFound();
            }

            return View(architecture);
        }

        // POST: Architectures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var architecture = await _context.Architectures.FindAsync(id);
            if (architecture != null)
            {
                _context.Architectures.Remove(architecture);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArchitectureExists(int id)
        {
            return _context.Architectures.Any(e => e.Id == id);
        }
    }
}
