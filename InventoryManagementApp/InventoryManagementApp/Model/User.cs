using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApp.Model
{
    class User
    {
        public  int Id { get; set; }
        public  string UserName { get; set; }
        public  string EmailAddress { get; set; }
        public string Password { get; set; }
        public int UserTypeId{ get; set; }
        public string Status { get; set; }
        public  byte[] Photo { get; set; }

    }
}
