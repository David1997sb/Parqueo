//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamarinWebService
{
    using System;
    using System.Collections.Generic;
    
    public partial class factura
    {
        public int id_factura { get; set; }
        public int espacio_id_espacio { get; set; }
        public string usuario { get; set; }
        public decimal monto { get; set; }
    
        public virtual espacio espacio { get; set; }
        public virtual usuario usuario1 { get; set; }
    }
}