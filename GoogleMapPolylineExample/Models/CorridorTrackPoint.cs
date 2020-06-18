using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapPolylineExample.Models
{
    public class CorridorTrackPoint
    {
        public string Code { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double MileMark { get; set; }

    }
}
