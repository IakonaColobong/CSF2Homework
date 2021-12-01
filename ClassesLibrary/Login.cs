using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Login
    {
        //Frugal / Fields  --- this is the order you generally find them in class  Files. 
        private string _userName;
        private string _passWord;

        //People / Properties

        public string UserName
        {

            get { return _userName; }
            set { _userName = value; }
        }//end UserName

        public string PassWord
        {

            get { return _passWord; }
            set { _passWord = value; }
        }//end login

        //Collect / Constructors (ctors)

        public Login(string UserName, string PassWord)
        {
            UserName = UserName;
            PassWord = PassWord;

        }//end Constructors
        //Money / Methods
        public Login() { }
        public override string ToString()
        {
            return string.Format($"User Name: {UserName}\n" +
                                 $"Password: {PassWord}\n");
                                 

        }//end methods

    }

}


