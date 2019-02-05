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
    public class SpecificationRepository : IRepository<Specification>
    {
        private CommentsContext db;

        public SpecificationRepository(CommentsContext context)
        {
            this.db = context;
        }

        public IEnumerable<Specification> GetAll()
        {
            return db.Specifications.Include(rc => rc.Notes.Select(n=>n.RequestForCorrections));
            //подключается запрос со всеми запросами на исправления
        }

        public Specification Get(int id)
        {
            return db.Specifications.Find(id);
        }

        public void Create(Specification sps)
        {
            db.Specifications.Add(sps);
        }

        public void Update(Specification sps)
        {
            db.Entry(sps).State = EntityState.Modified;
        }
        public IEnumerable<Specification> Find(Func<Specification, Boolean> predicate)
        {
            return db.Specifications.Include(rc => rc.Notes.Select(n => n.RequestForCorrections)).Where(predicate).ToList();
        }
        public void Delete(int id)
        {
            Specification sps = db.Specifications.Find(id);
            if (sps != null)
                db.Specifications.Remove(sps);
        }
    }
}
