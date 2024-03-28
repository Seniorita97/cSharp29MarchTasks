using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class User
    {
        public string Name;
        public string UserName;
        public string Password;

        public User(string name, string userName, string password) 
        { 
            this.Name = name;
            this.UserName = userName;
            this.Password = password;
        }

        public bool IsPasswordValid()
        {
            if (this.Password.Length < 6) 
            {
                return false;
            }
            bool checkNum = false;
            foreach (char simvol in this.Password) 
            {
                if (char.IsDigit(simvol)) 
                {
                    checkNum = true;
                    break;
                }
            }
            if (!checkNum) 
            {
                return false;
            }
            if (this.Password.ToLower().Contains(this.Name.ToLower()))
            {
                return false ;
            }
            return true ;
        }
    }
}
