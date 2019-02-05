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
    public class AnswerToRequestSpecificationRepository : IRepository<AnswerToRequestSpecification>
    {
        private CommentsContext db;

        public AnswerToRequestSpecificationRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<AnswerToRequestSpecification> GetAll()
        {
            return db.AnswerToRequestSpecifications.Include(o=>o.Specification);
        }

        public AnswerToRequestSpecification Get(int id)
        {
            return db.AnswerToRequestSpecifications.Find(id);
        }

        public void Create(AnswerToRequestSpecification anrqsp)
        {
            db.AnswerToRequestSpecifications.Add(anrqsp);
        }

        public void Update(AnswerToRequestSpecification anrqsp)
        {
            db.Entry(anrqsp).State = EntityState.Modified;
        }

        public IEnumerable<AnswerToRequestSpecification> Find(Func<AnswerToRequestSpecification, Boolean> predicate)
        {
            return db.AnswerToRequestSpecifications.Include(o => o.Specification).Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            AnswerToRequestSpecification anrqsp = db.AnswerToRequestSpecifications.Find(id);
            if (anrqsp != null)
                db.AnswerToRequestSpecifications.Remove(anrqsp);
        }

    }
}
