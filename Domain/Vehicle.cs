using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Vehicle
    {
        public Vehicle(string make, string model, string name)
        {
            Make = make;
            Model = model;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
        public string Model { get; }
        public string Make { get; }
        public Vin Vin { get; } 
    }
}
