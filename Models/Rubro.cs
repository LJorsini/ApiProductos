using System.ComponentModel.DataAnnotations;

namespace Productos.Models
{
    public class Rubro
    {
        [Key]
        public int RubroId {get; set;}
        public string Nombre {get; set;}
        public bool Eliminado {get; set;} = false;
    }
}