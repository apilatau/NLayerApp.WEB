using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class CorrectionDTO : EntityWithManyDTO
    {
        public int Id { get; set; }
        public DateTime DateCorrected { get; set; } // дата (окончательного) фактического устранения
        public DateTime DateUpdateStatus { get; set; } // дата окончательного обновления

        //связь с статусом устранения CorrectionStatus много к одному
        public int CorrectionStatusId { get; set; }
 
    }
}
