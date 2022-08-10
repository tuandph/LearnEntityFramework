using Microsoft.EntityFrameworkCore;
using TuanDPH.LearnEntityFramework.Models;

namespace TuanDPH.LearnEntityFramework.SeedData
{
    public static class LocationSeed
    {
        public static void SeedLocationData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
               .HasData(
                   new Location
                   {
                       ID = 1,
                       Name = "Viet Nam",
                   },
                   new Location
                   {
                       ID = 2,
                       Name = "Malay",
                   },
                   new Location
                   {
                       ID = 3,
                       Name = "Canada",
                   }
               );
        }
    }
}
