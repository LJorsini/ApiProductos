using Microsoft.AspNetCore.Identity;

namespace Productos.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string? NombreCompleto {get; set;}
    }
}