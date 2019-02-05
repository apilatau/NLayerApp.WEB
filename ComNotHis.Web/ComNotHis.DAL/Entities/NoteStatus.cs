using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class NoteStatus : EntityWithMany
    {
        public int Id { get; set; }
        public string NoteName { get; set; } // ошибка, вопрос, доработка, дубль

        //связь с замечаниями Note один ко многим
        public ICollection<Note> Notes { get; set; }
        public NoteStatus()
        {
            Notes = new List<Note>();
        }
    }

}
