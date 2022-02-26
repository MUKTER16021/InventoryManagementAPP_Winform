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
    class UserTypesGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionUtility"].ConnectionString;
        private SqlCommand command;
        SqlConnection connection;
        private string query;
        private int rowAffected;

        public int AddUserType(UserTypes userTypes)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "INSERT INTO User_Type_T (User_Type,User_Status)" +
                    " VALUES('"+userTypes.UserType+"','"+userTypes.Status+"')";
            command = new SqlCommand(query, connection);
            rowAffected = command.ExecuteNonQuery();
            return rowAffected;
        }

        public bool UserTypeExist(UserTypes userTypes)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM User_Type_T WHERE User_Type='" + userTypes.UserType + "' AND  Id <>'" + userTypes.Id + "' ";
            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            connection.Close();
            return isExist;

        }

        public List<UserTypes> GetAllUserTypeses()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM User_Type_T ";
            command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            List<UserTypes> typeses = new List<UserTypes>();
            while (reader.Read())
            {
                UserTypes userTypes = new UserTypes();
                userTypes.UserType = reader["User_Type"].ToString();
                userTypes.Status = reader["User_Status"].ToString();
                userTypes.Id = Convert.ToInt32(reader["Id"]);
                typeses.Add(userTypes);
            }
            reader.Close();
            connection.Close();
            return typeses;
        }

        public int DeleteType(int id)
        {
            int rowAffected;
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "DELETE FROM User_Type_T WHERE Id='" + id + "' ";
            command = new SqlCommand(query, connection);
            rowAffected = command.ExecuteNonQuery();
            return rowAffected;
        }

        public int UpdateUserType(UserTypes type)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "UPDATE User_Type_T SET User_Type='" + type.UserType + "', User_Status='" + type.Status + "'WHERE Id='" + type.Id + "' ";

            command = new SqlCommand(query, connection);
            rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }
    }
}
