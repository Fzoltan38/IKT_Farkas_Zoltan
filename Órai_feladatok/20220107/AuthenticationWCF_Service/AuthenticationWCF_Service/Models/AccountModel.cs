using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthenticationWCF_Service.Models
{
    public class AccountModel
    {
        private List<Account> listAccount = new List<Account>();

        public AccountModel()
        {
            listAccount.Add(new Account { Username = "acc1", Password = "123" }) ;
            listAccount.Add(new Account { Username = "acc2", Password = "123" });
            listAccount.Add(new Account { Username = "acc3", Password = "123" });
        }

        public bool login(string username, string password)
        {
            return listAccount.Count(acc => acc.Username.Equals(username) &&
            acc.Password.Equals(password)) > 0;
        }
    }
}