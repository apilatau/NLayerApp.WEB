using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ComNotHis.DAL.Entities;
using ComNotHis.DAL.Interface;
using ComNotHis.DAL.EF;

namespace ComNotHis.DAL.Repositories
{
    public class TakeOffStatusRepository : IRepository<TakeOffStatus>
    {
        private CommentsContext db;

        public TakeOffStatusRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<TakeOffStatus> GetAll()
        {
            return db.TakeOffStatuss;
        }

        public TakeOffStatus Get(int id)
        {
            return db.TakeOffStatuss.Find(id);
        }

        public void Create(TakeOffStatus tfst)
        {
            db.TakeOffStatuss.Add(tfst);
        }

        public void Update(TakeOffStatus tfst)
        {
            db.Entry(tfst).State = EntityState.Modified;
        }

        public IEnumerable<TakeOffStatus> Find(Func<TakeOffStatus, Boolean> predicate)
        {
            return db.TakeOffStatuss.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            TakeOffStatus tfst = db.TakeOffStatuss.Find(id);
            if (tfst != null)
                db.TakeOffStatuss.Remove(tfst);
        }
    }
}
