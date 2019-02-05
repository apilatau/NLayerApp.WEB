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
    public class CorrectionStatusRepository : IRepository<CorrectionStatus>
    {
        private CommentsContext db;

        public CorrectionStatusRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<CorrectionStatus> GetAll()
        {
            return db.CorrectionStatuss;
        }

        public CorrectionStatus Get(int id)
        {
            return db.CorrectionStatuss.Find(id);
        }

        public void Create(CorrectionStatus crst)
        {
            db.CorrectionStatuss.Add(crst);
        }

        public void Update(CorrectionStatus crst)
        {
            db.Entry(crst).State = EntityState.Modified;
        }

        public IEnumerable<CorrectionStatus> Find(Func<CorrectionStatus, Boolean> predicate)
        {
            return db.CorrectionStatuss.Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            CorrectionStatus crst = db.CorrectionStatuss.Find(id);
            if (crst != null)
                db.CorrectionStatuss.Remove(crst);
        }

    }
}
