using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GoogleMapPolylineExample.Models;
using System.Runtime.CompilerServices;

namespace GoogleMapPolylineExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<CorridorTrackPoint> corridorTrackPoints = _context.CorridorTrackPoints.Where(y=> y.CorridorTrackId== Guid.Parse("E3F2F0D8-8A90-4203-9A91-D9E3535A1B0E")).ToList();

            //List<CorridorTrackPoint> corridorTrackPoints = new List<CorridorTrackPoint>
            //{
            //    new CorridorTrackPoint(){ Lat = 37.772, Lng = -122.214 },
            //    new CorridorTrackPoint(){ Lat = 21.291, Lng = -157.821  },
            //    new CorridorTrackPoint(){ Lat = -18.142, Lng = 178.431 },
            //    new CorridorTrackPoint(){ Lat = -27.467, Lng = 153.027  },
            //};

            string arrayOfTrackPoints = "[";

            foreach(CorridorTrackPoint corridorTrackPoint in corridorTrackPoints)
            {
                arrayOfTrackPoints = arrayOfTrackPoints + "{ \"lat\": "
                    + corridorTrackPoint.Lat
                    + ", \"lng\": "
                    + corridorTrackPoint.Lng
                    + " },";
            }

            arrayOfTrackPoints = arrayOfTrackPoints.Remove(arrayOfTrackPoints.Length - 1, 1);
            arrayOfTrackPoints = arrayOfTrackPoints + "]";

            ViewData["arrayOfTrackPoints"] = arrayOfTrackPoints;

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
