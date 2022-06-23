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
        public Pregunta()
        {
            this.opciones = new List<OpcionPregunta>();
            this.respuestas = new List<PreguntaRespondida>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PreguntaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo pregunta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string tituloPregunta { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1 CON PUNTOSENCUESTA
        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Tipo pregunta")]
        [EnumDataType(typeof(TipoPregunta))]
        public TipoPregunta tipoPregunta { get; set; }

        //FK ENCUESTA
        public int EncuestaId { get; set; }
        public Encuesta Encuesta { get; set; }

        //RELACION 1 a N CON OPCIONPREGUNTA
        [Display(Name = "Opciones")]
        //public ICollection<OpcionPregunta> opciones { get; set; }
        public ICollection<OpcionPregunta> opciones { get; set; }
        //{ get; set}

        //public ICollection<PreguntaRespondida> respuestas { get; set; }
        public ICollection<PreguntaRespondida> respuestas { get; set; }
        //COMO RELACIONAR EL TIPO DE PREGUNTA CON EL INPUT DEL FORMULARIO???
    }
}
