using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    //Abstract Vehicle class to represent a generic vehicle available for rental
    public abstract class Vehicle
    {
        //Properties
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public decimal RentalPrice { get; set; }

        //Constructor
        public Vehicle(string model, string manufacturer, int year, decimal rentalPrice)
        {
            Model = model;
            Manufacturer = manufacturer;
            Year = year;
            RentalPrice = rentalPrice;
        }

        // To display the vehicle's details.
        public virtual void DisplayDetails()
        {
            Console.WriteLine("Model: {0}, Manufacturer: {1}, Year: {2}, Rental Price: {3}", Model, Manufacturer, Year, RentalPrice);
        }
    }
}
