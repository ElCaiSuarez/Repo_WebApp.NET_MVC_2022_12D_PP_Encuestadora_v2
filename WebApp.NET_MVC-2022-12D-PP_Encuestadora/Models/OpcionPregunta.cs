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

        [Required]
        [Display(Name = "Titulo opción")]
        public string tituloOpcion { get; set; }

        [Display(Name = "Selección")]
        public bool opcionSeleccionada { get; set; }

        //COMO RELACIONAR Y GUARDAR A LOS USUARIOS CON SUS OPCIONES SELECCIONADAS
    }
}
