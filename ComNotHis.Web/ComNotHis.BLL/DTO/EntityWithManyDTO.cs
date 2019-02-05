using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.BLL.DTO
{
    public abstract class EntityWithManyDTO
    {
        protected string Name { get; set; }

        public EntityWithManyDTO() { }

        public EntityWithManyDTO(string name)
        {
            Name = name;
        }
    }
}
