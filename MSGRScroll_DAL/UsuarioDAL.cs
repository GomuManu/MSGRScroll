using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSGRScroll_DAL
{
    public class UsuarioDAL
    {

        SMRGScrollEntities modelo;

        public UsuarioDAL()
        {
            modelo = new SMRGScrollEntities();
        }

        public Usuario consultarUsuario(string nombreUsuario, string password)
        {
            var usuario = (from mUsuario in modelo.Usuario
                           where mUsuario.usuario == nombreUsuario && mUsuario.password == password
                           select mUsuario).FirstOrDefault();
            return usuario;
        }

        public IEnumerable<Usuario> consultarAmigosUsuario1(int idUsuario)
        {
            var usuario = from mUsuario in modelo.Chat
                           where mUsuario.Usuario1 == idUsuario 
                           select mUsuario.UsuarioN2;
            return usuario;
        }

        public IEnumerable<Usuario> consultarAmigosUsuario2(int idUsuario)
        {
            var usuario = from mUsuario in modelo.Chat
                          where mUsuario.Usuario2 == idUsuario
                          select mUsuario.UsuarioN1;
            return usuario;
        }

        public IEnumerable<Usuario> consultarSolicitudesDeAmistad(int idUsuario)
        {
            var usuario = from mUsuario in modelo.SolicitudDeAmistad
                          where mUsuario.uReceptor == idUsuario
                          select mUsuario.UsuarioEmisor;
            return usuario;
        }

        public Usuario consultarUsuarioPorNombreSuario(string nombreUsuario)
        {
            var usuario = (from mUsuario in modelo.Usuario
                           where mUsuario.usuario == nombreUsuario
                           select mUsuario).FirstOrDefault();
            return usuario;
        }

        public Usuario consultarUsuarioPorNumeroDeAmigo(string numeroDeAmigo)
        {
            var usuario = (from mUsuario in modelo.Usuario
                           where mUsuario.numeroAmigo == numeroDeAmigo
                           select mUsuario).FirstOrDefault();
            return usuario;
        }

        public void editarUsuario(Usuario pUsuario)
        {
            var usuario = (from mUsuario in modelo.Usuario
                             where mUsuario.ID_Usuario == pUsuario.ID_Usuario
                             select mUsuario).FirstOrDefault();

            usuario.nickName = pUsuario.nickName;
            usuario.password = pUsuario.password;
            usuario.estadoTexto = pUsuario.estadoTexto;
            usuario.usuario = pUsuario.usuario;

            modelo.SaveChanges();
        }

        public void agregarUsuario(Usuario usuario)
        {
            modelo.Usuario.Add(usuario);
            modelo.SaveChanges();
        }

    }
}
