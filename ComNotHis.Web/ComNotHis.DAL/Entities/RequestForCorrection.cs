using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class RequestForCorrection : EntityWithMany// запрос на устранение
    {
        public int Id { get; set; }
        public DateTime DateRequestForCorrection { get; set; } // дата запроса на устранение

        public string TextQuestion { get; set; } // текст вопроса по устранению
        public string UserName { get; set; } // имя пользователя, запросившего устранение

        //связь с замечанием Note

        public int? NoteId { get; set; }
        public Note Note { get; set; }

    }

}
