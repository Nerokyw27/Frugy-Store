using Frugy_Store.Database;
using Frugy_Store.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Frugy_Store.Controller.C_Kasir;

namespace Frugy_Store.Controller
{
    public class C_Kasir
    {
        private DbContext _dbContext;

        public C_Kasir()
        {
            _dbContext = new DbContext();
        }

        // Get data kasir
        public List<M_Kasir> GetAllKasir()
        {
            List<M_Kasir> kasirList = new List<M_Kasir>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"SELECT username, password, namaLengkap, status, mulaiBekerja FROM kasir";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            kasirList.Add(new M_Kasir
                            {
                                Username = reader["username"].ToString(),
                                Password = reader["password"].ToString(),
                                NamaLengkap = reader["namaLengkap"].ToString(),
                                Status = reader["status"].ToString(),
                                MulaiBekerja = Convert.ToDateTime(reader["mulai_bekerja"])
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal ambil data: " + ex.Message);
            }

            return kasirList;
        }

        // Insert kasir
        public bool InsertKasir(M_Kasir kasir)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"INSERT INTO kasir (username, password, namaLengkap, status, mulaiBekerja)
                                     VALUES (@username, @password, @namaKasir, @status, @mulaiBekerja)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", kasir.Username);
                        cmd.Parameters.AddWithValue("@password", kasir.Password);
                        cmd.Parameters.AddWithValue("@namaLengkap", kasir.NamaLengkap);
                        cmd.Parameters.AddWithValue("@status", kasir.Status);
                        cmd.Parameters.AddWithValue("@mulai_bekerja", kasir.MulaiBekerja);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal tambah kasir: " + ex.Message);
                return false;
            }
        }

        // Update kasir
        public bool UpdateKasir(M_Kasir kasir)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"UPDATE kasir SET password=@password, namaLengkap=@namaLengkap, status=@status 
                                     WHERE username=@username";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@password", kasir.Password);
                        cmd.Parameters.AddWithValue("@namaLengkap", kasir.NamaLengkap);
                        cmd.Parameters.AddWithValue("@status", kasir.Status);
                        cmd.Parameters.AddWithValue("@username", kasir.Username);
                        cmd.Parameters.AddWithValue("@mulai_bekerja", kasir.MulaiBekerja);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal update: " + ex.Message);
                return false;
            }
        }
    }
}
