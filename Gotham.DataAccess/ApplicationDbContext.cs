using Gotham.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Gotham.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<Gotham.Model.Account> Accounts { get; set; }
    }
}
