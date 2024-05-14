using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        void Ekle(TEntity entity);
        void Guncelle(TEntity entity);
        void Sil(int id);
        IEnumerable<TEntity> Tumu();
        IEnumerable<TEntity> Tumu(Func<TEntity,bool> predicate);
        TEntity Bul(int id);

    }
}
