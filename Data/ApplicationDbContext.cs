using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace pc2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<pc2.Models.Contacto> DataContacto {get; set; }
    public DbSet<pc2.Models.Producto> DataProducto {get; set; }
    public DbSet<pc2.Models.Proforma> DataItemCarrito {get; set; }
}
