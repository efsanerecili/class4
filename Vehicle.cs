using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal abstract class Vehicle
    {
          public string Color { get; }
    public int Year { get; }

    public Vehicle(string color, int year)
    {
        if (year <= 0)
        {
            throw new ArgumentException("Year must be specified.");
        }

        Color = color;
        Year = year;
    }

    public abstract void ShowInfo();
       
    }
}
