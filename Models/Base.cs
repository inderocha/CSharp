using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace Base.Models 
{
    public class Parking
    {
        private decimal initialValue = 0; 
        private decimal valuePerHour = 0; 
        private List<string> vehicles = new List<string>(); 

        public Parking(decimal initialValue, decimal valuePerHour) 
        {
            this.initialValue = initialValue; 
            this.valuePerHour = valuePerHour; 
        }

        public void AddVehicles()
        {
            Console.WriteLine("Enter vehicle license plate to park:"); 
        }

        public void DeleteVehicles()
        {
            Console.WriteLine("Enter vehicle license plate to remove:");

            string licensePlate = ""; 

            if(vehicles.Any(x => x.ToUpper() == licensePlate.ToUpper())) {

                Console.WriteLine("Enter the number of hours the vehicle was parked:");
                int hours = 0; 
                decimal totalValue = 0; 

                Console.WriteLine($"The vehicle {licensePlate} was removed and the total price was: BRL {totalValue}"); 
            } else {
                Console.WriteLine("Sorry, that vehicle is not parked here. Check if you typed the card correctly"); 
            }
        }

        public void ListVehicles() 
        {
            if(vehicles.Any()) {
                Console.WriteLine("Parked vehicles are:");
            } else {
                Console.WriteLine("There are no parked vehicles.");
            }
        }
    }
}
