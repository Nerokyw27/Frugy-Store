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
            Env.Load();
            connStr = Environment.GetEnvironmentVariable("CONN_STR");
        }
    }
}
