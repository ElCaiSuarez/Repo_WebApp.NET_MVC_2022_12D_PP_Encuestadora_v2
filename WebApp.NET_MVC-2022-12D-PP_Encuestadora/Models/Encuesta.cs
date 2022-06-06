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

        [Required]
        [Display(Name = "Titulo encuestA")]
        public string tituloEncuesta { get; set; }

        [Display(Name = "Fecha creación")]
        public DateTime datetimeCreacionEncuesta { get; set; }

        [Display(Name = "Fecha vencimiento")]
        public DateTime datetimeVencimientoEncuesta { get; set; }

        [Display(Name = "Puntos encuesta")]
        [EnumDataType(typeof(PuntosEncuesta))]
        public PuntosEncuesta puntosEncuesta { get; set; }

        //COMO RELACIONAR LA DBSET DE PREGUNTAS DE CADA ENCUESTA???
        
    }
}
