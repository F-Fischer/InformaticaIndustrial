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

        public System.Collections.IList buscarArticulos(string nombre)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from a in context.articuloes
                            from d in context.descripcions
                            where a.descripcion_id == d.descripcion_id
                            where d.descripcion_str.Contains(nombre)
                            select new  { d.descripcion_str, a.articulo_id };
                return query.ToList();
            }
        }

        //Explosion

        public List<int> getHijos(List<int> idPadres)
        {
            using (dbEntities context = new dbEntities())
            {
                var idHijos = context.boms
                    .Where(hijo => idPadres.Contains(hijo.articulo_padre))
                    .Select(hijo => hijo.articulo_hijo)
                    .ToList();
                if (idHijos.Count == 0)
                    return idPadres;
                else
                    return idPadres.Concat(getHijos(idHijos)).ToList();
            }
        }

        public System.Collections.IList Explosion(List<int> id)
        {
            using (dbEntities context = new dbEntities())
            {
                var idHijos = getHijos(id);
                var arts = context.articuloes
                    .Where(a => idHijos.Contains(a.articulo_id))
                    .Select(a => a);

                return arts.ToList();

            }
        }

        //Implosion

        public List<int> getPadres(List<int> idHijos)
        {
            using (dbEntities context = new dbEntities())
            {
                var idPadres = context.boms
                    .Where(padre => idHijos.Contains(padre.articulo_hijo))
                    .Select(padre => padre.articulo_padre)
                    .ToList();
                if (idPadres.Count == 0)
                    return idHijos;
                else
                    return getPadres(idPadres);
            }
        }

        public System.Collections.IList Implosion(List<int> id)
        {
            using (dbEntities context = new dbEntities())
            {
                var idPadres = getPadres(id);
                var arts = context.articuloes
                    .Where(a => idPadres.Contains(a.articulo_id))
                    .Select(a => a);

                return arts.ToList();

            }
        }
    }

}

