using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public abstract class EntityWithMany
    {
        protected string Name { get; set; }

        public EntityWithMany() { }

        public EntityWithMany(string name)
        {
            Name = name;
        }
    }
}
