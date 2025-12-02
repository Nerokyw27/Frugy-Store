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
using System.Windows.Forms;

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
                        INSERT INTO produk(
                            nama_produk,
                            lokasi,
                            deskripsi,
                            harga,
                            satuan,
                            id_jenis_produk,
                            gambar,
                            status
                        )
                        VALUES(
                            @nama_produk,
                            @lokasi,
                            @deskripsi,
                            @harga,
                            @satuan,
                            @id_jenis_produk,
                            @image,
                            @status
                        )";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_produk", produk.NamaProduk ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@lokasi", produk.Lokasi);
                        cmd.Parameters.AddWithValue("@deskripsi", produk.Deskripsi);
                        cmd.Parameters.AddWithValue("@harga", produk.Harga);
                        cmd.Parameters.AddWithValue("@satuan", produk.Satuan ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_jenis_produk", produk.IdJenisProduk);

                        if (produk.Image != null && produk.Image.Length > 0)
                            cmd.Parameters.AddWithValue("@image", produk.Image);
                        else
                            cmd.Parameters.AddWithValue("@image", DBNull.Value);

                        // default aktif
                        cmd.Parameters.AddWithValue("@status", "1");

                        cmd.ExecuteNonQuery();
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
                                    SELECT * 
                                    FROM produk
                                    WHERE akun_id = @akunId AND status = '1'
                                    ORDER BY id_produk ASC";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@akunId", userId);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                M_Produk produk = MapToModel(reader);
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

        public M_Produk GetProdukById(int idProduk)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = "SELECT * FROM produk WHERE id_produk = @id LIMIT 1";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProduk);
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return MapToModel(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal ambil produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public bool UpdateProduk(M_Produk produk)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        UPDATE produk SET 
                            nama_produk = @nama_produk,
                            lokasi = @lokasi,
                            deskripsi = @deskripsi,
                            harga = @harga,
                            satuan = @satuan,
                            id_jenis_produk = @id_jenis_produk,
                            gambar = @image
                        WHERE id_produk = @id_produk";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_produk", produk.NamaProduk ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@lokasi", produk.Lokasi ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@deskripsi", produk.Deskripsi ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@harga", produk.Harga);
                        cmd.Parameters.AddWithValue("@satuan", produk.Satuan ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@id_jenis_produk", produk.IdJenisProduk);
                        cmd.Parameters.AddWithValue("@id_produk", produk.IdProduk);
                        if (produk.Image != null && produk.Image.Length > 0)
                            cmd.Parameters.AddWithValue("@image", produk.Image);
                        else
                            cmd.Parameters.AddWithValue("@image", DBNull.Value);

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal update produk: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            p.Harga = reader["harga"] != DBNull.Value ? Convert.ToInt32(reader["harga"]) : 0;
            p.Stok = reader["stok"] != DBNull.Value ? Convert.ToInt32(reader["stok"]) : 0;
            p.AkunId = reader["akun_id"] != DBNull.Value ? Convert.ToInt32(reader["akun_id"]) : 0;

            // Handle Kolom Tambahan
            if (CheckColumn(reader, "satuan"))
                p.Satuan = reader["satuan"] != DBNull.Value ? reader["satuan"].ToString() : "";

            if (CheckColumn(reader, "lokasi"))
                p.Lokasi = reader["lokasi"] != DBNull.Value ? reader["lokasi"].ToString() : "";

            if (CheckColumn(reader, "deskripsi"))
                p.Deskripsi = reader["deskripsi"] != DBNull.Value ? reader["deskripsi"].ToString() : "";


            // id jenis produk handling (cek beberapa nama kolom umum)
            if (CheckColumn(reader, "id_jenis_produk") && reader["id_jenis_produk"] != DBNull.Value)
                p.IdJenisProduk = Convert.ToInt32(reader["id_jenis_produk"]);
            else if (CheckColumn(reader, "idjenisproduk") && reader["idjenisproduk"] != DBNull.Value)
                p.IdJenisProduk = Convert.ToInt32(reader["idjenisproduk"]);


            // Handle Image/Gambar Null Check
            if (CheckColumn(reader, "gambar") && reader["gambar"] != DBNull.Value)
            {
                p.Image = (byte[])reader["gambar"];
            }
            else if (CheckColumn(reader, "image") && reader["image"] != DBNull.Value)
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