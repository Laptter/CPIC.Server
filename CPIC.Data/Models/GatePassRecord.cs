using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPIC.Data.Models
{
    /// <summary>
    /// 出入记录
    /// </summary>
    public class GatePassRecord
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        public string CarNo { get; set; }=string.Empty;

        /// <summary>
        /// 用户
        /// </summary>
        public User ParkUser { get; set; }

        /// <summary>
        /// 出入口
        /// </summary>
        public Entrance Entrance { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public long UpdateTime { get; set; }
    }
}
