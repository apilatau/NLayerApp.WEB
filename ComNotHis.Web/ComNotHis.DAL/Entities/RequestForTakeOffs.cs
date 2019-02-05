using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class RequestForTakeOff : EntityWithMany// запросы на снятие замечаний
    {
        public int Id { get; set; }
        public DateTime DateRequestForTakeOff { get; set; } // дата запроса на снятие замечания

        public string TextRequestForTakingOff { get; set; } // комментарий к снятию
        public string UserName { get; set; }

        //связь со снятием TakeOff
        public int? TakeOffId { get; set; }
        public TakeOff TakeOff { get; set; }
    }

}
