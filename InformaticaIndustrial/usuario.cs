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
    
    public partial class usuario
    {
        public usuario()
        {
            this.registros = new HashSet<registro>();
        }
    
        public int usuario_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string sector { get; set; }
        public int rol_id { get; set; }
        public int interno { get; set; }
        public string mail { get; set; }
        public Nullable<int> lenguaje_id { get; set; }
    
        public virtual lenguaje lenguaje { get; set; }
        public virtual ICollection<registro> registros { get; set; }
        public virtual rol rol { get; set; }
    }
}
