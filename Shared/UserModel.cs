using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSAPP.Shared
{
    internal class UserModel
    {
        public int? UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? WBId { get; set; }
       // public decimal? VehicleGKW { get; set; }
        public int? IsActive { get; set; }
    }
}
