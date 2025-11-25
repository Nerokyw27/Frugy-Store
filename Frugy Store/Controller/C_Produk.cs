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
    public class C_Produk : IProduk
    {
        private DbContext _dbContext;

        public C_Produk()
        {
            _dbContext = new DbContext();
        }

        public void TambahProduk(M_Produk produk)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                                    INSERT INTO produk (image, nama_produk, harga, stok, akun_id)
                                    VALUES (@image, @namaProduk, @harga, @stok, @akunId)";


                    using (NpgsqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Parameters.AddWithValue("@image", produk.Image);
                        cmd.Parameters.AddWithValue("@namaProduk", produk.NamaProduk);
                        cmd.Parameters.AddWithValue("@harga", produk.Harga);
                        cmd.Parameters.AddWithValue("@stok", produk.Stok);
                        cmd.Parameters.AddWithValue("@akunId", produk.AkunId);

                        var result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tambah produk gagal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<M_Produk> GetByUserId(int userId)
        {
            List<M_Produk> produkList = new List<M_Produk>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                                    SELECT produk_id, image, nama_produk, harga, stok, akun_id
                                    FROM produk
                                    WHERE akun_id = @akunId";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@akunId", userId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_Produk produk = new M_Produk
                                {
                                    ProdukId = reader.GetInt32(0),
                                    Image = (byte[])reader["image"],
                                    NamaProduk = reader.GetString(2),
                                    Harga = reader.GetInt32(3),
                                    Stok = reader.GetInt32(4),
                                    AkunId = reader.GetInt32(5),
                                };
                                produkList.Add(produk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produkList;
        }
        public List<M_Produk> GetAllProduk()
        {
            List<M_Produk> produkList = new List<M_Produk>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                                    SELECT produk_id, image, nama_produk, harga, stok, akun_id
                                    FROM produk";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_Produk produk = new M_Produk
                                {
                                    ProdukId = reader.GetInt32(0),
                                    Image = (byte[])reader["image"],
                                    NamaProduk = reader.GetString(2),
                                    Harga = reader.GetInt32(3),
                                    Stok = reader.GetInt32(4),
                                };
                                produkList.Add(produk);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produkList;
        }
    }
}
