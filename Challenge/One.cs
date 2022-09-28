using System;

class Challenge {
        
static void Main(string[] args){

//Dado um número inteiro ( n ) , retorne a diferença entre o produto de seus dígitos e a soma de seus dígitos.
//Given an integer ( n ), return the difference between the product ( p ) of its digits and the sum ( s ) of its digits (d).

        int n = int.Parse(Console.ReadLine());
        int p = 1, s = 0;
        while (n > 0){
             int d = n % 10;
             p *= d;
             s += d ;
             n /= 10  ;
           }

           Console.WriteLine(p-s);
        }
    }
