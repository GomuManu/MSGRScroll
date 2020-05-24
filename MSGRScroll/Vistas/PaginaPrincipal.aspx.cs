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

    #region  Eventos
    public partial class Amigos : System.Web.UI.Page
    {
        Chat chatAbierto;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (sescionIniciada())
            {
                this.chatAbierto = null;
                llenarListaAmigos();
               llenarListaSolicitudes();  
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SolicitudDeAmistadBLL solicitudDeAmistadBLL = new SolicitudDeAmistadBLL();

            }
            catch(Exception ex)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Sesión", "alert('" + ex.Message + ".')", true);
            }
        }

        protected void btnRechazar_Click(object sender, EventArgs e)
        {

        }

        protected void OnComandAbrirChat(object sender, DataListCommandEventArgs e)
        {
            if (e.CommandName == "Historial")
            {
                amigosList.SelectedIndex = e.Item.ItemIndex;
                Usuario usuarioSeleccionado = (Usuario)amigosList.SelectedItem.DataItem;
            }

        }


        #endregion

        #region Metodos



        public void llenarListaAmigos()
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuarioSesion = (Usuario)Session["Usuario"];

            amigosList.DataSource = usuarioBLL.llenarListaDeAmigos(usuarioSesion.ID_Usuario).ToList();
            amigosList.DataBind();
        }

        public void llenarListaSolicitudes()
        {
            SolicitudDeAmistadBLL solicitudDeAmistadBLL = new SolicitudDeAmistadBLL();
            Usuario usuarioSesion = (Usuario)Session["Usuario"];
            IEnumerable<Usuario> lista = solicitudDeAmistadBLL.consuSolicitudPorUsuarioReceptor(usuarioSesion.ID_Usuario);

            solicitudesList.DataSource = lista.ToList();
            solicitudesList.DataBind();
        }

        public void actualizarChat()
        {

        }
       /*
        public bool compararMesanjes()
        {

            if (this.chatAbierto != null)
            {
            }
        }
        */
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