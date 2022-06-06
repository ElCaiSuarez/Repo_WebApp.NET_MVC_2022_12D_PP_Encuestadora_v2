using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Context
{
    public class EncuestadoraDBContext : DbContext
    {
        public EncuestadoraDBContext(DbContextOptions<EncuestadoraDBContext> options) : base(options)
        {
        }
        public DbSet<Cliente> clientes { get; set; }

        public DbSet<Usuario> usuarios { get; set; }

        public DbSet<Encuesta> encuestas { get; set; }

        public DbSet<Pregunta> preguntas { get; set; }

        public DbSet<OpcionPregunta> opciones { get; set; }

        public DbSet<EncuestasCliente> encuestasCliente { get; set; }

        public DbSet<EncuestasUsuario> encuestasUsuario { get; set; }
        

    }
}
