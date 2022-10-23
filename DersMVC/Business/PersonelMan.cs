using DataAccess;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class PersonelMan
    {
        Repository<Personel> persrepo = new Repository<Personel>();

        public List<Personel> GetAll()
        {
            return persrepo.Liste();
        }

        public int PersonelEkle(Personel pers)
        {
            if (pers.personel_ad.Length > 10)
            {
                return -1;
                
            }
            return persrepo.Ekle(pers);
        }

        public int PersonelSil(Personel pers)
        {
            if(pers.personel_id == 5)
            {
                return persrepo.Sil(pers);
            }
            return -1;
        }

        public int PersonelUpdate(Personel pers)
        {
            if(pers.personel_id == 2)
            {
                return persrepo.Guncelle(pers);
            }
            return -1;
        }


    }
}
