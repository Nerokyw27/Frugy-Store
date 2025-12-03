using Frugy_Store.Database;
using Frugy_Store.Helpers;
using Frugy_Store.Interface;
using Frugy_Store.Model;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Controller
{
    internal class C_Transaksi
    {
        private DbContext _dbContext;

        public C_Transaksi()
        {
            _dbContext = new DbContext();
        }

        public bool SimpanTransaksi(M_Transaksi transaksi)
        {
            using (var conn = new NpgsqlConnection(_dbContext.connStr))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Header
                        string qHead = "INSERT INTO transaksi (akun_id, metode_pembayaran) VALUES (@akun, @metode) RETURNING id_transaksi";
                        int idTransBaru;
                        using (var cmd = new NpgsqlCommand(qHead, conn, trans))
                        {
                            cmd.Parameters.AddWithValue("@akun", transaksi.AkunId); // Ambil dari object
                            cmd.Parameters.AddWithValue("@metode", transaksi.MetodePembayaran); // Ambil dari object
                            idTransBaru = Convert.ToInt32(cmd.ExecuteScalar());
                        }

                        // 2. Detail (Looping ListDetail yang ada di dalam object transaksi)
                        foreach (var item in transaksi.ListDetail)
                        {
                            // Insert Detail
                            string qDet = "INSERT INTO detail_transaksi (id_transaksi, id_produk, kuantitas) VALUES (@idT, @idP, @qty)";
                            using (var cmd = new NpgsqlCommand(qDet, conn, trans))
                            {
                                cmd.Parameters.AddWithValue("@idT", idTransBaru);
                                cmd.Parameters.AddWithValue("@idP", item.IdProduk);
                                cmd.Parameters.AddWithValue("@qty", item.Kuantitas);
                                cmd.ExecuteNonQuery();
                            }

                            // Update Stok
                            //string qStok = "UPDATE produk SET stok = stok - @qty WHERE id_produk = @idP";
                            //using (var cmd = new NpgsqlCommand(qStok, conn, trans))
                            //{
                            //    cmd.Parameters.AddWithValue("@qty", item.Kuantitas);
                            //    cmd.Parameters.AddWithValue("@idP", item.IdProduk);
                            //    cmd.ExecuteNonQuery();
                            //}
                        }
                        trans.Commit();
                        return true;
                    }
                    catch (Exception) { trans.Rollback(); throw; }
                }
            }
        }
    }
}
