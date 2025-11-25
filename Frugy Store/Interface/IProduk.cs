using Frugy_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Frugy_Store.Interface
{
    public interface IProduk
    {
        void TambahProduk(M_Produk produk);

        List<M_Produk> GetByUserId(int userId);
        List<M_Produk> GetAllProduk();
    }
}
