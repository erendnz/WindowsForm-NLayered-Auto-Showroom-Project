using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Model
    {
        public int ModelID { get; set; }
        public string ModelAdi { get; set; }
        public int ModelYili { get; set; }

        public int? MarkaID { get; set; }

        public Marka? Marka { get; set; }
        public ICollection<Araba>? Arabalar { get; set; }
    }
}
