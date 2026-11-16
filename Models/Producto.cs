using System.ComponentModel.DataAnnotations;

namespace Productos.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId {get; set;}
        public string Descripcion {get; set;}
        public bool Eliminado {get; set;} = false;
    }
}