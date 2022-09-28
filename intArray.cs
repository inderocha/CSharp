using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

int[] arrayInteger = new int[3]; 

arrayInteger[0] = 21; 
arrayInteger[1] = 5; 
arrayInteger[2] = 22;

//traversing the array with the FOR
for(int i = 0; i < arrayInteger.Length; i++)
{
    Console.WriteLine($"Position {i} - {arrayInteger[i]}"); 
}

//traversing the array with the FOREACH
int iForeach = 0; 
foreach(int value in arrayInteger) 
{
 Console.WriteLine($"Position {iForeach} = {value}");
 iForeach++;   
}
