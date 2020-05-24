using System;
using System.Web.UI;
using MSGRSrcoll_BLL;
using MSGRScroll_DAL;

namespace MSGRScroll.Usuarios
{
    public partial class EditarUsuario : System.Web.UI.Page
    {
        #region Eventos

        protected void Page_Load(object sender, EventArgs e)
        {
            if (sescionIniciada())
            {
                inicializarCapos();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnEditar_Click(object sender, ImageClickEventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = (Usuario)Session["Usuario"];


            usuario.usuario = txtUsuario.Text;
            usuario.password = txtContrasena.Text;
            usuario.nickName = txtNickname.Text;
            usuario.estadoTexto = txtEstado.Text;


            if (txtContrasena.Text.Equals(txtContrasena2.Text))
            {
                try
                {
                    usuarioBLL.editarUsuario(usuario);
                    Session["Usuario"] = usuario;
                    inicializarCapos();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Editar", "alert(' Usuario editado correctamene.')", true);
                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Editar", "alert('" + ex.Message + ".')", true);
                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Editar", "alert('La contraseña no coincide.')", true);
            }
        }


        #endregion

        #region Metodos

        public void inicializarCapos()
        {
            Usuario usuario = (Usuario)Session["Usuario"];

            txtUsuario.Text = usuario.usuario;
            txtContrasena.Text = usuario.password;
            txtContrasena2.Text = usuario.password;
            txtNickname.Text = usuario.nickName;
            txtEstado.Text = usuario.estadoTexto;
        }

        public bool sescionIniciada()
        {
            if (Session["Usuario"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
            
    }

        #endregion
}