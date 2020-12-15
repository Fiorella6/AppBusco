using AppBusco.Models;
using Microsoft.EntityFrameworkCore;

namespace AppBusco.Data
{
    public class WebAppContext : DbContext
    {
        public DbSet<Registro> Contactos { get; set; }

        public WebAppContext(DbContextOptions dco) : base(dco) {

        }
    }
}
