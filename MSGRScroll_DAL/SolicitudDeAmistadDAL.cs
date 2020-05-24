using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGRScroll_DAL
{
    public class SolicitudDeAmistadDAL
    {

        SMRGScrollEntities modelo;

        public SolicitudDeAmistadDAL()
        {
            modelo = new SMRGScrollEntities();
        }

        public IEnumerable<Usuario> consultarSolicitudesPorUsuarioReceptor(int idUsuarioReceptor)
        {
            var solicitudes = from mSolicitud in modelo.SolicitudDeAmistad
                             where mSolicitud.uReceptor == idUsuarioReceptor
                             select mSolicitud.UsuarioEmisor;
            return solicitudes;
        }

        public void enviarSolicitud(SolicitudDeAmistad solicitud)
        {
            modelo.SolicitudDeAmistad.Add(solicitud);
            modelo.SaveChanges();
        }

        public void eliminarSolicitud(SolicitudDeAmistad solicitud)
        {
            modelo.SolicitudDeAmistad.Add(solicitud);
            modelo.SaveChanges();
        }
    }
}
