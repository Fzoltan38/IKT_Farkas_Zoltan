using MySql.Data.MySqlClient;
using System.Data;

namespace PayMentRESTService
{
    public class PayMentService : IPayMentService
    {
        public void AddPayee(string Name, string City)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=payment;UID=root;PASSWORD=;SslMode=None;");
            con.Open();
            
            string sql = "INSERT INTO `customer`(`name`, `city`) VALUES ('"+Name+"','"+City+"')";
            MySqlCommand cmd = new MySqlCommand(sql,con);

            cmd.ExecuteNonQuery();
        }
        public string PayBill(string PayId)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=payment;UID=root;PASSWORD=;SslMode=None;");
            con.Open();

            string sql = "SELECT * FROM customer WHERE id="+PayId;
            MySqlCommand cmd = new MySqlCommand(sql, con);

            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            con.Close();

        }

        public void RemovePayee(string Id)
        {
            MySqlConnection con = new MySqlConnection("SERVER=localhost;DATABASE=payment;UID=root;PASSWORD=;SslMode=None;");
            con.Open();

            string sql = "DELETE FROM `customer` WHERE id=" + Id;
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void UpdateBillPayment(string PayId, string TransId)
        {
            //write database related update logic here.    
        }
    }
}