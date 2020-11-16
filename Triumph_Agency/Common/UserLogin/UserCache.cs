using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.UserLogin
{
    public static class UserCache
    {
        public static int IDUser { get; set; }
        public static string LastName { get; set; }
        public static string FirstName { get; set; }
        public static string Position { get; set; }
        public static string Email { get; set; }
    }
}
