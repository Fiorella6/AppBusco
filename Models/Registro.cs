using System.ComponentModel.DataAnnotations;

namespace AppBusco.Models
{
    public class Registro
    {
         [Required]

      public string Nombre_del_Producto { get; set;}

        [Required]

        public string Url_Producto { get; set;}

          [Required]

          public string Descripcion { get; set;}

            [Required]

            public string Precio  {get; set;}
        
              [Required]

              public string Celular { get; set;}

                [Required]

                public string Lugar_De_Compra { get; set;}

                  [Required]

                  public string Nombre { get; set;}
    }
}