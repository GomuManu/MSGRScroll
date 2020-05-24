using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MSGRSrcoll_BLL;
using MSGRScroll_DAL;

namespace MSGRScroll
{
    public partial class Login : System.Web.UI.Page
    {

        #region Eventos 
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIngresar_Click(object sender, ImageClickEventArgs e)
        {
            if (accesoValido())
            {
                Response.Redirect("Vistas/PaginaPrincipal.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesión", "alert('Usuario y contraseña son incorrectos.')", true);
            }
        }

        #endregion

        #region Metodos

        public bool accesoValido()
        {

            bool acceso = false;
            UsuarioBLL usaurioBLL = new UsuarioBLL();

            Usuario usuario = usaurioBLL.consultarUsuario(txtUsuario.Text, txtContrasena.Text);

            if (usuario != null)
            {
                Session["Usuario"] = usuario;
                acceso = true;
            }

            return acceso;

        }

        #endregion

    }
}