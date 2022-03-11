using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSAPP.Server.Repository
{
    public static class GlobalAccess
    {
        public static int UserID {get;set;}
        public static string Username { get; set; }
        public static string UserEmail { get; set; }
        public static int Role { get; set; }
        public static int WBID { get; set; }

    }
}
