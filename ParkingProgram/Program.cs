using System;
using System.Linq; 
using System.IO; 
using Base.Models; 

Console.OutputEncoding = System.Text.Encoding.UTF8; 

decimal initialValue = 0; 
decimal valuePerHour = 0; 

Console.WriteLine("Welcome to the parking system!\n" + "Enter the starting price:");

initialValue = Convert.ToDecimal(Console.ReadLine()); 

Console.WriteLine("Now enter the hourly price:");

valuePerHour = Convert.ToDecimal(Console.ReadLine()); 

Parking pk = new Parking(initialValue, valuePerHour); 

string option = string.Empty; 
bool displayMenu = true; 

while(displayMenu)
{
    Console.Clear(); 
    Console.WriteLine("Enter your option:");
    Console.WriteLine("1 - Register vehicle");
    Console.WriteLine("2 - Remove vehicle");
    Console.WriteLine("3 - List vehicles");
    Console.WriteLine("4 - Close");

    switch(Console.ReadLine())
    {
        case "1":
        pk.AddVehicles();
        break; 

        case "2":
        pk.DeleteVehicles();
        break; 

        case "3":
        pk.ListVehicles(); 
        break; 

        case "4":
        displayMenu = false; 
        break; 

        default: 
        Console.WriteLine("Invalid option");
        break; 
    }

    Console.WriteLine("Press enter to continue");
    Console.ReadLine(); 
}

Console.WriteLine("The program ended");
