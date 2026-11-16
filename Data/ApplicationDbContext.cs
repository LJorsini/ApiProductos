using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using Productos.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>

{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

        : base(options)

    {

    }

 
    public DbSet<Material> Materiales {get; set;} 
    public DbSet<Producto> Productos {get; set;}
    public DbSet<Rubro> Rubros {get; set;}
    // Agrega tus DbSet aquí

}