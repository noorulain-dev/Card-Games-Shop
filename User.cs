using System;
using System.Collections.Generic;

namespace Passtask3
{
    /// <summary>
    /// This is the parent class of all users of the system
    /// </summary>
    public abstract class User{
        private string m_Name;
        private string m_Password;

        /// <summary>
        /// Make a User account by passing the credentials
        /// </summary>
        /// <param name="name">The user name that will be used for login</param>
        /// <param name="password">The password of the user</param>
        public User(string name, string password){
            m_Name = name;
            m_Password = password;
        }

        /// <summary>
        /// This methods takes care of the login of a user and handles the input and output
        /// </summary>
        /// <returns>Return a boolean that determines whether the login was successful or not</returns>
        public bool Login(){
            string _name = "";
            string _password = "";

            Console.Write("Enter username:");
            _name = Console.ReadLine();
            Console.Write("Enter password:");
            _password = Console.ReadLine();

            if (m_Name == _name && m_Password == _password){
                Console.WriteLine("Logged in successfully.");
                return true;
            } else{
                Console.WriteLine("Login failed.");
                return false;
            }
        }

        public abstract void ViewCustomerDetails();
    }
}