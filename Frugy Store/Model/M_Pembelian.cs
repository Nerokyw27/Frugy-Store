using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Model
{
    internal class M_Pembelian
    {
        public int IdPembelian { get; set; }
        public string Supplier { get; set; }
        public DateTime Tanggal { get; set; }

        // List barang yang dibeli
        public List<M_DetailPembelian> ListBarangMasuk { get; set; }

        public M_Pembelian()
        {
            ListBarangMasuk = new List<M_DetailPembelian>();
        }
    }
}
