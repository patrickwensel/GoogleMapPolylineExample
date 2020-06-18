using GoogleMapPolylineExample.Models;
using Microsoft.EntityFrameworkCore;

namespace GoogleMapPolylineExample
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public virtual DbSet<CorridorTrackPoint> CorridorTrackPoints { get; set; }
    }
}
