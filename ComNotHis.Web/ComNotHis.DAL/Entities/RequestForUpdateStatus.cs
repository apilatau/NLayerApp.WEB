using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class RequestForUpdateStatus : EntityWithMany // запрос на обновление статуса
    {
        public int Id { get; set; }
        public DateTime DateReqToUpdStatus { get; set; } // дата запроса на обновление статуса

        public string TextAnswer { get; set; } // тескт ответа по устранению

        public string UserName { get; set; }


        //связь с Устранениями Corrections

        public int? CorrectionId { get; set; }
        public Correction Correction { get; set; }
    }

}
