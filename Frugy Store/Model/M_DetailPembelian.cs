using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Model
{
    public class M_DetailPembelian
    {
        public int IdPembelian { get; set; } // FK
        public int IdProduk { get; set; }    // FK
        public int KuantitasStok { get; set; } // kuantitas_stok

        // Helper UI
        public string NamaProduk { get; set; }
    }
}
