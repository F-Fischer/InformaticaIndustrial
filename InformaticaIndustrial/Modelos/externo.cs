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
    
    public partial class externo
    {
        public int ext_id { get; set; }
        public int tipo_ext_id { get; set; }
        public int descripcion_id { get; set; }
        public string CUIT { get; set; }
        public int direccion_id { get; set; }
        public int direccion_ent_id { get; set; }
        public int direccion_fac_id { get; set; }
        public string nac_ext { get; set; }
    
        public virtual descripcion descripcion { get; set; }
        public virtual tipo_externos tipo_externos { get; set; }
    }
}
