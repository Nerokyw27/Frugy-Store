using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Model
{
    public class M_Akun
    {
        public int AkunId { get; set; }
        public string NamaLengkap { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public RoleAkun Role { get; set; }
    }

    public enum RoleAkun
    {
        admin, kasir
    }
}
