using System.ComponentModel.DataAnnotations;

namespace Productos.Models
{
    public class Material
    {
        [Key]
        public int MaterialId {get; set;}
        public string Descripcion {get; set;}
        public int RubroId {get; set;}
        public decimal PrecioCosto {get; set;}
        public bool Eliminado {get; set;} = false;
    }
}