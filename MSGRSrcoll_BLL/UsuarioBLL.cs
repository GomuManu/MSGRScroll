using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MSGRScroll_DAL;

namespace MSGRSrcoll_BLL
{
    public class UsuarioBLL
    {
        public Usuario consultarUsuario(string nombreUsuario, string password)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.consultarUsuario(nombreUsuario, password);
        }

        public Usuario consultarUsuarioPorNombreSuario(string nombreUsuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.consultarUsuarioPorNombreSuario(nombreUsuario);
        }

        public IEnumerable<Usuario> consultarAmigosUsuario1(int idUsuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.consultarAmigosUsuario1(idUsuario);
        }

        public Usuario consultarUsuarioPorNumeroDeAmigo(string numeroDeAmigo)
        {

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.consultarUsuarioPorNumeroDeAmigo(numeroDeAmigo);
        }

        public IEnumerable<Usuario> consultarAmigosUsuario2(int idUsuario)
        {

            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.consultarAmigosUsuario2(idUsuario);

        }
        public void agregarUsuario(Usuario usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.agregarUsuario(usuario);
        }

        public void editarUsuario(Usuario usuario)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.editarUsuario(usuario);
        }

        public IEnumerable<Usuario> llenarListaDeAmigos(int idUsuario)
        {
            IEnumerable<Usuario> lista1 = this.consultarAmigosUsuario1(idUsuario);
            IEnumerable<Usuario> lista2 = this.consultarAmigosUsuario2(idUsuario);

            return (lista1 ?? Enumerable.Empty<Usuario>()).Concat(lista2 ?? Enumerable.Empty<Usuario>()).ToList();
        }
    }
}
