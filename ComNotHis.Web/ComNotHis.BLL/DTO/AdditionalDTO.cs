using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class AdditionalDTO : EntityWithManyDTO
    {
        public int Id { get; set; }
        public DateTime DateClosed { get; set; } // когда на доработку сверх ТЗ соглашается подрядчик, она переводится в разряд замечаний
        //дата поступления равна будет этой дате, и флаг AsAdditional ставиться как true
        public DateTime DateRecieved { get; set; } // когда приходит уточнение от заказчика
        public string TextJustification { get; set; } // текст обоснования на доработку
        public string TextSpecification { get; set; } // текст необходимого уточнения к ТЗ
      //  public int 
      
    }
}
