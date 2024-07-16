using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    //Truck Class that inherits from the Vehicle class.
    public class Truck : Vehicle
    {
        //Additional properties specific to Truck
        private int Capacity {  get; set; }
        private string TruckType {  get; set; }
        private bool FourWheelDrive {  get; set; }

        //Constructor using base class properties
        public Truck(string model, string manufacturer, int year, decimal rentalPrice, int capacity, string truckType, bool fourWheelDrive) : base(model, manufacturer, year, rentalPrice)
        {
        }

        //Override the DisplayDetails() method to display the Truck's details
        //including both common vehicle properties and Truck-specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Capacity: {0} tons, Truck Type: {1}, Four-Wheel Drive: {2}", Capacity, TruckType, FourWheelDrive);
        }
    }
}
