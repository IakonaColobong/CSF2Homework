using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class ContactInfo
    {


        //Frugal / Fields  --- this is the order you generally find them in class  Files. 

        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;

        //People / Properties

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }//end
        public string City
        {
            get { return _city; }
            set { _city = value; }

        }//end
        public string State
        {
            get { return _state; }
            set { _state = value; }

        }//end
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }

        }//end
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }//end
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }//end

        //Collect / Constructors (ctors)
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }//end FQ Constructor

        public ContactInfo()
        {
        }
        
        //Money / Methods
        
        public override string ToString()
        {
            return string.Format($"Address: {StreetAddress}\n" +
                                 $"City: {City}\n" +
                                 $"State: {State}\n" +
                                 $"Zip: {Zip}\n" +
                                 $"Phone Number: {Phone}\n" +
                                 $"Email: {Email}\n");
        }
    }//end Class
}//end Namespace
