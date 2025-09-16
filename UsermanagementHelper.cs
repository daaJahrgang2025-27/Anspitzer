using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Anspitzer
{
    internal class UsermanagementHelper
    {
        public UsermanagementHelper()
        {
            System.Console.WriteLine("UsermanagementHelper initialized.");
        }

        private class User
        {
            public string Username { get; set; }
            protected notReallyPassword Password { get; set; }
            public string Role { get; set; }
            public User(string username, string role)
            {
                Username = username;
                Password = new notReallyPassword(Console.ReadLine());
                Role = role;
            }
        }

        private class notReallyPassword
        {
            private string hashedPassword;
            public notReallyPassword(string parameterPassword)
            {
                //logic for hashing the password can be added here
                parameterPassword = this.hash(parameterPassword);
            }
            public bool Validate(string userInput)
            {
                switch (userInput)
                {
                    case null:
                        return false;
                        break;
                    case "":
                        return false;
                        break;
                    default:

                        if (this.hash(userInput) == hashedPassword)
                        {
                            generateToken();
                            return true;
                        }
                        else
                        {
                            generateToken();
                            return false;
                        }
                        break;
                }
            }

            public string hash(string Password)
            {
                //dummy hash function by Ai
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(Password));
            }

            public Token generateToken()
            {
                return new Token(false);
            }
        }

        public static string GetUserRole(string username)
        {
            // Dummy implementation for demonstration purposes
            if (username == "admin")
            {
                return "Administrator";
            }
            else if (username == "user")
            {
                return "Standard User";
            }
            else
            {
                return "Guest";
            }
        }
    }
}
