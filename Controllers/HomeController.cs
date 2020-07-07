using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using monitor_covid19.Data;
using monitor_covid19.Models;

namespace monitor_covid19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Statistics
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Statistic.Include(s => s.Country);
            return View(await applicationDbContext.ToListAsync());
        }
    }
}
