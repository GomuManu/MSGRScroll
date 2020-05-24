using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MSGRScroll_DAL;
using MSGRSrcoll_BLL;

namespace MSGRScroll.Usuarios
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, ImageClickEventArgs e)
        {
            agregarUsuario();
            Response.Redirect("~/Login.aspx");
        }

        #endregion

        #region Metodos

        public void agregarUsuario()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();

            usuario.usuario = txtUsuario.Text;
            usuario.password = txtContrasena.Text;
            usuario.nickName = txtNickname.Text;
            usuario.numeroAmigo = generarNumeroAmigo(usuario.usuario);
            usuario.estado = 1;
            usuario.estadoTexto = "Hola! Soy nuevo!";


            if (txtContrasena.Text.Equals(txtContrasena2.Text))
            {
                try
                {
                    usuarioBLL.agregarUsuario(usuario);
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert(' Usuario capturado correctamene.')", true);
                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('" + ex.Message + ".')", true);
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Alta", "alert('La contraseña no coincide.')", true);
            }
        }

        public string generarNumeroAmigo(String usuario)
        {
            var rand = new Random();
            return (((usuario.ToUpper()).Substring(0,3)) + "#" + rand.Next(100,999));
        }

        #endregion


    }
}