using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string nombreUsuario { get; set; }

        [Required]
        [Display(Name = "Correo")]
        public string mailUsuario { get; set; }

        public string passwordUsuario { get; set; }

        [Display(Name = "DNI")]
        public string dniUsuario { get; set; }

        [Display(Name = "Fecha nacimiento")]
        public DateTime datetimeFechaNacimiento { get; set; }

        [Display(Name = "Domicilio")]
        public string domicilioUsuario { get; set; }

        [Display(Name = "Preferencia")]
        [EnumDataType(typeof(PreferenciaUsuario))]
        public PreferenciaUsuario preferenciaUsuario { get; set; }

        //COMO RELACIONAR LA DBSET DE ENCUESTAS DE CADA CLIENTE???

        //FALTARIA FALTARIA LISTA DE ENCUESTAS RESPONDIDAS o RELACION CON ELLAS, LISTA DE PREFERENCIAS, FECHA DE NACIMIENTO, EMAIL y DOMICILIO
    }
}
