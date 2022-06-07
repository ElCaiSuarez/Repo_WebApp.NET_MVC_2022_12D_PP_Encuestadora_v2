using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models
{
    public class EncuestasUsuarios
    {
        /*
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EncuestasUsuariosId { get; set; }
        */

        public int EncuestaId { get; set; }
        public Encuesta Encuesta { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

       

    }
}
