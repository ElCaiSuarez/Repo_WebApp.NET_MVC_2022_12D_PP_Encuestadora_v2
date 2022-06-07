using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class OpcionPregunta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OpcionPreguntaId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Display(Name = "Titulo opción")]
        [MaxLength(40, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string tituloOpcion { get; set; }

        [Display(Name = "Selección")]
        public bool opcionSeleccionada { get; set; }

        //RELACIONES CON OTRAS ENTIDADES
        //FK PREGUNTA
        public int PreguntaId { get; set; }
        public Pregunta Pregunta { get; set; }

        
    }
}
