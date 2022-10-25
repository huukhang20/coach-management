using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class Login
    {
        private static bool _isAdmin;
        public static bool IsAdmin { get { return _isAdmin; } }

        public static bool Authenticate(string username, string password)
        {
            string adminUsername = "admin";
            string adminPassword = "admin";
            string memUsername = "member";
            string memPassword = "member";
            if (adminUsername.Equals(username, StringComparison.OrdinalIgnoreCase)
                && adminPassword.Equals(password))
            {
                _isAdmin = true;
                return true;
            }
            else if (memUsername.Equals(memUsername, StringComparison.OrdinalIgnoreCase)
                && memPassword.Equals(memPassword))
            {
                _isAdmin = false;
                return true;
            }
            return false;
        }
    }
}
