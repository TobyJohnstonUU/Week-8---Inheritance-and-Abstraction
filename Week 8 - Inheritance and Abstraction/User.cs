using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class User
    {
        private int userID;
        private string userName;
        private string password;
        private string contactInfo;
        private bool isLoggedIn;

        public int UserID
        {
            get { return userID; } 
            set { userID = value; }
        }

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        User(int userID, string userName, string contactInfo, 
            string password, bool loggedIn)
        {
            UserID = userID;
            UserName = userName;
            Password = password;
            ContactInfo = contactInfo;
            IsLoggedIn = loggedIn;
        }

        public bool Login(string userName, string password)
        {
            if (userName == UserName && password == Password)
            {
                isLoggedIn = true;
                Console.WriteLine("Logged In");
            } else {
                isLoggedIn = false;
                Console.WriteLine("login failed, username or password is incorrect");
            }
            return IsLoggedIn;
        }
        
        public void Logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("Logged out succesfully");
            } else {
                Console.WriteLine("Already logged out");
            }
        }

        public void ControlDevice()
        {

        }
    }
}
