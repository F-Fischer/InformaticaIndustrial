using System;
using System.Collections.Generic;
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
                var query = from b in context.boms select b;
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

        public void addBom(int articuloPadre, int articuloHijo, float cantidad, DateTime? fechaFin, int unidadMedida)
        {
            using (dbEntities context = new dbEntities())
            {
                RegistroDAO rDAO = new RegistroDAO();
                bom bom = new bom();

                bom.articulo_padre = articuloPadre;
                bom.articulo_hijo = articuloHijo;
                bom.cantidad = cantidad;
                if (fechaFin != null) { bom.fecha_fin = fechaFin; }
                bom.um_id = unidadMedida;
                bom.registro_id = rDAO.addRegistro();
                context.boms.Add(bom);
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

    }
}
