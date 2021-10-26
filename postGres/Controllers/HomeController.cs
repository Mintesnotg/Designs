using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using postGres.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PContext context;

        public HomeController(ILogger<HomeController> logger, PContext _context)
        {
            _logger = logger;
            context = _context;
        }

        public  IActionResult Index()
        {
            context.firsts.Add(new first("namee", false));
            context.SaveChanges();
            //List<first> firsts= Task.Run(()=>  context.firsts.Where(a => a.isNull == false).ToList());
            List<first> firsts=  context.firsts.Where(a => a.isNull == false).ToList();
            return View(firsts);
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
