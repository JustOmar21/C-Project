using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project
{
    internal static class UserSession
    {
        public static int? Id { get; set; }

        public static void ClearUserSession()
        {
            Id = 0;
        }
    }
}
