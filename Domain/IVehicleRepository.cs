using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> Load();
        Vehicle Get(int id);
        Vehicle Add(Vehicle newItem);
    }
}
