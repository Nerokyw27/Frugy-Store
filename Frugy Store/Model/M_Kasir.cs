using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Model
{
    public class M_Kasir
    {
        public int IdKasir { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string NoHp { get; set; }
        public string NamaLengkap { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime MulaiBekerja { get; set; }
    }
}
