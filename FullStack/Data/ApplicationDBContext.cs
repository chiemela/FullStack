using Microsoft.EntityFrameworkCore;
using FullStack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FullStack.Data
{
    public class ApplicationDBContext : IdentityDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<SalesLeadEntity> SalesLead { get; set; }
    }
}
