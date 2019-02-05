using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComNotHis.DAL.Entities
{
    public class TakeOff : EntityWithMany//снятие замечаний
    {
        public int Id { get; set; }

        public DateTime DateToTakeOff { get; set; } // дата окончательного снятия замечания        

        //связь с доработкой много к многому - одно замечание может привести к нескольким доработкам и одна доработка может покрыть несколько замечаний
        //+ возможность несколько раз запрашивать статусы "доработка сверх ТЗ"

        public virtual ICollection<Additional> Additionals { get; set; }

        // связь с статусом снятия много к одному
        public int? TakeOffStatusId { get; set; }
        public TakeOffStatus TakeOffStatus { get; set; }

        //связь с запросами на снятие замечаний
        public ICollection<RequestForTakeOff> RequestForTakeOffs { get; set; }
        public ICollection<AnswerToRequestToTakeOff> AnswerToRequestToTakeOffs { get; set; }

        //связь с замечанием Note (много ко многим)
        public virtual ICollection<Note> Notes { get; set; }
        public TakeOff()
        {
            Notes = new List<Note>();

            RequestForTakeOffs = new List<RequestForTakeOff>();
            AnswerToRequestToTakeOffs = new List<AnswerToRequestToTakeOff>();

            Additionals = new List<Additional>();

        }

    }

}
