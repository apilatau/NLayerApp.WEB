using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class TakeOffDTO : EntityWithManyDTO
    {
        public int Id { get; set; }

        public DateTime DateToTakeOff { get; set; } // дата окончательного снятия замечания        

        //связь с доработкой много к многому - одно замечание может привести к нескольким доработкам и одна доработка может покрыть несколько замечаний
        //+ возможность несколько раз запрашивать статусы "доработка сверх ТЗ"

        public virtual ICollection<Additional> Additionals { get; set; }

        // связь с статусом снятия много к одному
        public int? TakeOffStatusId { get; set; }
    }
}
