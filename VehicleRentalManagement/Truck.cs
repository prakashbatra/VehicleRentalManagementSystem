using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    public class Truck : Vehicle
    {
        public int Capacity {  get; set; }
        public string TruckType {  get; set; }
        public bool FourWheelDrive {  get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.Write("Capacity: {0} tons, Truck Type: {1}, Four-Wheel Drive: {2}", Capacity, TruckType, FourWheelDrive);
        }
    }
}
