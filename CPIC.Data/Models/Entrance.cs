using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPIC.Data.Models
{
    /// <summary>
    /// 进出口相关信息
    /// </summary>
    public class Entrance
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int InOrOut { get; set; }
        public List<Camera> Cameras { get; set; }
        public Led Led { get; set; }
        public bool IsActive { get; set; }
    }
}
