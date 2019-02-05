using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class TakeOffStatus : EntityWithMany
    {
        public int Id { get; set; }
        public string TakeOffName { get; set; } // снято, не снято

        //связь со снятием один ко многим
        public ICollection<TakeOff> TakeOffs { get; set; }
        public TakeOffStatus()
        {
            TakeOffs = new List<TakeOff>();
        }
    }
}
