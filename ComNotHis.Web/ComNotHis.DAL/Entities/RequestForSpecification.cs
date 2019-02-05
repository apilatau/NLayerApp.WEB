using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class RequestForSpecification : EntityWithMany// запросы на уточнение
    {
        public int Id { get; set; }
        public DateTime DateRequestForSpecification { get; set; } // дата запросa

        public string TextRequest { get; set; } //текст запроса на снятие /обоснование

        public string UserName { get; set; } // имя пользователя, который запросил уточнение

        //связь с уточнениями много к одному
        public int? SpecificationId { get; set; }
        public Specification Specification { get; set; }

    }

}
