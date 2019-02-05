using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;


namespace ComNotHis.BLL.DTO
{
    public class RequestForUpdateStatusDTO : EntityWithManyDTO
    {
        public int Id { get; set; }
        public DateTime DateReqToUpdStatus { get; set; } // дата запроса на обновление статуса

        public string TextAnswer { get; set; } // тескт ответа по устранению

        public string UserName { get; set; }

        public int? CorrectionId { get; set; }
        
    }
}
