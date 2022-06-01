using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string nombreCliente { get; set; }

        [Required]
        [Display(Name = "Correo")]
        public string mailCliente { get; set; }

        public string passwordCliente { get; set; }

        [Display(Name = "Nombre empresa")]
        public string empresaCliente { get; set; }
        
        [Display(Name = "Cuit empresa")]
        public string cuitCliente { get; set; }

        [Display(Name = "Domicilio empresa")]
        public string domicilioCliente { get; set; }

        [Display(Name = "Membresia")]
        [EnumDataType(typeof(PrecioCliente))]
        public PrecioCliente precioCliente { get; set; }

        //COMO RELACIONAR LA DBSET DE ENCUESTAS DE CADA CLIENTE???

    }
}
