using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementApp.Gateway;
using InventoryManagementApp.Model;

namespace InventoryManagementApp.Manager
{
    class UserManager
    {
        UserTypesGateway userTypesGateway=new UserTypesGateway();
        UserGateway userGateway=new UserGateway();
        public List<UserTypes> GetAllUserTypeses()
        {
            return userTypesGateway.GetAllUserTypeses();
        }

        public string AddUser(User user)
        {
            int rowAffected = userGateway.AddUser(user);
            if (rowAffected > 0)
            {
                return "Add success";
            }
            else
            {
                return "add failed";
            }
        }
    }
}
