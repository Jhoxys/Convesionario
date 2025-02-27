using CapaPrincipal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CapaPrincipal.Service
{
    public class ApplicationDbContext : IdentityDbContext
    {
    

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
          

        public  DbSet<Product> Products { get; set; }
     
    }
}
