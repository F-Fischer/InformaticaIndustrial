//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InformaticaIndustrial.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class art_sustituto
    {
        public int art_sustituto_id { get; set; }
        public int id_principal { get; set; }
        public int id_sustituto { get; set; }
        public float cantidad { get; set; }
        public int id_um { get; set; }
    
        public virtual articulo articulo { get; set; }
        public virtual articulo articulo1 { get; set; }
        public virtual unidad_med unidad_med { get; set; }
    }
}
