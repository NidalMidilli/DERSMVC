using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> obj;

        public Repository()
        {
            obj = c.Set<T>();
        }
        public int Ekle(T p)
        {
            obj.Add(p);
            return c.SaveChanges();
        }

        public int Guncelle(T p)
        {
            obj.Update(p);
            return c.SaveChanges();
        }

        public List<T> Liste()
        {
            return obj.ToList();
        }

        public int Sil(T p)
        {
            obj.Remove(p);
            return c.SaveChanges();
        }
    }
}
