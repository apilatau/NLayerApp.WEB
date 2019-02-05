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
    public class AnswerToRequestToTakeOffRepository : IRepository<AnswerToRequestToTakeOff>
    {
        private CommentsContext db;

        public AnswerToRequestToTakeOffRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<AnswerToRequestToTakeOff> GetAll()
        {
            return db.AnswerToRequestToTakeOffs.Include(o=>o.TakeOff);
        }

        public AnswerToRequestToTakeOff Get(int id)
        {
            return db.AnswerToRequestToTakeOffs.Find(id);
        }

        public void Create(AnswerToRequestToTakeOff anrqtkof)
        {
            db.AnswerToRequestToTakeOffs.Add(anrqtkof);
        }

        public void Update(AnswerToRequestToTakeOff anrqtkof)
        {
            db.Entry(anrqtkof).State = EntityState.Modified;
        }

        public IEnumerable<AnswerToRequestToTakeOff> Find(Func<AnswerToRequestToTakeOff, Boolean> predicate)
        {
            return db.AnswerToRequestToTakeOffs.Include(o => o.TakeOff).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            AnswerToRequestToTakeOff anrqsp = db.AnswerToRequestToTakeOffs.Find(id);
            if (anrqsp != null)
                db.AnswerToRequestToTakeOffs.Remove(anrqsp);
        }
    }
}
