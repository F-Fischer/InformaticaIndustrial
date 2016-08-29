using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaIndustrial.Modelos
{
    class UnidadMedidaDAO
    {

        public System.Collections.IList getUnidadesDeMedida()
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from um in context.unidad_med select um;
                return query.ToList();
            }
        }

        public System.Collections.IList getDescripcionUM()
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from um in context.unidad_med
                            from d in context.descripcions
                            where um.descripcion_id == d.descripcion_id
                            select new { um.unidad_id, d.descripcion_str };
                return query.ToList();
            }

        }

        public System.Collections.IList getUnidadMedidaById(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from um in context.unidad_med where um.unidad_id == id select um;
                return query.ToList();
            }
        }

    }
}
