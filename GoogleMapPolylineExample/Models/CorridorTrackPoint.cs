using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleMapPolylineExample.Models
{
    public class CorridorTrackPoint
    {
		[Key]
        public Guid Id { get; set; }
		public Guid CorridorTrackId { get; set; }
		public string Code { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public double MileMark { get; set; }
        public DateTime CreatedOn { get; set; }
		public DateTime ModifiedOn { get; set; }
		public string CreatedBy { get; set; }
		public string CreatedByFullName { get; set; }
		public string ModifiedBy { get; set; }
		public string ModifiedByFullName { get; set; }
	}
}
