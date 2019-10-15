using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Requests.Glpi
{
    public class LoginGlpiRequest
    {
        public string login { get; private set; }
        public string password { get; private set; }

        public LoginGlpiRequest(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
}
