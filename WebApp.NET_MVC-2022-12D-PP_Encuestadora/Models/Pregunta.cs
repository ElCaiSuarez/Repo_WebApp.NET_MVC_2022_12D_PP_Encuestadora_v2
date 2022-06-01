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

        [Required]
        [Display(Name = "Titulo pregunta")]
        public string tituloPregunta { get; set; }

        [Display(Name = "Tipo pregunta")]
        [EnumDataType(typeof(TipoPregunta))]
        public TipoPregunta tipoPregunta { get; set; }

        //COMO RELACIONAR LA DBSET DE OPCIONES DE CADA PREGUNTA???
        //COMO RELACIONAR EL TIPO DE PREGUNTA CON EL INPUT DEL FORMULARIO???
    }
}
