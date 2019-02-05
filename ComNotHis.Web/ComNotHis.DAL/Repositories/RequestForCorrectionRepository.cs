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
    public class RequestForCorrectionRepository : IRepository<RequestForCorrection>
    {
        private CommentsContext db;

        public RequestForCorrectionRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<RequestForCorrection> GetAll()
        {
            return db.RequestForCorrections.Include(o => o.Note);
        }

        public RequestForCorrection Get(int id)
        {
            return db.RequestForCorrections.Find(id);
        }

        public void Create(RequestForCorrection rqcr)
        {
            db.RequestForCorrections.Add(rqcr);
        }

        public void Update(RequestForCorrection rqcr)
        {
            db.Entry(rqcr).State = EntityState.Modified;
        }

        public IEnumerable<RequestForCorrection> Find(Func<RequestForCorrection, Boolean> predicate)
        {
            return db.RequestForCorrections.Include(o => o.Note).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            RequestForCorrection rqcr = db.RequestForCorrections.Find(id);
            if (rqcr != null)
                db.RequestForCorrections.Remove(rqcr);
        }
    }
}
