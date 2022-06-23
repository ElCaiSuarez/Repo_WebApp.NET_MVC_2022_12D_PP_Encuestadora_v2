using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class PreguntaRespondida

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PreguntaRespondidaId { get; set; }

        public int PreguntaId { get; set; }

        public Pregunta Pregunta { get; set; }
        public string Respuesta { get; set; }


        //FK ENCUESTA
        public int EncuestaRespondidaId { get; set; }

        public EncuestaRespondida encuestaRespondida { get; set; }
    }
}
