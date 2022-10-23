using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        int Ekle(T p);
        int Sil(T p);

        int Guncelle(T p);

        List<T> Liste();

    }
}
