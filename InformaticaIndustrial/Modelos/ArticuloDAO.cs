using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaIndustrial.Modelos
{
    class ArticuloDAO
    {
        public System.Collections.IList getArticulos()
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from a in context.articuloes select a;
                return query.ToList();
            }
        }

        public System.Collections.IList getArticuloDescripcion()
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from a in context.articuloes
                            from d in context.descripcions
                            where a.descripcion_id == d.descripcion_id
                            select new { a.articulo_id, d.descripcion_str };
                return query.ToList();
            }

        }

        public System.Collections.IList getArticuloDescripcionById(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from a in context.articuloes
                            from d in context.descripcions
                            where a.descripcion_id == d.descripcion_id
                            where a.articulo_id == id
                            select new { d.descripcion_str };
                return query.ToList();
            }

        }

        public System.Collections.IList getArticuloById(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from a in context.articuloes where a.articulo_id == id select a;
                return query.ToList();
            }
        }

        public void addArticulo( float precioStd, string descripcion, int tipoArticulo, int um)
        {
            using (dbEntities context = new dbEntities())
            {
                articulo art = new articulo();
                DescripcionDAO dDAO = new DescripcionDAO();
                RegistroDAO rDAO = new RegistroDAO();
                art.descripcion_id = dDAO.addDescripcion(descripcion);
                art.precio_std = precioStd;
                art.descripcion = descripcion;
                art.tipo_articulo = tipoArticulo;
                art.unidad_med = um;
                art.registro_id = rDAO.addRegistro();
                context.articuloes.Add(art);
                context.SaveChanges();
            }
        }

        public void updateArticulo(articulo art)
        {
            using (dbEntities context = new dbEntities())
            {
                articulo articulo = context.articuloes.First(a => a.articulo_id == art.articulo_id);

                context.articuloes.Attach(context.articuloes.Single(a => a.articulo_id == art.articulo_id));
                ((IObjectContextAdapter)context).ObjectContext.ApplyCurrentValues("articulos", art);
                context.SaveChanges();
            }
        }

        public void deleteArticulo(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                articulo art = context.articuloes.First(a => a.articulo_id == id);
                context.articuloes.Remove(art);
                context.SaveChanges();
            }

        }

        public System.Collections.IList mostrarPadres(int id)
        {
            BomDAO bDAO = new BomDAO();

            System.Collections.IList IdPadres = bDAO.getRelacionesPadre(id);
            System.Collections.IList articulosPadre = new List<articulo>();

            using (dbEntities context = new dbEntities())
            {

                foreach (int p in IdPadres)
                {
                    var art = from a in context.articuloes where a.articulo_id == p select a;
                    articulosPadre.Add(art);
                }
                return articulosPadre;
            }   
        }

        public System.Collections.IList mostrarHijos(int id)
        {
            BomDAO bDAO = new BomDAO();

            System.Collections.IList idHijos = bDAO.getRelacionesHijo(id);
            System.Collections.IList articulosHijo = new List<articulo>();

            using (dbEntities context = new dbEntities())
            {
                foreach (int p in idHijos)
                {
                    var art = from a in context.articuloes where a.articulo_id == p select a;
                    articulosHijo.Add((articulo)art);
                }
                return articulosHijo;
            }
        } 
    }

}

