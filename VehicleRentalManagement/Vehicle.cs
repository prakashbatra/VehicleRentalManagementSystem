using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    public class Vehicle
    {
        private string Model { get; set; }
        private string Manufacturer { get; set; }
        private int Year { get; set; }
        private decimal RentalPrice { get; set; }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice:C}");
        }
    }
}
