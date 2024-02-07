using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    internal class UsedCar : Car
    {
        //properties
        protected double mileage;

        //constructor
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage) : base (_make, _model, _year, _price) 
        {
            mileage = _mileage;
        }

        //methods
        public override string ToString()
        {
            return string.Format("{0, -10} {1, -18} {2, 5} {3, 15:C} {4, 7}", make, model, year, price, mileage);
        }

    }
}
