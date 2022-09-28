using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Threading.Tasks; 

List<string> stringList = new List<string>();

stringList.Add("Ursula");
stringList.Add("Morgana");
stringList.Add("Salem");

for(int i = 0; i < stringList.Count; i++)
{
    Console.WriteLine($"Position {i} - {stringList[i]}");
}

int j = 0; 
foreach(string item in stringList)
{
    Console.WriteLine($"Position {j} - {stringList[j]}");
    j++;
}
