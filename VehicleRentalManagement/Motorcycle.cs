using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity { get; set; }
        public string FuelType { get; set; }
        public bool HasFairing {  get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Engine Capacity: {0} cc, Fuel Type: {1}, Has Fairing: {2}", EngineCapacity, FuelType, HasFairing);
        }
    }
}
