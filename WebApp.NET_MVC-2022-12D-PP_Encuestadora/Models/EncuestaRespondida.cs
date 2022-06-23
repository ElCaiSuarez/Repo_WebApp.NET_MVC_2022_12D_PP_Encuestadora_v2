using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class EncuestaRespondida
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EncuestaRespondidaId { get; set; }

        public int EncuestaId { get; set; }

        public Encuesta encuesta { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo encuesta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string tituloEncuesta { get; set; }

        [Display(Name = "Fecha respuesta")]
        [DataType(DataType.Date)]
        public DateTime datetimeCreacionEncuesta { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1 CON PUNTOSENCUESTA
        [Display(Name = "Puntos encuesta")]
        [EnumDataType(typeof(PuntosEncuesta))]
        public PuntosEncuesta puntosEncuesta { get; set; }


        //RELACION 1 a N CON PREGUNTA
        [Display(Name = "Preguntas Respondidas")]
        public ICollection<PreguntaRespondida> preguntasRespondidas { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
