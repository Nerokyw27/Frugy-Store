using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Model
{
    public class M_Produk
    {
        public int IdProduk { get; set; }
        public byte[] Image { get; set; }
        public string NamaProduk { get; set; }
        public int Harga { get; set; }
        public int Stok { get; set; }
        public int AkunId { get; set; }
        public string Satuan { get; set; }
        public string Lokasi { get; set; }
        public string Deskripsi { get; set; }
        public int IdJenisProduk { get; set; }
    }
}
