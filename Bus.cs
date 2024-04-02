using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Bus : Vehicle
    {
        private int _passengerCount;

        public int PassengerCount
        {
            get { return _passengerCount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Passenger count cannot be negative.");
                }
                _passengerCount = value;
            }
        }

        public Bus(int passengerCount, string color, int year) : base(color, year)
        {
            if (passengerCount < 0)
            {
                throw new ArgumentException("Passenger count must be non-negative.");
            }

            PassengerCount = passengerCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Bus - Passenger Count: {PassengerCount}, Color: {Color}, Year: {Year}");
        }
    }
}
