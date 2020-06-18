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
            //List<CorridorTrackPoint> corridorTrackPoints = _context.CorridorTrackPoints.ToList();

            List<CorridorTrackPoint> corridorTrackPoints = new List<CorridorTrackPoint>
            {
                new CorridorTrackPoint(){ Lat = 38.9053623, Lng = -121.0841413 },
                new CorridorTrackPoint(){ Lat = 38.9041518, Lng = -121.0836144 }
            };

            string arrayOfTrackPoints = "[";

            foreach(CorridorTrackPoint corridorTrackPoint in corridorTrackPoints)
            {
                arrayOfTrackPoints = arrayOfTrackPoints + "{ lat: "
                    + corridorTrackPoint.Lat
                    + ", lng: "
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
