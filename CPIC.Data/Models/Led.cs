using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPIC.Data.Models
{
    public class Led
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Ip { get; set; } = String.Empty;
        public int Port { get; set; }
        public string User { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
