using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(string make, string model, string color, string vin, int year, int coolness, bool isRunning)
        {
            Make = make;
            Model = model;
            Color = color;
            VIN = vin;
            Year = year;
            CoolnessFactor = coolness;
            IsRunning = isRunning;
        }

        public String Make { get; set; }
        public String Model { get; set; }
        public String Color { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public int CoolnessFactor { get; set; }
        public bool IsRunning { get; set; }
    }
}
