using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Personel
    {
        [Key]
        public int personel_id { get; set; }
        [StringLength (50)]
        public string personel_ad { get; set; }
        [StringLength(50)]
        public string personel_soyad { get; set; }
    }
}
