﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
    internal class Car
    {
        //properties
        public string make {  get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public decimal price { get; set; }

        //what if we made the constructors private?
        //constructor
        public Car(string _make, string _model, int _year, decimal _price)
        {
            make = _make;
            model = _model;
            year = _year;
            price = _price;
        }

        //defualt constructor
        public Car()
        {
            make = "";
            model = "";
            year = -1;
            price = -1;
        }

        //methods
        public virtual string ToString()
        {
            return string.Format("{0, -10} {1, -18} {2, 5} {3, 15:C}", make, model, year, price);
        }

        public static void ListCars(List<Car>Cars)
        {
            for (int i = 0; i < Cars.Count(); i++)
            {
                Console.WriteLine($"{i + 1}- {Cars[i].ToString()}");
            }

        }

        public static void Remove(int num, List<Car>Cars )
        {
            Cars.RemoveAt(num);
        }
    }
}
