using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Model
{
    internal class M_Transaksi
    {
        public int IdTransaksi { get; set; }
        public string MetodePembayaran { get; set; }
        public DateTime TanggalTransaksi { get; set; }
        public int AkunId { get; set; }
        public List<M_DetailTransaksi> ListDetail { get; set; }

        public M_Transaksi()
        {
            ListDetail = new List<M_DetailTransaksi>();
        }
    }
}
