# Vehicle Rental Management System

## Project Description
The Vehicle Rental Management System is a console-based application designed to manage a fleet of vehicles available for rent. The system demonstrates the use of object-oriented principles such as inheritance, abstraction, and encapsulation. It includes different types of vehicles such as cars, trucks, and motorcycles, each with their specific properties.

## Features
- **Vehicle Management**: Add, remove, and display vehicles in the fleet.
- **Rental Management**: Rent vehicles and track total revenue.
- **Detailed Information**: Display detailed information for each type of vehicle.

## Classes
1. **Vehicle**: Represents a generic vehicle with properties like model, manufacturer, year, and rental price.
2. **Car**: Inherits from `Vehicle` and adds properties like seats, engine type, transmission, and convertible.
3. **Truck**: Inherits from `Vehicle` and adds properties like capacity, truck type, and four-wheel drive.
4. **Motorcycle**: Inherits from `Vehicle` and adds properties like engine capacity, fuel type, and fairing.
5. **RentalAgency**: Manages the fleet of vehicles and handles operations such as adding, removing, and renting vehicles.

## Setup Instructions
1. **Clone the Repository**
   ```sh
   git clone https://github.com/yourusername/vehicle-rental-management-system.git
   cd vehicle-rental-management-system
