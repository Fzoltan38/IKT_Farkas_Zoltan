using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCfServiceForInsert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        
        public DataSet SelectUserDetails()
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=registration;UID=root;PASSWORD=;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Select * from RegistrationTable", con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public bool DeleteUserDetails(UserDetails userInfo)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=registration;UID=root;PASSWORD=;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("delete from RegistrationTable where UserID=@UserID", con);
            cmd.Parameters.AddWithValue("@UserID", userInfo.UserID);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        public DataSet UpdateUserDetails(UserDetails userInfo)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=registration;UID=root;PASSWORD=;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from RegistrationTable where UserID=@UserID", con);
            cmd.Parameters.AddWithValue("@UserID", userInfo.UserID);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();
            return ds;
        }
        public void UpdateRegistrationTable(UserDetails userInfo)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=registration;UID=root;PASSWORD=;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("update RegistrationTable set UserName=@UserName,Password=@Password,Country=@Country, Email=@Email where UserID=@UserID", con);
            cmd.Parameters.AddWithValue("@UserID", userInfo.UserID);
            cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
            cmd.Parameters.AddWithValue("@Password", userInfo.Password);
            cmd.Parameters.AddWithValue("@Country", userInfo.Country);
            cmd.Parameters.AddWithValue("@Email", userInfo.Email);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public string InsertUserDetails(UserDetails userInfo)
        {
            string Message;
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=registration;UID=root;PASSWORD=;");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into RegistrationTable(UserName,Password,Country,Email) values(@UserName,@Password,@Country,@Email)", con);
            cmd.Parameters.AddWithValue("@UserName", userInfo.UserName);
            cmd.Parameters.AddWithValue("@Password", userInfo.Password);
            cmd.Parameters.AddWithValue("@Country", userInfo.Country);
            cmd.Parameters.AddWithValue("@Email", userInfo.Email);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.UserName + " Details inserted successfully";
            }
            else
            {
                Message = userInfo.UserName + " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }
    }
}
