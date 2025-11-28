using Frugy_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Interface
{
    public interface IKasir
    {
        public interface IKasir
        {
            bool TambahKasir(M_Kasir kasir);

            List<M_Kasir> GetAllKasir();

            bool UbahKasir(M_Kasir kasir);

            bool HapusKasir(string username);
        }
    }
}
