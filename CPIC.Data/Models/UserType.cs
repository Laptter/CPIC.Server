using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPIC.Data.Models
{
    public enum UserType
    {
        /// <summary>
        /// 未知或不使用
        /// </summary>
        Unknow = 0,

        /// <summary>
        /// 月租车辆
        /// </summary>
        Month = 1,

        /// <summary>
        /// 登记临时车
        /// </summary>
        RegisterTemp = 2,

        /// <summary>
        /// 日租车
        /// </summary>
        Day = 3,

        /// <summary>
        /// 直行预约车
        /// </summary>
        DirectAppoint = 5,

        /// <summary>
        /// 登记预约车
        /// </summary>
        RegisterAppoint = 6,

        /// <summary>
        /// 临时车
        /// </summary>
        Temp = 4,
    }
}
