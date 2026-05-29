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
    public class TrainingRunsController : Controller
    {
        private readonly MLOpsContext _context;

        public TrainingRunsController(MLOpsContext context)
        {
            _context = context;
        }

        // GET: TrainingRuns
        public async Task<IActionResult> Index()
        {
            var mLOpsContext = _context.TrainingRuns.Include(t => t.Architecture).Include(t => t.Dataset);
            return View(await mLOpsContext.ToListAsync());
        }

        // GET: TrainingRuns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingRun = await _context.TrainingRuns
                .Include(t => t.Architecture)
                .Include(t => t.Dataset)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingRun == null)
            {
                return NotFound();
            }

            return View(trainingRun);
        }

        // GET: TrainingRuns/Create
        public IActionResult Create()
        {
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id");
            ViewData["DatasetId"] = new SelectList(_context.Datasets, "Id", "Id");
            return View();
        }

        // POST: TrainingRuns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DatasetId,ArchitectureId,Accuracy,TrainingTimeMs,Timestamp")] TrainingRun trainingRun)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainingRun);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id", trainingRun.ArchitectureId);
            ViewData["DatasetId"] = new SelectList(_context.Datasets, "Id", "Id", trainingRun.DatasetId);
            return View(trainingRun);
        }

        // GET: TrainingRuns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingRun = await _context.TrainingRuns.FindAsync(id);
            if (trainingRun == null)
            {
                return NotFound();
            }
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id", trainingRun.ArchitectureId);
            ViewData["DatasetId"] = new SelectList(_context.Datasets, "Id", "Id", trainingRun.DatasetId);
            return View(trainingRun);
        }

        // POST: TrainingRuns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DatasetId,ArchitectureId,Accuracy,TrainingTimeMs,Timestamp")] TrainingRun trainingRun)
        {
            if (id != trainingRun.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainingRun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingRunExists(trainingRun.Id))
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
            ViewData["ArchitectureId"] = new SelectList(_context.Architectures, "Id", "Id", trainingRun.ArchitectureId);
            ViewData["DatasetId"] = new SelectList(_context.Datasets, "Id", "Id", trainingRun.DatasetId);
            return View(trainingRun);
        }

        // GET: TrainingRuns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainingRun = await _context.TrainingRuns
                .Include(t => t.Architecture)
                .Include(t => t.Dataset)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainingRun == null)
            {
                return NotFound();
            }

            return View(trainingRun);
        }

        // POST: TrainingRuns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainingRun = await _context.TrainingRuns.FindAsync(id);
            if (trainingRun != null)
            {
                _context.TrainingRuns.Remove(trainingRun);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainingRunExists(int id)
        {
            return _context.TrainingRuns.Any(e => e.Id == id);
        }
    }
}
