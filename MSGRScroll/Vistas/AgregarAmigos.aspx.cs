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
    public partial class agregarAmigos : System.Web.UI.Page
    {
        #region Eventos
        protected void Page_Load(object sender, EventArgs e)
        {
            if (sescionIniciada())
            {

            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void btnAgregar_Click(object sender, ImageClickEventArgs e)
        {
            SolicitudDeAmistadBLL solicitudDeAmistadBLL = new SolicitudDeAmistadBLL();
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            Usuario usuarioSesion = (Usuario)Session["Usuario"];
            Usuario usuarioReceptor = usuarioBLL.consultarUsuarioPorNumeroDeAmigo(txtNumeroAmigo.Text);

            if (usuarioReceptor != null)
            {
                solicitudDeAmistadBLL.enviarSolicitud(usuarioSesion.ID_Usuario,usuarioReceptor.ID_Usuario);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesión", "alert('Solicitud enviada')", true);
            }
            else{
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesión", "alert('El número de amigo no existe')", true);
            }  
        }

        #endregion

        #region Metodos

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

        #endregion
    }
}