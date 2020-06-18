using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoogleMapPolylineExample.Models;

namespace GoogleMapPolylineExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var trackPoints = _context.CorridorTrackPoints.ToList();


       //     [
       //         { lat: 37.772, lng: -122.214 },
			    //{ lat: 21.291, lng: -157.821 },
			    //{ lat: -18.142, lng: 178.431 },
			    //{ lat: -27.467, lng: 153.027 }
       //     ]



            return View();
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
