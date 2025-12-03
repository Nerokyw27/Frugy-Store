using Frugy_Store.Database;
using Frugy_Store.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Controller
{
    internal class C_Pembelian
    {
        private DbContext _dbContext;

        public C_Pembelian()
        {
            _dbContext = new DbContext();
        }

        public bool SimpanRestock(M_Pembelian pembelian)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. INSERT HEADER (Tabel Baru: pembelian_produk)
                        string queryHead = @"INSERT INTO pembelian_produk (supplier, tanggal_pembelian) 
                                             VALUES (@supp, CURRENT_DATE) 
                                             RETURNING id_pembelian";

                        int idBaru;
                        using (var cmd = new NpgsqlCommand(queryHead, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@supp", pembelian.Supplier);
                            idBaru = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. INSERT DETAIL (Tabel Baru: detail_pembelian)
                        // Tidak perlu update stok manual, Trigger DB yang kerja!
                        foreach (var item in pembelian.ListBarangMasuk)
                        {
                            string queryDet = @"INSERT INTO detail_pembelian (id_pembelian, id_produk, kuantitas_stok) 
                                                VALUES (@idBeli, @idProd, @qty)";

                            using (var cmdDet = new NpgsqlCommand(queryDet, conn, trans))
                            {
                                cmdDet.Parameters.AddWithValue("@idBeli", idBaru);
                                cmdDet.Parameters.AddWithValue("@idProd", item.IdProduk);
                                cmdDet.Parameters.AddWithValue("@qty", item.KuantitasStok);
                                cmdDet.ExecuteNonQuery();
                            }
                        }

                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Gagal Restock: " + ex.Message);
                        return false;
                    }
                }

            }
        }
    }
}
