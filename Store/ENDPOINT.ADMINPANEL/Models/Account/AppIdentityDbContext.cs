using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EndPoint.UI.panelAdmin.Models.Account
{
    public class AppIdentityDbContext : IdentityDbContext<Appuser>
    {//public class ApplicationDbContext : DbContext
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options):base(options)
        {
            
        }
    }
}
