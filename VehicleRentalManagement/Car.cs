﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalManagement
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }
        public string EngineType { get; set; }
        public string Transmission {  get; set; }
        public bool Convertible {  get; set; }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats: {Seats}, Engine Type: {EngineType}, Transmission: {Transmission}, Convertible: {Convertible}");
        }

    }
}
