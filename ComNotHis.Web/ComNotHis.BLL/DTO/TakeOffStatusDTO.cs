using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComNotHis.DAL.Entities;

namespace ComNotHis.BLL.DTO
{
    public class TakeOffStatusDTO
    {
        public int Id { get; set; }
        public string TakeOffName { get; set; } // снято, не снято
    }
}
