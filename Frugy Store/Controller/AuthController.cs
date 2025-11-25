using Frugy_Store.Database;
using Frugy_Store.Helpers;
using Frugy_Store.Model;
using Npgsql;

namespace Frugy_Store.Controller
{
    public class AuthController
    {
        private DbContext _dbContext;
        public AuthController()
        {
            _dbContext = new DbContext();
        }

        public M_Akun Login(M_Akun akun)
        {
            try
            {
                using (var conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                                    SELECT role, nama_lengkap, username, password 
                                    FROM akun WHERE username = @username AND password = @password";

                    string hashedPassword = PasswordHelper.HashPassword(akun.Password);

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", akun.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (var read = cmd.ExecuteReader())
                        {
                            if (read.Read())
                            {
                                string role = read.GetString(0);
                                RoleAkun roleEnum = (RoleAkun)Enum.Parse(typeof(RoleAkun), role);

                                M_Akun loggedInAkun = new M_Akun
                                {
                                    Role = roleEnum,
                                    NamaLengkap = read.GetString(1),
                                    Username = read.GetString(2),
                                    Password = read.GetString(3),
                                };
                                return loggedInAkun;
                            }
                            return null;

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        public bool TambahAkun(M_Akun akun)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(_dbContext.connStr))
                {
                    conn.Open();
                    string query = @"
                                    INSERT INTO akun (nama_lengkap, username, password, role) 
                                    VALUES (@nama_lengkap, @username, @password, @role)";

                    string hashedPassword = PasswordHelper.HashPassword(akun.Password);

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nama_lengkap", akun.NamaLengkap);
                        cmd.Parameters.AddWithValue("@username", akun.Username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);
                        cmd.Parameters.AddWithValue("@role", akun.Role.ToString());

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
