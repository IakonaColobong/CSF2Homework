using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
    public class Vehicle
    {
        //Frugal / Fields  --- this is the order you generally find them in class  Files. 
        private string _make;
        private string _model;
        private int _year;
        private float _weight;

        //People / Properties
        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }//end make

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }//end Model

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }//end Year

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }//end weight


        //Collect / Constructors (ctors)

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }
        //Money / Methods 
        public Vehicle() { }
        public override string ToString()
        {
            return string.Format($"vehicle Make: {Make}\n" +
                                 $"Vehicle Model: {Model}\n" +
                                 $"Vehicle Year: {Year}\n" +
                                 $"GVW: {Weight}\n");


        }

    }
   
}
