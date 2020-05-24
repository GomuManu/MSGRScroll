using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSGRScroll_DAL;

namespace MSGRSrcoll_BLL
{
    class MensajeBLL
    {
        public IEnumerable<Mensaje> consultarSolicitudesPorChat(int idChat)
        {
            MensajeDAL mensajeDAL = new MensajeDAL();
            return mensajeDAL.consultarSolicitudesPorChat(idChat);
        }

        public IEnumerable<Mensaje> consultarSolicitudesPorGrupo(int idGrupo)
        {
            MensajeDAL mensajeDAL = new MensajeDAL();
            return mensajeDAL.consultarSolicitudesPorGrupo(idGrupo);
        }

        public void enviarMensaje(Mensaje mensaje)
        {
            MensajeDAL mensajeDAL = new MensajeDAL();
            mensajeDAL.enviarMensaje(mensaje);
        }

        public void eliminarMensaje(Mensaje mensaje)
        {
            MensajeDAL mensajeDAL = new MensajeDAL();
            mensajeDAL.eliminarMensaje(mensaje);
        }
    }
}
