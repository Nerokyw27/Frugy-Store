using Frugy_Store.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Controller
{
    internal class C_Laporan
    {
        private DbContext _dbContext;

        public C_Laporan()
        {
            _dbContext = new DbContext(); // <--- INI YANG HILANG DI KODEMU
        }

        public DataTable GetLaporanPenjualan(DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();

                    string query = @"
                        SELECT 
                            t.id_transaksi AS ""ID Transaksi"",
                            to_char(t.tanggal_transaksi, 'DD-MM-YYYY HH24:MI') AS ""Waktu"",
                            a.nama_lengkap AS ""Kasir"",
                            t.metode_pembayaran AS ""Metode"",
                            t.total_bayar AS ""Total Belanja""
                        FROM transaksi t
                        JOIN akun a ON t.akun_id = a.akun_id
                        LEFT JOIN detail_transaksi dt ON t.id_transaksi = dt.id_transaksi
                        WHERE t.tanggal_transaksi BETWEEN @start AND @end
                        GROUP BY t.id_transaksi, t.tanggal_transaksi, a.nama_lengkap, t.metode_pembayaran
                        ORDER BY t.tanggal_transaksi DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@start", start.Date);
                        cmd.Parameters.AddWithValue("@end", end.Date.AddDays(1).AddTicks(-1));

                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat laporan penjualan: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetLaporanStok()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            p.nama_produk AS ""Nama Produk"",
                            jp.jenis_produk AS ""Kategori"",
                            p.stok AS ""Sisa Stok"",
                            p.satuan AS ""Satuan"",
                            p.lokasi AS ""Lokasi Rak""
                        FROM produk p
                        JOIN jenis_produk jp ON p.id_jenis_produk = jp.id_jenis_produk
                        WHERE p.status = '1'
                        ORDER BY p.stok ASC"; 

                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat stok: " + ex.Message);
            }
            return dt;
        }

        public DataTable GetDetailPerTransaksi(int idTransaksi)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            p.nama_produk AS ""Produk"",
                            dt.kuantitas AS ""Qty"",
                            p.harga AS ""Harga"",
                            t.total_bayar AS ""Jumlah Nominal""
                        FROM detail_transaksi dt
                        JOIN produk p ON dt.id_produk = p.id_produk
                        JOIN transaksi t ON dt.id_transaksi = t.id_transaksi
                        WHERE dt.id_transaksi = @id";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idTransaksi);
                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            return dt;
        }
        public DataTable GetTransaksiByKasir(int idKasir, DateTime start, DateTime end)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    t.id_transaksi AS ""ID"",
                    to_char(t.tanggal_transaksi, 'DD-MM-YYYY HH24:MI') AS ""Waktu"",
                    t.metode_pembayaran AS ""Metode"",
                    t.total_bayar AS ""Total Belanja""
                FROM transaksi t
                LEFT JOIN detail_transaksi dt ON t.id_transaksi = dt.id_transaksi
                WHERE t.akun_id = @idKasir 
                  AND t.tanggal_transaksi BETWEEN @start AND @end
                GROUP BY t.id_transaksi, t.tanggal_transaksi, t.metode_pembayaran
                ORDER BY t.tanggal_transaksi DESC";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@idKasir", idKasir);
                        cmd.Parameters.AddWithValue("@start", start.Date);
                        cmd.Parameters.AddWithValue("@end", end.Date.AddDays(1).AddTicks(-1));

                        using (var da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal muat data kasir: " + ex.Message);
            }
            return dt;
        }
    }
}
