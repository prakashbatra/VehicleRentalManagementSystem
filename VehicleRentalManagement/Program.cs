using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a new RentalAgency instance
            RentalAgency agency = new RentalAgency();

            // Create various Vehicle instances (Car, Truck, Motorcycle)
            Vehicle car1 = new Car ("Model S", "Maruti", 2023, 150, 4, "Diesel", "Manual", false);
            Vehicle car2 = new Car("Model P", "Honda", 2019, 100, 4, "Gas", "Auto", true);
            Vehicle truck1 = new Truck ("F-150", "Tata", 2021, 120, 5, "Pickup", true );
            Vehicle bike1 = new Motorcycle ("bajaj","Super",2020,85,120,"Petrol",true);

            // Add vehicles to the rental agency's fleet
            agency.AddVehicle(car1);
            agency.AddVehicle(car2);
            agency.AddVehicle(truck1);
            agency.AddVehicle(bike1);
            Console.WriteLine();// Print a blank line for better readability

            // Display the current fleet of vehicles
            agency.DisplayFleet();

            // Rent out a vehicle (car1)
            agency.RentVehicle(car1);
            Console.WriteLine("Total Revenue : {0}", agency.TotalRevenue);// Display total revenue after renting car1
            Console.WriteLine(); // Print a blank line for better readability

            // Display the current fleet of vehicles
            agency.DisplayFleet();

            // Rent out a vehicle (truck1)
            agency.RentVehicle(truck1);
            Console.WriteLine("Total Revenue : {0}", agency.TotalRevenue);// Display total revenue after renting truck1
            Console.WriteLine(); // Print a blank line for better readability

            // Display the current fleet of vehicles
            agency.DisplayFleet();

            //Remove vehicle (car2) from fleet
            agency.RemoveVehicle(car2);
            Console.WriteLine(); // Print a blank line for better readability

            // Display the current fleet of vehicles
            agency.DisplayFleet();

            Console.ReadLine();//To keep the console in display

        }
    }
}
