using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    //RentalAgency class to manage the rental agency's fleet of vehicles
    public class RentalAgency
    {
        //List to store instances of vehicles
        private List<Vehicle> fleet;

        //Property to track the total revenue earned by the rental agency
        public decimal TotalRevenue { get; set; }

        //Constructor to initialize 
        public RentalAgency()
        {
            fleet = new List<Vehicle>();
            TotalRevenue = 0;
        }

        //To add vehicles to the fleet
        public void AddVehicle(Vehicle vehicle)
        {
            fleet.Add(vehicle);
            Console.WriteLine("{0} added to fleet.", vehicle.Model);
        }

        //To remove vehicles from the fleet
        public void RemoveVehicle(Vehicle vehicle)
        {
            if (fleet.Contains(vehicle))
            {
                fleet.Remove(vehicle);
                Console.WriteLine("{0} removed from fleet.", vehicle.Model);
            }
            else
            {
                Console.WriteLine("{0} not found in fleet.", vehicle.Model);

            }

        }

        //To rent vehicles
        public void RentVehicle(Vehicle vehicle)
        {
            if (fleet.Contains(vehicle))
            {
                TotalRevenue += vehicle.RentalPrice;
                fleet.Remove(vehicle);
                Console.WriteLine("{0} rented out.", vehicle.Model);
            }
            else
            {
                Console.WriteLine("{0} not available for rent.", vehicle.Model);
            }
        }

        //To display current fleet
        public void DisplayFleet()
        {
            Console.WriteLine("Current Fleet:");
            foreach (Vehicle vehicle in fleet)
            {
                vehicle.DisplayDetails();
                Console.WriteLine();
            }
        }
    }
}
