using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Car:Vehicle

    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        private int _maxSpeed;

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set { _maxSpeed = value; }
        }

        public Car(string brand, string model, int maxSpeed, string color, int year) : base(color, year)
        {
            if (string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(model))
            {
                throw new ArgumentException("Brand and Model must be specified.");
            }

            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Car - Brand: {Brand}, Model: {Model}, Max Speed: {MaxSpeed}, Color: {Color}, Year: {Year}");
        }
    }


}

