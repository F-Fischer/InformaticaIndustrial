using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaIndustrial.Modelos
{
    class DescripcionDAO
    {
        public System.Collections.IList getDescripciones()
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from d in context.descripcions select d;
                return query.ToList();
            }
        }

        public System.Collections.IList getDescripcionById(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from d in context.descripcions where d.descripcion_id == id select d;
                return query.ToList();
            }
        }
    }
}
