using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class Additional : EntityWithMany//доработки сверх ТЗ 
    {
        public int Id { get; set; }
        public DateTime DateClosed { get; set; } // когда на доработку сверх ТЗ соглашается подрядчик, она переводится в разряд замечаний

        //дата поступления равна будет этой дате, и флаг AsAdditional ставиться как true

        public DateTime DateRecieved { get; set; } // когда приходит уточнение от заказчика
        public string TextJustification { get; set; } // текст обоснования на доработку
        public string TextSpecification { get; set; } // текст необходимого уточнения к ТЗ

        //связь один к многим со снятием
        public virtual ICollection<TakeOff> TakeOffs { get; set; }
        public Additional():base("Additional")
        {
            TakeOffs = new List<TakeOff>();
            
        }
    }

}
