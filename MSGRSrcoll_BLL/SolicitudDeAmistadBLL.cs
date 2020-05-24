using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSGRScroll_DAL;

namespace MSGRSrcoll_BLL
{
    public class SolicitudDeAmistadBLL
    {

        public IEnumerable<Usuario> consuSolicitudPorUsuarioReceptor(int usuarioReceptor)
        {
            SolicitudDeAmistadDAL solicitudDeAmistadDAL = new SolicitudDeAmistadDAL();
            return solicitudDeAmistadDAL.consultarSolicitudesPorUsuarioReceptor(usuarioReceptor);
        }

        public void enviarSolicitud(int idUsuarioEmisor, int idUSaurioRecepror)
        {
            SolicitudDeAmistadDAL solicitudDeAmistadDAL = new SolicitudDeAmistadDAL();
            SolicitudDeAmistad solicitud = new SolicitudDeAmistad();

            solicitud.uEmisor = idUsuarioEmisor;
            solicitud.uReceptor = idUSaurioRecepror;

            solicitudDeAmistadDAL.enviarSolicitud(solicitud);
        }

        public void eliminarSolicitud(SolicitudDeAmistad solicitud)
        {
            SolicitudDeAmistadDAL solicitudDeAmistadDAL = new SolicitudDeAmistadDAL();
            solicitudDeAmistadDAL.eliminarSolicitud(solicitud);
        }
    }
}
