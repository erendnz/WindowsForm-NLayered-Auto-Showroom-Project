using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaseManager<TEntity> : ICRUD<TEntity> where TEntity : class
    {
        GaleriContext _context;
        DbSet<TEntity> _table;   
        public BaseManager()
        {
            _context = new GaleriContext();
            _table = _context.Set<TEntity>();
        }

        public TEntity Bul(int id)
        {
           var entity= _table.Find(id);
            _context.Entry(entity).State = EntityState.Detached;
            return entity;
                
         }

        public void Ekle(TEntity entity)
        {
            _table.Add(entity);
            _context.SaveChanges();
        }

        public void Guncelle(TEntity entity)
        {
           _context.Entry(entity).State= EntityState.Modified;
            _context.SaveChanges();
        }

        public void Sil(int id)
        {
            _table.Remove(Bul(id));
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> Tumu()
        {
            return _table;
        }

        public IEnumerable<TEntity> Tumu(Func<TEntity, bool> predicate)
        {
            return _table.Where(predicate);
        }
    }
}
