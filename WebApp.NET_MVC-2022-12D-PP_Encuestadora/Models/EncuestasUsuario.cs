using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class EncuestasUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EncuestasUsuarioId { get; set; }

        [ForeignKey(nameof(Encuesta))]
        public int EncuestaId { get; set; }

        [ForeignKey(nameof(Usuario))]
        public int UsuarioId { get; set; }
    }
}
