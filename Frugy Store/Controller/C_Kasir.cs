using Frugy_Store.Database;
using Frugy_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Frugy_Store.Controller
{
    public class C_Kasir
    {
        private DbContext _dbContext;

        public C_Kasir()
        {
            _dbContext = new DbContext();
        }

        // Tambah akun kasir
        public bool TambahAkunKasir(M_Akun akun)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO akun (nama_lengkap, username, password, email, no_hp, role, status)
                        VALUES (@nama_lengkap, @username, @password, @email, @no_hp, @role, @status)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_lengkap", akun.NamaLengkap ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@username", akun.Username ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@password", akun.Password ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", akun.Email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@no_hp", akun.NoHp ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@role", akun.Role.ToString());
                        cmd.Parameters.AddWithValue("@status", true);

                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tambah akun kasir gagal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Ambil semua akun kasir
        public List<M_Akun> GetAllKasir()
        {
            List<M_Akun> kasirList = new List<M_Akun>();

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT akun_id, nama_lengkap, username, email, no_hp, role, status
                        FROM akun
                        WHERE role = @role AND status = true
                        ORDER BY akun_id ASC";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@role", RoleAkun.kasir.ToString()); // konsisten dengan enum (lowercase "kasir")
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                kasirList.Add(new M_Akun
                                {
                                    AkunId = reader["akun_id"] != DBNull.Value ? Convert.ToInt32(reader["akun_id"]) : 0,
                                    NamaLengkap = reader["nama_lengkap"] != DBNull.Value ? reader["nama_lengkap"].ToString() : "",
                                    Username = reader["username"] != DBNull.Value ? reader["username"].ToString() : "",
                                    Email = reader["email"] != DBNull.Value ? reader["email"].ToString() : "",
                                    NoHp = reader["no_hp"] != DBNull.Value ? reader["no_hp"].ToString() : "",
                                    Role = reader["role"] != DBNull.Value ? (RoleAkun)Enum.Parse(typeof(RoleAkun), reader["role"].ToString()) : RoleAkun.kasir,
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil data kasir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return kasirList;
        }

        // Ambil akun kasir berdasarkan ID
        public M_Akun GetKasirById(int akunId)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        SELECT akun_id, nama_lengkap, username, email, no_hp, role, status
                        FROM akun
                        WHERE akun_id = @akun_id AND role = @role AND status = true
                        LIMIT 1";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@akun_id", akunId);
                        cmd.Parameters.AddWithValue("@role", RoleAkun.kasir.ToString());

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new M_Akun
                                {
                                    AkunId = reader["akun_id"] != DBNull.Value ? Convert.ToInt32(reader["akun_id"]) : 0,
                                    NamaLengkap = reader["nama_lengkap"] != DBNull.Value ? reader["nama_lengkap"].ToString() : "",
                                    Username = reader["username"] != DBNull.Value ? reader["username"].ToString() : "",
                                    Email = reader["email"] != DBNull.Value ? reader["email"].ToString() : "",
                                    NoHp = reader["no_hp"] != DBNull.Value ? reader["no_hp"].ToString() : "",
                                    Role = reader["role"] != DBNull.Value ? (RoleAkun)Enum.Parse(typeof(RoleAkun), reader["role"].ToString()) : RoleAkun.kasir,
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal mengambil data kasir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        // Update akun kasir
        public bool UpdateKasir(M_Akun akun)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        UPDATE akun
                        SET nama_lengkap = @nama_lengkap,
                            username = @username,
                            email = @email,
                            no_hp = @no_hp,
                            role = @role
                        WHERE akun_id = @akun_id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_lengkap", akun.NamaLengkap ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@username", akun.Username ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@email", akun.Email ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@no_hp", akun.NoHp ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@role", akun.Role.ToString());
                        cmd.Parameters.AddWithValue("@akun_id", akun.AkunId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memperbarui akun kasir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Hapus akun kasir (soft delete)
        public bool DeleteKasir(int akunId)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                        UPDATE akun
                        SET status = false
                        WHERE akun_id = @akun_id";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@akun_id", akunId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghapus akun kasir: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
