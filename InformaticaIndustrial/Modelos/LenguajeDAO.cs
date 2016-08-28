using InformaticaIndustrial.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaIndustrial.Modelos
{
    class LenguajeDAO
    {

        public void guardarLenguaje(lenguaje lenguaje)
        {
            using (var context = new dbEntities())
            {
                context.lenguajes.Add(lenguaje);
                context.SaveChanges();
            }
                
        }

        public System.Collections.IList listarLenguajes()
        {      
            using (dbEntities context = new dbEntities())
            {
                var query = from c in context.lenguajes select c;
                return query.ToList();
            }              
        }

        public void borrarLenguaje(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                lenguaje leng = context.lenguajes.First(l => l.lenguaje_id == id);
                context.lenguajes.Remove(leng);
                context.SaveChanges();

            }
        }

    }
}
