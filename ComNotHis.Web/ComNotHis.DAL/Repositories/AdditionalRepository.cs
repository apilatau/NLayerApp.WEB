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
    public class AdditionalRepository : IRepository<Additional>
    {
        private CommentsContext db;

        public AdditionalRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<Additional> GetAll()
        {
            return db.Additionals.Include(o => o.TakeOffs.Select(tk => tk.RequestForTakeOffs));
            //получается в набор попадают все доработки со снятиями и запросами на снятие по select
        }

        public Additional Get(int id)
        {
            return db.Additionals.Find(id);
        }

        public void Create(Additional addnls)
        {
            db.Additionals.Add(addnls);
        }

        public void Update(Additional addnls)
        {
            db.Entry(addnls).State = EntityState.Modified;
        }
        public IEnumerable<Additional> Find(Func<Additional, Boolean> predicate)
        {
            return db.Additionals.Include(o => o.TakeOffs.Select(tk => tk.RequestForTakeOffs)).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Additional addnls = db.Additionals.Find(id);
            if (addnls != null)
                db.Additionals.Remove(addnls);
        }

    }
}
