using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class AnswerToRequestToTakeOff : EntityWithMany
    {
        public int Id { get; set; }
        public DateTime DateAnswerToRequestToTakeOff { get; set; }

        public string TextAnswerToRequest { get; set; }

        public string UserName { get; set; }

        public int? TakeOffId { get; set; }
        public TakeOff TakeOff { get; set; }
    }

}
