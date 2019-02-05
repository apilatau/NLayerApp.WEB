using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class CorrectionStatusDTO
    {
        public int Id { get; set; }
        public string CorrectionName { get; set; } //устранено, не устранено
    }
}
