using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Web;
using AuthenticationWCF_Service.Models;

namespace AuthenticationWCF_Service.App_Code.Authentication
{
    public class CustomValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            AccountModel am = new AccountModel();
            if (am.login(userName, password))
                return;
            throw new SecurityTokenException("Nincs regisztrálva!");
        }
    }
}