using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MLOps_Dashboard.Models;
using System.Diagnostics;

namespace MLOps_Dashboard.Controllers
{
    public class HomeController : Controller
    {
        private readonly MLOpsContext _context;

        // Inject the database context
        public HomeController(MLOpsContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // Group by Dataset, and find the TrainingRun with the highest Accuracy in each group.
            var bestRuns = _context.TrainingRuns
                .Include(t => t.Dataset)
                .Include(t => t.Architecture)
                .ToList() // Evaluate client-side since SQLite has limited GroupBy support
                .GroupBy(t => t.Dataset.Name)
                .Select(group => group.OrderByDescending(t => t.Accuracy).First())
                .ToList();

            return View(bestRuns);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}