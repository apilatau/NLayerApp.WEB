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
    public class CorrectionRepository : IRepository<Correction>
    {
        private CommentsContext db;

        public CorrectionRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<Correction> GetAll()
        {
            return db.Corrections.Include(o => o.Notes).Include(o=>o.CorrectionStatus);            
        }

        public Correction Get(int id)
        {
            return db.Corrections.Find(id);
        }

        public void Create(Correction cors)
        {
            db.Corrections.Add(cors);
        }

        public void Update(Correction cors)
        {
            db.Entry(cors).State = EntityState.Modified;
        }

        public IEnumerable<Correction> Find(Func<Correction, Boolean> predicate)
        {
            return db.Corrections.Include(o => o.Notes).Include(o => o.CorrectionStatus).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            Correction cors = db.Corrections.Find(id);
            if (cors != null)
                db.Corrections.Remove(cors);
        }
    }
}
