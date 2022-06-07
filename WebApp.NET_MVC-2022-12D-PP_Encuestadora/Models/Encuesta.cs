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

<<<<<<< HEAD
        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo encuesta")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
=======
        [Required]
        [Display(Name = "Titulo encuestA")]
>>>>>>> a098841ff0958a3246f9e39e20de949086c4a7cc
        public string tituloEncuesta { get; set; }

        [Display(Name = "Fecha creación")]
        [DataType(DataType.Date)]
        public DateTime datetimeCreacionEncuesta { get; set; }

        [Display(Name = "Fecha vencimiento")]
        [DataType(DataType.Date)]
        public DateTime datetimeVencimientoEncuesta { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //RELACION 1 a 1
        [Display(Name = "Puntos encuesta")]
        [EnumDataType(typeof(PuntosEncuesta))]
        public PuntosEncuesta puntosEncuesta { get; set; }

        //RELACION 1 a N FALTA LA FOREIGN KEY EN PREGUNTA
        [Display(Name = "Preguntas")]
        public IEnumerable<Pregunta> preguntas { get; set; }



    }
}
