using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPIC.Data.Models
{
    public class Record
    {
        public Guid Id { get; set; }
        public User? ParkUser { get; set; } 
        public long CreateTime { get; set; }
        public long UpdateTime { get; set; }
        public GatePassRecord Enter { get; set; }
        public GatePassRecord Leave { get; set; }
        /// <summary>
        /// 车牌号码
        /// </summary>
        public string CarNo { get; set; } = string.Empty;
    }
}
