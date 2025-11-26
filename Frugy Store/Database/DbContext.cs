using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Database
{
    public class DbContext
    {
        public string? connStr;

        public DbContext()
        {
            try
            {
                // Coba baca dari .env
                Env.Load();
                connStr = Environment.GetEnvironmentVariable("CONN_STR");

                if (string.IsNullOrEmpty(connStr))
                {
                    connStr =
                        "Host=ep-broad-surf-a1u2vb8a-pooler.ap-southeast-1.aws.neon.tech;" +
                        "Port=5432;" +
                        "Database=neondb;" +
                        "Username=neondb_owner;" +
                        "Password=npg_5wngDM7tmGTl;" +
                        "SSL Mode=Require;" +
                        "Trust Server Certificate=true;";
                }
            }
            catch
            {
                connStr =
                    "Host=ep-broad-surf-a1u2vb8a-pooler.ap-southeast-1.aws.neon.tech;" +
                    "Port=5432;" +
                    "Database=neondb;" +
                    "Username=neondb_owner;" +
                    "Password=npg_5wngDM7tmGTl;" +
                    "SSL Mode=Require;" +
                    "Trust Server Certificate=true;";
            }
        }
    }
}
