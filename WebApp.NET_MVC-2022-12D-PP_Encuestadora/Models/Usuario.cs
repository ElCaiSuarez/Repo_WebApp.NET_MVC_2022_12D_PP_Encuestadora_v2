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

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Nombre")]
        [MaxLength(80, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string nombreUsuario { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Correo")]
        [EmailAddress]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string mailUsuario { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Contraseña")]
        [MaxLength(10, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string passwordUsuario { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "DNI")]
        [MaxLength(8, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string dniUsuario { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Fecha nacimiento")]
        [DataType(DataType.Date)]
        public DateTime datetimeFechaNacimiento { get; set; }

        [Display(Name = "Domicilio")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string domicilioUsuario { get; set; }

        //RELACIONES CON OTRAS ENTIDADES

        [Display(Name = "Preferencias")]
        [EnumDataType(typeof(PreferenciaUsuario))]
        public PreferenciaUsuario preferenciaUsuario { get; set; }
        
        //RELACION N a N CON ENCUESTA
        [Display(Name = "EncuestasUsuarios")]
        public ICollection<EncuestasUsuarios> EncuestasUsuarios { get; set; }


    }
}
