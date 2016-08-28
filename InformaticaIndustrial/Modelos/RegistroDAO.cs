using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformaticaIndustrial.Modelos
{
    class RegistroDAO
    {
        public System.Collections.IList getRegistros()
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from r in context.registros select r;
                return query.ToList();
            }
        }

        public System.Collections.IList getRegistroById(int id)
        {
            using (dbEntities context = new dbEntities())
            {
                var query = from r in context.registros where r.registro_id == id select r;
                return query.ToList();
            }
        }

        public int addRegistro()
        {
            using (dbEntities context = new dbEntities())
            {
                registro reg = new registro();

                context.registros.Add(reg);
                context.SaveChanges();

                return reg.registro_id;
            }
        }
    }
}
