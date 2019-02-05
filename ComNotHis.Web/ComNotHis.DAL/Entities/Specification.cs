using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class Specification : EntityWithMany//уточнения к замечаниям
    {
        public int Id { get; set; }

        //связь с запросами и ответами на уточнение
        public ICollection<RequestForSpecification> RequestForSpecifications { get; set; }
        public ICollection<AnswerToRequestSpecification> AnswerToRequestSpecifications { get; set; }

        //связь с замечанием Note (много ко многим)
        public virtual ICollection<Note> Notes { get; set; }
        public Specification()
        {
            Notes = new List<Note>();

            RequestForSpecifications = new List<RequestForSpecification>();
            AnswerToRequestSpecifications = new List<AnswerToRequestSpecification>();
        }
    }

}
