using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaIndustrial.Modelos
{
    class TipoArticuloDAO
    {
        public void addTipoArticulo(string descripcion)
        {
            DescripcionDAO dDAO = new DescripcionDAO();
            tipo_articulo tArt = new tipo_articulo();
            tArt.descripcion_id = dDAO.addDescripcion(descripcion);

            using (dbEntities context = new dbEntities())
            {
                context.tipo_articulo.Add(tArt);
                context.SaveChanges();
            }
        }

        public System.Collections.IList getTipoArticulos()
        {
            using (dbEntities context = new dbEntities())
            {
                DescripcionDAO dDAO = new DescripcionDAO();
                var query = from ta in context.tipo_articulo
                            from d in context.descripcions
                            where ta.descripcion_id == d.descripcion_id
                            select new { ta.tipo_id, d.descripcion_str };
                return query.ToList();                            
            }
        }

        public System.Collections.IList getTipoArticulosById(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                DescripcionDAO dDAO = new DescripcionDAO();
                var query = from ta in context.tipo_articulo
                            from d in context.descripcions
                            where ta.descripcion_id == d.descripcion_id
                            where ta.tipo_id == id
                            select new { ta.tipo_id, d.descripcion_str };
                return query.ToList();
            }
        }
    }
}
