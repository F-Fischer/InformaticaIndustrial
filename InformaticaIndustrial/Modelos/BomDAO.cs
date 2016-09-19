using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Globalization;
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
                //bom.registro_id = 1;
                bom.activo = 1;
                bom.semana_inicio = WeekOfTheYear(bom.fecha_inicio);
                bom.semana_fin = WeekOfTheYear(bom.fecha_fin);
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
                //bom.registro_id = rDAO.addRegistro();
                bom.registro_id = 1;
                bom.activo = 0;
                ((IObjectContextAdapter)context).ObjectContext.ApplyCurrentValues("boms", bom);
                context.SaveChanges();
            }
        }

        public void updateBom(int bomId, int hijoId, float cantidad, int um)
        {
            using (dbEntities context = new dbEntities())
            {
                var result = context.boms.SingleOrDefault(b => b.bom_id == bomId);

                if (result != null)
                {
                    result.articulo_hijo = hijoId;
                    result.cantidad = cantidad;
                    result.um_id = um;

                    context.boms.Attach(result);
                    context.Entry(result).State = System.Data.EntityState.Modified;
                    context.SaveChanges();
                }
            }
        }

        private int WeekOfTheYear(DateTime date)
        {
            var day = (int)CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(date);
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date.AddDays(4 - (day == 0 ? 7 : day)), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
}
