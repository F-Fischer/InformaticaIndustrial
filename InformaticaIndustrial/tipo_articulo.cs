//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InformaticaIndustrial
{
    using System;
    using System.Collections.Generic;
    
    public partial class tipo_articulo
    {
        public tipo_articulo()
        {
            this.articuloes = new HashSet<articulo>();
        }
    
        public int tipo_id { get; set; }
        public int descripcion_id { get; set; }
    
        public virtual ICollection<articulo> articuloes { get; set; }
        public virtual descripcion descripcion { get; set; }
    }
}