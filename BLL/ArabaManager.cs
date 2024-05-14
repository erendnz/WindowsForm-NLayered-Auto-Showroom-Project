using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ArabaManager:BaseManager<Araba>
    {
        public IEnumerable<Araba> FiyatAraliginaGoreListele(double min, double max)
        {
            return Tumu(x => x.Fiyat > min && x.Fiyat < max);
        }

        public IEnumerable<Araba> FiyataGoreSiraliGetir()
        {
            return Tumu().OrderBy(x=>x.Fiyat);
        }
    } 
}
