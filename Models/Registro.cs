using System.ComponentModel.DataAnnotations;

namespace AppBusco.Models
{
    public class Registro
    {
       public int Id { get; set; }
        [Required]
        public string Nombre_del_Producto { get; set; }

        public string Url_Producto { get; set; }

        public string Descripcion { get; set; }

        public int Precio { get; set; }     

        public int Celular { get; set; }

        public string Lugar_De_Compra { get; set; }

        public string Nombre { get; set; }
    }
}