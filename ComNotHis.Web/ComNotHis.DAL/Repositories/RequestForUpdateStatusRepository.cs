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
    public class RequestForUpdateStatusRepository : IRepository<RequestForUpdateStatus>
    {
        private CommentsContext db;

        public RequestForUpdateStatusRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<RequestForUpdateStatus> GetAll()
        {
            return db.RequestForUpdateStatuss.Include(o => o.Correction);
        }

        public RequestForUpdateStatus Get(int id)
        {
            return db.RequestForUpdateStatuss.Find(id);
        }

        public void Create(RequestForUpdateStatus rqup)
        {
            db.RequestForUpdateStatuss.Add(rqup);
        }

        public void Update(RequestForUpdateStatus rqup)
        {
            db.Entry(rqup).State = EntityState.Modified;
        }

        public IEnumerable<RequestForUpdateStatus> Find(Func<RequestForUpdateStatus, Boolean> predicate)
        {
            return db.RequestForUpdateStatuss.Include(o => o.Correction).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            RequestForUpdateStatus rqup = db.RequestForUpdateStatuss.Find(id);
            if (rqup != null)
                db.RequestForUpdateStatuss.Remove(rqup);
        }
    }
}
