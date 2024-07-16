using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    //Car Class that inherits from the Vehicle class.
    public class Car : Vehicle
    {
        //Additional properties specific to cars
        private int Seats { get; set; }
        private string EngineType { get; set; }
        private string Transmission {  get; set; }
        private bool Convertible {  get; set; }

        //Constructor using base class properties
        public Car(string model, string manufacturer, int year, decimal rentalPrice, int seats, string EngineType, string transmission, bool convertible) : base(model, manufacturer, year, rentalPrice)
        {
        }

        //Override the DisplayDetails() method to display the car's details
        //including both common vehicle properties and car-specific properties
        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Seats: {0}, Engine Type: {1}, Transmission: {2}, Convertible: {3}", Seats, EngineType, Transmission, Convertible);
        }

    }
}
