using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class NoteDTO : EntityWithManyDTO
    {
        public int Id { get; set; }
        public DateTime DateRecieved { get; set; } //дата поступления замечания 
        public DateTime DateObserved { get; set; } // дата обнаружения замечания
        public string TextNote { get; set; } // текст замечания
        public bool AsAdditional { get; set; } // поступило как доработка

        //связь с статусом замечания NoteStatus много к одному
        public int NoteStatusId { get; set; }
        
    }
}
