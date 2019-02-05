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
    public class RequestForTakeOffRepository : IRepository<RequestForTakeOff>
    {
        private CommentsContext db;

        public RequestForTakeOffRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<RequestForTakeOff> GetAll()
        {
            return db.RequestForTakeOffs.Include(o => o.TakeOff);
        }

        public RequestForTakeOff Get(int id)
        {
            return db.RequestForTakeOffs.Find(id);
        }

        public void Create(RequestForTakeOff rqtf)
        {
            db.RequestForTakeOffs.Add(rqtf);
        }

        public void Update(RequestForTakeOff rqtf)
        {
            db.Entry(rqtf).State = EntityState.Modified;
        }

        public IEnumerable<RequestForTakeOff> Find(Func<RequestForTakeOff, Boolean> predicate)
        {
            return db.RequestForTakeOffs.Include(o => o.TakeOff).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            RequestForTakeOff rqtf = db.RequestForTakeOffs.Find(id);
            if (rqtf != null)
                db.RequestForTakeOffs.Remove(rqtf);
        }
    }
}
