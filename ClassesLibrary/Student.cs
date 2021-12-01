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
        private string _id;
        private float _gpa;
        

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

        public string Id
        {

            get { return _id; }
            set { _id = value; }
        }//end ID

        public float Gpa
        {
            get { return _gpa; }
            set { _gpa = value; }

        }//end GPA

        //Collect / Constructors (ctors)

        public Student(string firstName, string lastName, string id, int gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = _id;
            Gpa = _gpa;
        }//end FQ Constructor

        public Student()
        {
        }

        //Money / Methods

        public override string ToString()
        {
            return string.Format($"First Name: {FirstName}\n" +
                                 $"Last Name: {LastName}\n" +
                                 $"Id: {Id}\n" +
                                 $"GPA: {Gpa}\n");
                                

        }//end methods
    }//end class
}//end namespace
