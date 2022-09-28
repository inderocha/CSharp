using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

namespace Base.Models 
{
    public class Calculator 
    {
        public void add(double x, double y) 
        {
            Console.WriteLine($"{x} + {y} = {x + y}"); 
        }

        public void subtraction(double x, double y) 
        {
            Console.WriteLine($"{x} - {y} = {x - y}"); 
        }

        public void division(double x, double y) 
        {
            Console.WriteLine($"{x} / {y} = {x / y}"); 
        }

        public void multiplication(double x, double y) 
        {
            Console.WriteLine($"{x} x {y} = {x * y}"); 
        }
    }
}
