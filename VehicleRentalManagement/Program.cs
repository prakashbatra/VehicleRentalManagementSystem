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
            RentalAgency agency = new RentalAgency();
            Car car1 = new Car { Model = "Model S", Manufacturer = "Maruti", Year = 2023, RentalPrice = 150, Seats = 4, EngineType = "Diesel", Transmission = "Manual", Convertible = false };
            Truck truck1 = new Truck { Model = "F-150", Manufacturer = "Tata", Year = 2021, RentalPrice = 120, Capacity = 5, TruckType = "Pickup", FourWheelDrive = true };
            Motorcycle bike1 = new Motorcycle { Model = "bajaj", Manufacturer = "Super", Year = 2020, RentalPrice = 85, EngineCapacity = 120, FuelType = "Petrol", HasFairing = true };

            agency.AddVehicle(car1);
            agency.AddVehicle(truck1);
            agency.AddVehicle(bike1);
            Console.WriteLine();

            agency.DisplayFleet();

            agency.RentVehicle(car1);
            Console.WriteLine("Total Revenue : {0}", agency.TotalRevenue);
            Console.WriteLine();

            agency.DisplayFleet();

            Console.ReadLine();

        }
    }
}
