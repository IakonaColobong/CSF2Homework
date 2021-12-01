using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Student
    {
        //Frugal / Fields  --- this is the order you generally find them in class  Files. 

        private string _firstName;
        private string _lastName;

        //People / Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }//end firstname

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }//end lastname

        //Collect / Constructors (ctors)

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }//end FQ Constructor

        public Student()
        {
        }

        //Money / Methods

        public override string ToString()
        {
            return string.Format($"First Name: {FirstName}\n" +
                                 $"Last Name: {LastName}\n");
                                

        }//end methods
    }//end class
}//end namespace
