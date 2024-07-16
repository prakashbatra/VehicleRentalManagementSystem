using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    //Motorcycle Class that inherits from the Vehicle class.
    public class Motorcycle : Vehicle
    {
        //Additional properties specific to Motorcycle
        private int EngineCapacity { get; set; }
        private string FuelType { get; set; }
        private bool HasFairing {  get; set; }

        //Constructor using base class properties
        public Motorcycle(string model, string manufacturer, int year, decimal rentalPrice, int engineCapacity, string fuelType, bool hasFairing) : base (model, manufacturer, year, rentalPrice)
        { 
        }

        //Override the DisplayDetails() method to display the Motorcycle's details
        //including both common vehicle properties and Motorcycle-specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Engine Capacity: {0} cc, Fuel Type: {1}, Has Fairing: {2}", EngineCapacity, FuelType, HasFairing);
        }
    }
}
