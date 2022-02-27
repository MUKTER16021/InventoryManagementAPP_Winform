using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementApp.Model;

namespace InventoryManagementApp.Gateway
{
    class UserGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionUtility"].ConnectionString;
        private SqlCommand command;
        SqlConnection connection;
        private string query;
        private int rowAffected;

        public int AddUser(User user)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "INSERT INTO User_T (User_Name,Email,Password,User_Type_Id,Status,Picture)" +
                    " VALUES('" + user.UserName + "','" + user.EmailAddress + "','" + user.Password + "','" + user.UserTypeId + "','" + user.Status + "','" + user.Photo + "')";
            command = new SqlCommand(query, connection);
            rowAffected = command.ExecuteNonQuery();
            return rowAffected;
        }
        //public List<UserTypes> GetAllUserTypeses()
        //{

        //}
    }
}
