using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMSAPP.Shared
{
    public class UserModel
    {
        public int? UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int? WBId { get; set; }
       // public decimal? VehicleGKW { get; set; }
        public int? IsActive { get; set; }

        public int? RoleId { get; set; }
    }
}
