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
    public class RequestForSpecificationRepository : IRepository<RequestForSpecification>
    {
        private CommentsContext db;

        public RequestForSpecificationRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<RequestForSpecification> GetAll()
        {
            return db.RequestForSpecifications.Include(o => o.Specification);
        }

        public RequestForSpecification Get(int id)
        {
            return db.RequestForSpecifications.Find(id);
        }

        public void Create(RequestForSpecification rqsp)
        {
            db.RequestForSpecifications.Add(rqsp);
        }

        public void Update(RequestForSpecification rqsp)
        {
            db.Entry(rqsp).State = EntityState.Modified;
        }

        public IEnumerable<RequestForSpecification> Find(Func<RequestForSpecification, Boolean> predicate)
        {
            return db.RequestForSpecifications.Include(o => o.Specification).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            RequestForSpecification rqsp = db.RequestForSpecifications.Find(id);
            if (rqsp != null)
                db.RequestForSpecifications.Remove(rqsp);
        }
    }
}
