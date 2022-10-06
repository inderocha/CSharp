using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parking.Models
{
    public class Park
    {
        private decimal initialValue = 0; 
        private decimal valuePerHour = 0; 
        private List<string> vehicles = new List<string>(); 

        public Park(decimal initialValue, decimal valuePerHour) 
        {
            this.initialValue = initialValue; 
            this.valuePerHour = valuePerHour; 
        }

        public void AddVehicles()
        {
            var licensePlate = ""; 
            do
            {
                Console.WriteLine("Enter vehicle license plate to park:"); 
                licensePlate = Console.ReadLine();  
            } while (licensePlate == ""); 

            vehicles.Add(""); 
        }

        public void DeleteVehicles()
        {
            var licensePlate = ""; 
            do
            {
                Console.WriteLine("Enter vehicle license plate to remove:");
                licensePlate = Console.ReadLine(); 
            } while (licensePlate == ""); 

            if(vehicles.Any(x => x.ToUpper() == licensePlate.ToUpper())) {

                int hours = 0; 
                var success = false; 
                do
                {
                    Console.WriteLine("Enter the number of hours the vehicle was parked:");
                    success = Int32.TryParse(Console.ReadLine(), out hours);
                } while(!success); 
                
                decimal totalValue = this.initialValue + (this.valuePerHour + hours); 

                vehicles.Remove(licensePlate); 

                Console.WriteLine($"The vehicle {licensePlate} was removed and the total price was: BRL {totalValue}");

            }else{
                Console.WriteLine("Sorry, that vehicle is not parked here. Check if you typed the card correctly"); 
            }
        }

        public void ListVehicles() 
        {
            if(vehicles.Any()) {
                Console.WriteLine("Parked vehicles are:"); 
                for(int i = 0; i < vehicles.Count; i++) {
                    Console.Write($"{i} - {vehicles[i]}");
                }
            } else {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}
