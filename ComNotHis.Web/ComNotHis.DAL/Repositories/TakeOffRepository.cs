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
    public class TakeOffRepository : IRepository<TakeOff>
    {
        private CommentsContext db;

        public TakeOffRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<TakeOff> GetAll()
        {
            return db.TakeOffs.Include(rc => rc.Notes.Select(n => n.RequestForCorrections)).Include(ad=>ad.Additionals).Include(tfst=>tfst.TakeOffStatus);
            //подключается запрос со всеми запросами на исправления
        }

        public TakeOff Get(int id)
        {
            return db.TakeOffs.Find(id);
        }

        public void Create(TakeOff tf)
        {
            db.TakeOffs.Add(tf);
        }

        public void Update(TakeOff tf)
        {
            db.Entry(tf).State = EntityState.Modified;
        }
        public IEnumerable<TakeOff> Find(Func<TakeOff, Boolean> predicate)
        {
            return db.TakeOffs.Include(rc => rc.Notes.Select(n => n.RequestForCorrections))
                .Include(ad => ad.Additionals).Include(tfst => tfst.TakeOffStatus).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            TakeOff tf = db.TakeOffs.Find(id);
            if (tf != null)
                db.TakeOffs.Remove(tf);
        }
    }
}
