using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAss03.Q2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private readonly string[]? Roles = {"user", "admin", "user" };
        private readonly string[]? UserNames = {"seif", "ali","amr"};
        private readonly string[]? Passwords = {"123", "456", "789"};
        public bool AuthenticateUser(string username, string password)
        {

            for(int i = 0; i < UserNames.Length; i++)
            {
                if (UserNames[i].Equals(username)&& Passwords[i].Equals(password))
                    return true;
            }
            return false;
        }

        public bool AuthorizeUser(string? username, string? role)
        {
            for (int i = 0; i < UserNames?.Length; i++)
            {
                if (UserNames[i].Equals(username) && Roles[i].Equals(role))
                    return true;
            }
            return false;
        }
    }
}
