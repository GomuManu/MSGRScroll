//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MSGRScroll_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mensaje
    {
        public int ID_Mensaje { get; set; }
        public int ID_Usuario { get; set; }
        public string mensaje1 { get; set; }
        public System.DateTime fechaEnvio { get; set; }
        public Nullable<int> ID_Grupo { get; set; }
        public Nullable<int> ID_Chat { get; set; }
    
        public virtual Chat Chat { get; set; }
        public virtual Grupo Grupo { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
