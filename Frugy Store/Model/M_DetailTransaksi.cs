using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Model
{
    public class M_DetailTransaksi
    {
        public int IdTransaksi { get; set; }
        public int IdProduk { get; set; }
        public int Kuantitas { get; set; }

        public string NamaProduk { get; set; }
        public int Harga { get; set; }

        public int Subtotal => Harga * Kuantitas;
    }
}
