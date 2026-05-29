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
    public class HyperparametersController : Controller
    {
        private readonly MLOpsContext _context;

        public HyperparametersController(MLOpsContext context)
        {
            _context = context;
        }

        // GET: Hyperparameters
        public async Task<IActionResult> Index()
        {
            var mLOpsContext = _context.Hyperparameters.Include(h => h.Architecture);
            return View(await mLOpsContext.ToListAsync());
        }

        // GET: Hyperparameters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hyperparameter = await _context.Hyperparameters
                .Include(h => h.Architecture)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hyperparameter == null)
            {
                return NotFound();
            }

            return View(hyperparameter);
        }

        // GET: Hyperparameters/Create
        public IActionResult Create()
        {
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id");
            return View();
        }

        // POST: Hyperparameters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ArchitectureId,Key,Value")] Hyperparameter hyperparameter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hyperparameter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id", hyperparameter.ArchitectureId);
            return View(hyperparameter);
        }

        // GET: Hyperparameters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hyperparameter = await _context.Hyperparameters.FindAsync(id);
            if (hyperparameter == null)
            {
                return NotFound();
            }
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id", hyperparameter.ArchitectureId);
            return View(hyperparameter);
        }

        // POST: Hyperparameters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ArchitectureId,Key,Value")] Hyperparameter hyperparameter)
        {
            if (id != hyperparameter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hyperparameter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HyperparameterExists(hyperparameter.Id))
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
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id", hyperparameter.ArchitectureId);
            return View(hyperparameter);
        }

        // GET: Hyperparameters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hyperparameter = await _context.Hyperparameters
                .Include(h => h.Architecture)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hyperparameter == null)
            {
                return NotFound();
            }

            return View(hyperparameter);
        }

        // POST: Hyperparameters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hyperparameter = await _context.Hyperparameters.FindAsync(id);
            if (hyperparameter != null)
            {
                _context.Hyperparameters.Remove(hyperparameter);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HyperparameterExists(int id)
        {
            return _context.Hyperparameters.Any(e => e.Id == id);
        }
    }
}
