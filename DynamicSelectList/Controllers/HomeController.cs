using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DynamicSelectList.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DynamicSelectList.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicSelectList.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var customerList = _db.Customers
                .Include(x=>x.Country)
                .Include(x=>x.Country)
                .ToList();
            return View(customerList);
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
