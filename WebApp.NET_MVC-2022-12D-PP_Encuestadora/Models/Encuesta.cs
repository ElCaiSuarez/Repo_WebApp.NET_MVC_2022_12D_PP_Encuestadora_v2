using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class Encuesta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EncuestaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo encuesta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string tituloEncuesta { get; set; }

        [Display(Name = "Fecha creación")]
        [DataType(DataType.Date)]
        public DateTime datetimeCreacionEncuesta { get; set; }

        [Display(Name = "Fecha vencimiento")]
        [DataType(DataType.Date)]
        public DateTime datetimeVencimientoEncuesta { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1 CON PUNTOSENCUESTA
        [Display(Name = "Puntos encuesta")]
        [EnumDataType(typeof(PuntosEncuesta))]
        public PuntosEncuesta puntosEncuesta { get; set; }

        //FK CLIENTE
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        //RELACION 1 a N CON PREGUNTA
        [Display(Name = "Preguntas")]
        public ICollection<Pregunta> preguntas { get; set; }
        
        //RELACION N a N CON USUARIO
        [Display(Name = "EncuestasUsuarios")]
        public ICollection<EncuestasUsuarios> EncuestasUsuarios { get; set; }




    }
}
