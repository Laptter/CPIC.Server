using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPIC.Data.Models
{
    /// <summary>
    /// 停车用户
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id  { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }=string.Empty;

        /// <summary>
        /// 用户类型
        /// </summary>
        public UserType UserType { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// 车牌号码
        /// </summary>
        public string Car_No { get; set; } = string.Empty;

        /// <summary>
        /// 公司ID
        /// </summary>
        public Company Company { get; set; }

        /// <summary>
        /// 有效开始时间
        /// </summary>
        public long StartTime { get; set; }

        /// <summary>
        /// 有效结束时间
        /// </summary>
        public long EndTime { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// 停车状态
        /// </summary>
        public int ParkStatu { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public long CreateTime { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public long UpdateTime { get; set; }

        /// <summary>
        /// 车辆类型
        /// </summary>
        public int Car_Type { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// 是否删除
        /// </summary>
        public bool Deleted { get; set; }
    }
}
