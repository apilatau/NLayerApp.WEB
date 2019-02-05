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
    public class NoteRepository : IRepository<Note>
    {
        private CommentsContext db;

        public NoteRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<Note> GetAll()
        {
            return db.Notes.Include(rc => rc.RequestForCorrections).Include(p => p.NoteStatus).Include(p => p.Corrections)
                                .Include(p => p.Specifications.Select(s => s.RequestForSpecifications))
                                .Include(p => p.TakeOffs.Select(tk => tk.RequestForTakeOffs));

        }

        public Note Get(int id)
        {
            return db.Notes.Find(id);
        }

        public void Create(Note nts)
        {
            db.Notes.Add(nts);
        }

        public void Update(Note nts)
        {
            db.Entry(nts).State = EntityState.Modified;
        }
        public IEnumerable<Note> Find(Func<Note, Boolean> predicate)
        {
            return db.Notes.Include(rc => rc.RequestForCorrections).Include(p => p.NoteStatus).Include(p => p.Corrections)
                                .Include(p => p.Specifications.Select(s => s.RequestForSpecifications))
                                .Include(p => p.TakeOffs.Select(tk => tk.RequestForTakeOffs)).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Note nts = db.Notes.Find(id);
            if (nts != null)
                db.Notes.Remove(nts);
        }
    }
}
