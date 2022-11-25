using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SipsisBLL.Repsitory.Base
{
    public class BaseRepository<T> where T : class
    {
        private SiparisDBEntities db;
        protected DbSet<T> table;

        public BaseRepository()
        {
            db = new SiparisDBEntities();
            table = db.Set<T>();
        }

        public int Save()
        {
            return db.SaveChanges();
        }
                     
        public virtual void Insert(T entity)
        {
            table.Add(entity);
        }
        public List<T> GetAll()
        {
            return table.ToList();
        }
        public T Find(long ID)
        {
            return table.Find(ID);  
        }
    } 
}
