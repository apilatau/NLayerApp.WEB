using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComNotHis.DAL.Entities
{
    public class CorrectionStatus : EntityWithMany
    {
        public int Id { get; set; }
        public string CorrectionName { get; set; } //устранено, не устранено

        //связь с Устранением Correction один ко многим
        public ICollection<Correction> Corrections { get; set; }
        public CorrectionStatus()
        {
            Corrections = new List<Correction>();
        }
    }

}
