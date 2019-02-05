using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class AnswerToRequestSpecification : EntityWithMany
    {
        public int Id { get; set; }
        public DateTime DateAnswerToRequest { get; set; } // дата ответа на запрос
        public string TextAnswer { get; set; }// текст ответа на запрос на снятие
        public string UserName { get; set; } // имя пользователя, который запросил уточнение

        //связь много к одному с уточнениями Specification
        public int? SpecificationId { get; set; }
        public Specification Specification { get; set; }
    }

}
