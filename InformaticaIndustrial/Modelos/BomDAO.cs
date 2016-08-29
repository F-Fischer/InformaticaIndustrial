using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaIndustrial.Modelos
{
    class BomDAO
    {
        public System.Collections.IList getBoms()
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from b in context.boms
                            where b.fecha_fin == null
                            select b;
                return query.ToList();
            }
        }

        public System.Collections.IList getBomsById(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from b in context.boms where b.bom_id == id select b;
                return query.ToList();
            }
        }

        public void addBom(bom bom)
        {
            using (dbEntities context = new dbEntities())
            {
                RegistroDAO rDAO = new RegistroDAO();
                bom.registro_id = rDAO.addRegistro();
                context.boms.Add(bom);
                context.SaveChanges();
            }
        }

        public void deleteBom(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                RegistroDAO rDAO = new RegistroDAO();
                bom bom = context.boms.First(b => b.bom_id == id);
                bom.fecha_fin = System.DateTime.Now;
                bom.registro_id = rDAO.addRegistro();
                ((IObjectContextAdapter)context).ObjectContext.ApplyCurrentValues("boms", bom);
                context.SaveChanges();
            }
        }

        public void addArticulo(int descripcionId, float precioStd, string descripcion, int tipoArticulo, int um, int registro)
        {
            using (dbEntities context = new dbEntities())
            {
                articulo art = new articulo();
                art.descripcion_id = descripcionId;
                art.precio_std = precioStd;
                art.descripcion = descripcion;
                art.tipo_articulo = tipoArticulo;
                art.unidad_med = um;
                art.registro_id = registro;
                context.articuloes.Add(art);
                context.SaveChanges();
            }
        }

        public System.Collections.IList getRelacionesPadre(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from b in context.boms where b.articulo_hijo == id select b.articulo_padre;
                return query.ToArray<int>();
            }
        }

        public System.Collections.IList getRelacionesHijo(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from b in context.boms where b.articulo_padre == id select b.articulo_hijo;
                return query.ToArray<int>();
            }
        }

    }
}
