using System.ComponentModel.DataAnnotations;

namespace WinFormsApp4.Modelos
{
    public class Producto
        
    {
        [Key]
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int IdCategoria { get; set; }
        public bool Activo { get; set; }
    }
}
