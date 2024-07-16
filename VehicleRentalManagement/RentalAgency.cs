using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    public class RentalAgency
    {
        private List<Vehicle> fleet;
        public decimal TotalRevenue { get; set; }

        public RentalAgency()
        {
            fleet = new List<Vehicle>();
            TotalRevenue = 0;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            fleet.Add(vehicle);
            Console.WriteLine("{0} added to fleet.", vehicle.Model);
        }

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
