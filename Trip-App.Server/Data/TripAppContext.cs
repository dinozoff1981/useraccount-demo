using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trip_App.Server.Models;

namespace Trip_App.Server.Data
{
    public class TripAppContext:IdentityDbContext<User>
    {

        public TripAppContext(DbContextOptions<TripAppContext> options):base(options) 
        {
            
        }
    }
}
