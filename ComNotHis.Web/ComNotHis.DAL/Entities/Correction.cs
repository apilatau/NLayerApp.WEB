using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class Correction : EntityWithMany//устранение замечаний
    {
        public int Id { get; set; }
        public DateTime DateCorrected { get; set; } // дата (окончательного) фактического устранения
        public DateTime DateUpdateStatus { get; set; } // дата окончательного обновления


        //связь с запросами на обновление статуса
        public ICollection<RequestForUpdateStatus> RequestForUpdateStatuss { get; set; }

        //связь с замечанием Note (много ко многим)
        public virtual ICollection<Note> Notes { get; set; }
        public Correction()
        {
            Notes = new List<Note>();

            //связь с обновлениями статусов
            RequestForUpdateStatuss = new List<RequestForUpdateStatus>();
        }

        //связь с статусом устранения CorrectionStatus много к одному
        public int CorrectionStatusId { get; set; }
        public CorrectionStatus CorrectionStatus { get; set; }

    }

}
