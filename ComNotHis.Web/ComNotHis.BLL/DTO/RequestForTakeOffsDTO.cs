using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class RequestForTakeOffsDTO : EntityWithManyDTO
    {
        public int Id { get; set; }
        public DateTime DateRequestForTakeOff { get; set; } // дата запроса на снятие замечания

        public string TextRequestForTakingOff { get; set; } // комментарий к снятию
        public string UserName { get; set; }

        //связь со снятием TakeOff
        public int? TakeOffId { get; set; }
        
    }
}
