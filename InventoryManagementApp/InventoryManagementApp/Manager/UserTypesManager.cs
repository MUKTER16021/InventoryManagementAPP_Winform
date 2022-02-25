using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementApp.Gateway;
using InventoryManagementApp.Model;

namespace InventoryManagementApp.Manager
{
    class UserTypesManager
    {
        UserTypesGateway userTypesGateway=new UserTypesGateway();

        public string AddUserTypes(UserTypes userTypes)
        {
            bool isNIDExist = userTypesGateway.UserTypeExist(userTypes);
            if (isNIDExist)
            {
                return "Type Already Exist";
            }
            int rowAffected = userTypesGateway.AddUserType(userTypes);
            if (rowAffected > 0)
            {
                return " Add Success";
            }
            return "Add Failed";
        }

        public List<UserTypes> GetAllUserTypeses()
        {
            return userTypesGateway.GetAllUserTypeses();
        }

        public string DeleteTypes(int id)
        {
            int rowAffected = userTypesGateway.DeleteType(id);
            if (rowAffected > 0)
            {
                return " Delete SuccessFully";
            }
            return "Delete Failed";

        }



    }
}
