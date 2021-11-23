using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WCfServiceForInsert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string InsertUserDetails(UserDetails userInfo);
        [OperationContract]
        DataSet SelectUserDetails();
        [OperationContract]
        bool DeleteUserDetails(UserDetails userInfo);
        [OperationContract]
        DataSet UpdateUserDetails(UserDetails userInfo);
        [OperationContract]
        void UpdateRegistrationTable(UserDetails userInfo);
    }

    [DataContract]
    public class UserDetails
    {
        int userid;
        string username;
        string password;
        string country;
        string email;

        [DataMember]
        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }
        [DataMember]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [DataMember]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
