using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class Note : EntityWithMany// замечание
    {
        public int Id { get; set; }
        public DateTime DateRecieved { get; set; } //дата поступления замечания 
        public DateTime DateObserved { get; set; } // дата обнаружения замечания
        public string TextNote { get; set; } // текст замечания
        public bool AsAdditional { get; set; } // поступило как доработка

        //связь с статусом замечания NoteStatus много к одному
        public int NoteStatusId { get; set; }
        public NoteStatus NoteStatus { get; set; }

        //связь с Запросом на устранение RequestForCorrection

        public ICollection<RequestForCorrection> RequestForCorrections { get; set; }

        //связи с Corrections,Specifications and TakeOffs много ко многим
        public virtual ICollection<Correction> Corrections { get; set; }
        public virtual ICollection<Specification> Specifications { get; set; }
        public virtual ICollection<TakeOff> TakeOffs { get; set; }

        public Note()
        {
            Corrections = new List<Correction>();
            Specifications = new List<Specification>();
            TakeOffs = new List<TakeOff>();

            //запросы на устранение один ко многим
            RequestForCorrections = new List<RequestForCorrection>();
        }
    }

}
