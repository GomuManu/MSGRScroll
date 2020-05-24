using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGRScroll_DAL
{
    public class MensajeDAL
    {
        SMRGScrollEntities modelo;

        public MensajeDAL()
        {
            modelo = new SMRGScrollEntities();
        }

        public IEnumerable<Mensaje> consultarSolicitudesPorChat(int idChat)
        {
            var mensajes = from mMensaje in modelo.Mensaje
                              where mMensaje.ID_Chat == idChat
                              select mMensaje;
            return mensajes;
        }

        public IEnumerable<Mensaje> consultarSolicitudesPorGrupo(int idGrupo)
        {
            var mensajes = from mMensaje in modelo.Mensaje
                           where mMensaje.ID_Grupo == idGrupo
                           select mMensaje;
            return mensajes;
        }

        public void enviarMensaje(Mensaje mensaje)
        {
            modelo.Mensaje.Add(mensaje);
            modelo.SaveChanges();
        }

        public void eliminarMensaje(Mensaje mensaje)
        {
            modelo.Mensaje.Add(mensaje);
            modelo.SaveChanges();
        }
    }
}
