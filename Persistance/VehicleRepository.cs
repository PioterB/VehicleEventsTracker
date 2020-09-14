using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistance
{
    public class VehicleRepository : IVehicleRepository
    {
        private List<Vehicle> _vehicles = new List<Vehicle>();
               
        public Vehicle Add(Vehicle newItem)
        {
            _vehicles.Add(newItem);
            return newItem;
        }

        public Vehicle Get(int id)
        {
            return _vehicles.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<Vehicle> Load()
        {
            return _vehicles.ToArray();
        }
    }
}
