using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWordService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            return "Eredmény: " + value;
        }



        public string SayHello()
        {
            return "Hello Word!";
        }

        public HelloObject GetModelObject(string id)
        {
            HelloObject helloObject = new HelloObject();

            if (int.Parse(id) > 0)
            {
                helloObject.happyHello = true;
                helloObject.helloMessage = "True";
            }
            else
            {
                helloObject.happyHello = false;
                helloObject.helloMessage = "False";
            }

            return helloObject;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> lista = new List<Customer>();

            Connect c = new Connect();

            string sql = "SELECT * FROM customer";
            MySqlCommand cmd = new MySqlCommand(sql, c.connection);

            MySqlDataReader result = cmd.ExecuteReader();

            while (result.Read())
            {
                Customer cust = new Customer();
                cust.Id = int.Parse(result.GetValue(0).ToString());
                cust.Name = result.GetValue(1).ToString();
                cust.City = result.GetValue(2).ToString();
                lista.Add(cust);
            }

            return lista;
        }
        public Customer GetCustomer(string id)
        {
            Connect c = new Connect();

            string sql = "SELECT * FROM customer WHERE id=" + id;
            MySqlCommand cmd = new MySqlCommand(sql, c.connection);

            MySqlDataReader result = cmd.ExecuteReader();
            result.Read();

            Customer cust = new Customer();
            cust.Id = int.Parse(result.GetValue(0).ToString());
            cust.Name = result.GetValue(1).ToString();
            cust.City = result.GetValue(2).ToString();

            return cust;
        }
        public Customer AddCustomer(Customer info)
        {
            Connect c = new Connect();
            string sql = "INSERT INTO `customer`(`name`, `city`) VALUES ('" + info.Name + "','" + info.City + "')";
            MySqlCommand cmd = new MySqlCommand(sql, c.connection);

            cmd.ExecuteNonQuery();

            Customer cust = new Customer();
            cust.Id = info.Id;
            cust.Name = info.Name;
            cust.City = info.City;

            return cust;           
        }

        public string UpdateCustomer(Customer info)
        {
            Connect c = new Connect();

            string sql = "UPDATE `customer` SET `name`='"+info.Name+"',`city`='"+info.City+"' WHERE id=" + info.Id;
            MySqlCommand cmd = new MySqlCommand(sql, c.connection);

            MySqlDataReader result = cmd.ExecuteReader();

            return "Rekord frissítve!";

        }

        public string DeleteCustomer(Customer info)
        {
            Connect c = new Connect();

            string sql = "DELETE FROM `customer` WHERE id="+info.Id;
            MySqlCommand cmd = new MySqlCommand(sql, c.connection);

            MySqlDataReader result = cmd.ExecuteReader();

            return "Rekord törölve!";

        }
    }
}
