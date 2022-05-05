using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using farmamest.Models;
using Database.Shared.IRepository;
using Database.Shared.Data;
using Wkhtmltopdf.NetCore;

namespace sistema.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        
        public HomeController(ILogger<HomeController> logger)//, IGeneratePdf generatePdf)
        {
            _logger = logger;
           // _generatePdf = generatePdf;

        }

        public IActionResult Index()
        {
           
           return View();
           // return await _generatePdf.GetPdf("Views/Home/Index.cshtml", "Hello World");
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
