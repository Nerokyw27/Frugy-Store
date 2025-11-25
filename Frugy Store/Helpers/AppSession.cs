using Frugy_Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frugy_Store.Helpers
{
    public static class AppSession
    {
        public static M_Akun CurrentUser { get; private set; }
        public static bool IsAuthenticated => CurrentUser != null;

        public static void SetUser(M_Akun user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
