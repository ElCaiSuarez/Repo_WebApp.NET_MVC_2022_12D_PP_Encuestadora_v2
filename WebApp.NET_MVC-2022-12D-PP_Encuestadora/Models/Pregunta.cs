using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class Pregunta
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PreguntaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo pregunta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string tituloPregunta { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Tipo pregunta")]
        [EnumDataType(typeof(TipoPregunta))]
        public TipoPregunta tipoPregunta { get; set; }

        //RELACIONES CON OTRAS ENTIDADES

        [Display(Name = "Opciones")]
        public IEnumerable<OpcionPregunta> opciones { get; set; }

        //COMO RELACIONAR EL TIPO DE PREGUNTA CON EL INPUT DEL FORMULARIO???
    }
}
