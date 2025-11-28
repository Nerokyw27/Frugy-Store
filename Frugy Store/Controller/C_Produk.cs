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
                                    INSERT INTO produk (nama_produk, harga, stok, satuan, lokasi, deskripsi, id_jenis_produk, akun_id, image)
                                    VALUES (@nama, @harga, @stok, @satuan, @lokasi, @deskripsi, @idJenis, @akunId, @image)";


                    using (NpgsqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.Parameters.AddWithValue("@image", produk.Image);
                        cmd.Parameters.AddWithValue("@namaProduk", produk.NamaProduk);
                        cmd.Parameters.AddWithValue("@harga", produk.Harga);
                        cmd.Parameters.AddWithValue("@stok", produk.Stok);
                        cmd.Parameters.AddWithValue("@akunId", produk.AkunId);
                        cmd.Parameters.AddWithValue("@satuan", produk.Satuan ?? "");
                        cmd.Parameters.AddWithValue("@lokasi", produk.Lokasi ?? "");
                        cmd.Parameters.AddWithValue("@deskripsi", produk.Deskripsi ?? "");
                        cmd.Parameters.AddWithValue("@idJenis", produk.IdJenisProduk);

                        if (produk.Image != null && produk.Image.Length > 0)
                            cmd.Parameters.AddWithValue("@image", produk.Image);
                        else
                            cmd.Parameters.AddWithValue("@image", DBNull.Value);

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
                                    SELECT id_produk, image, nama_produk, harga, stok, akun_id
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
                                    IdProduk = reader.GetInt32(0),
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
        public List<M_Produk> GetProduk()
        {
            List<M_Produk> produkList = new List<M_Produk>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                                    SELECT * FROM produk WHERE status = '1' ORDER BY id_produk ASC";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_Produk produk = MapToModel(reader);
                                produkList.Add(produk);
                                //M_Produk produk = new M_Produk
                                //{
                                //    ProdukId = reader.GetInt32(0),
                                //    Image = (byte[])reader["image"],
                                //    NamaProduk = reader.GetString(2),
                                //    Harga = reader.GetInt32(3),
                                //    Stok = reader.GetInt32(4),
                                //};
                                //produkList.Add(produk);
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

        public void DeleteProduk(int idProduk)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    // Soft Delete (Recommended) - Change status to '0'
                    string query = "UPDATE produk SET status = '0' WHERE id_produk = @id";

                    // Or Hard Delete (Permanent)
                    // string query = "DELETE FROM produk WHERE produk_id = @id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProduk);
                        int result = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal hapus produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private M_Produk MapToModel(NpgsqlDataReader reader)
        {
            M_Produk p = new M_Produk();

            // Gunakan nama kolom string["nama_kolom"] agar lebih aman daripada index angka
            p.IdProduk = Convert.ToInt32(reader["id_produk"]);
            p.NamaProduk = reader["nama_produk"].ToString();
            p.Harga = Convert.ToInt32(reader["harga"]);
            p.Stok = Convert.ToInt32(reader["stok"]);
            p.AkunId = reader["akun_id"] != DBNull.Value ? Convert.ToInt32(reader["akun_id"]) : 0;

            // Handle Kolom Tambahan
            if (CheckColumn(reader, "satuan"))
                p.Satuan = reader["satuan"] != DBNull.Value ? reader["satuan"].ToString() : "";

            if (CheckColumn(reader, "lokasi"))
                p.Lokasi = reader["lokasi"] != DBNull.Value ? reader["lokasi"].ToString() : "";

            if (CheckColumn(reader, "deskripsi"))
                p.Deskripsi = reader["deskripsi"] != DBNull.Value ? reader["deskripsi"].ToString() : "";

            if (CheckColumn(reader, "id_jenis_produk") && reader["id_jenis_produk"] != DBNull.Value)
                p.IdJenisProduk = Convert.ToInt32(reader["id_jenis_produk"]);

            // Handle Image Null Check (PENTING BIAR GAK CRASH)
            if (CheckColumn(reader, "image") && reader["image"] != DBNull.Value)
            {
                p.Image = (byte[])reader["image"];
            }
            else
            {
                p.Image = null;
            }

            return p;
        }
        private bool CheckColumn(NpgsqlDataReader reader, string colName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(colName, StringComparison.InvariantCultureIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
