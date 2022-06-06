using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.NET_MVC_2022_12D_PP_Encuestadora.Models;

namespace WebApp.NET_MVC_2022_12D_PP_Encuestadora.Context
{
    public static class InicializacionDeDatos
    {
        public static void Inicializar(EncuestadoraDBContext context)
        {
            context.Database.EnsureCreated();
            using (var transaccion = context.Database.BeginTransaction())
            {
                try
                {
                    if (context.encuestas.Any())
                    {
                        return;
                    }
                    var nuevoCliente = new Cliente();
                    nuevoCliente.ClienteId = 1;
                    nuevoCliente.nombreCliente = "Alberto Perez";
                    nuevoCliente.mailCliente = "alberto.perez@gmail.com";
                    nuevoCliente.passwordCliente = "Acceso123";
                    nuevoCliente.empresaCliente = "Mercado No Libre";
                    nuevoCliente.cuitCliente = "20223334445";
                    nuevoCliente.domicilioCliente = "Av. Rivadavia 9900";
                    nuevoCliente.precioCliente = PrecioCliente.CLIENTE_GRATIS;
                    //nuevoCliente.encuestasCreadas
                    context.clientes.Add(nuevoCliente);

                    var nuevoUsuario = new Usuario();
                    nuevoUsuario.UsuarioId = 1;
                    nuevoUsuario.nombreUsuario = "Claudio Romero";
                    nuevoUsuario.mailUsuario = "claudio.romero@yahoo.com";
                    nuevoUsuario.passwordUsuario = "123Acceso";
                    nuevoUsuario.dniUsuario = "33444555";
                    nuevoUsuario.datetimeFechaNacimiento = DateTime.Now.Date;
                    nuevoUsuario.domicilioUsuario = "Av. Santa Fe 8800";
                    nuevoUsuario.preferenciaUsuario = PreferenciaUsuario.NOMBRE_PREFERENCIA_2;
                    //nuevoUsuario.encuestasRespondidas
                    context.usuarios.Add(nuevoUsuario);

                    var nuevaEncuesta = new Encuesta();
                    nuevaEncuesta.EncuestaId = 1;
                    nuevaEncuesta.tituloEncuesta = "Encuesta Mercado No Libre";
                    nuevaEncuesta.datetimeCreacionEncuesta = DateTime.Now.Date;
                    nuevaEncuesta.datetimeVencimientoEncuesta = nuevaEncuesta.datetimeCreacionEncuesta.AddDays(7);
                    nuevaEncuesta.puntosEncuesta = PuntosEncuesta.ENCUESTA_GRATIS;
                    var nuevaPregunta = new Pregunta();
                    nuevaPregunta.PreguntaId = 1;
                    nuevaPregunta.tituloPregunta = "¿Usted es usuario habitual de Mercado No Libre?";
                    nuevaPregunta.tipoPregunta = TipoPregunta.OPTGROUP;
                    //nuevaEncuesta.preguntas
                    context.encuestas.Add(nuevaEncuesta);

                    context.SaveChanges();

                    var cliente = context.clientes.First();
                    var usuario = context.usuarios.First();
                    var encuesta = context.encuestas.First();

                    var relacionEncuestaCliente = new EncuestasCliente();
                    relacionEncuestaCliente.EncuestasClienteId = 1;
                    relacionEncuestaCliente.EncuestaId = encuesta.EncuestaId;
                    relacionEncuestaCliente.ClienteId = cliente.ClienteId;

                    var relacionEncuestaUsuario = new EncuestasUsuario();
                    relacionEncuestaUsuario.EncuestasUsuarioId = 1;
                    relacionEncuestaUsuario.EncuestaId = encuesta.EncuestaId;
                    relacionEncuestaUsuario.UsuarioId = usuario.UsuarioId;

                    context.SaveChanges();





                }
                catch
                {
                    transaccion.Rollback();
                }
            }
        }
    }
}
