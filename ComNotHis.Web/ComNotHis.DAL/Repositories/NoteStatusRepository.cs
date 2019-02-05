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
    public class NoteStatusRepository : IRepository<NoteStatus>
    {
        private CommentsContext db;

        public NoteStatusRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<NoteStatus> GetAll()
        {
            return db.NoteStatuss;
        }

        public NoteStatus Get(int id)
        {
            return db.NoteStatuss.Find(id);
        }

        public void Create(NoteStatus ntst)
        {
            db.NoteStatuss.Add(ntst);
        }

        public void Update(NoteStatus ntst)
        {
            db.Entry(ntst).State = EntityState.Modified;
        }

        public IEnumerable<NoteStatus> Find(Func<NoteStatus, Boolean> predicate)
        {
            return db.NoteStatuss.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            NoteStatus ntst = db.NoteStatuss.Find(id);
            if (ntst != null)
                db.NoteStatuss.Remove(ntst);
        }
    }
}
