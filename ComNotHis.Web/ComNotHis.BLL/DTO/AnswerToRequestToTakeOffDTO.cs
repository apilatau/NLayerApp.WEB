using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class AnswerToRequestToTakeOffDTO : EntityWithManyDTO
    {
        public int Id { get; set; }
        public DateTime DateAnswerToRequestToTakeOff { get; set; }

        public string TextAnswerToRequest { get; set; }

        public string UserName { get; set; }

        public int? TakeOffId { get; set; }        
    }
}
