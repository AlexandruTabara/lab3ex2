using System;

namespace lab3ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 2
            //Scrieti o functie care va determina daca un numar este sau nu numar prim. Apelati - o si afisati-i rezultatul

            bool nrPrimTest = isPrime(23);
            Console.WriteLine(nrPrimTest);

            bool isPrime(int number)
            {
                if (number == 1) return false;
                if (number == 2) return true;

                var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

                for (int i = 2; i <= limit; i++)
                    if (number % i == 0)
                        return false;
                return true;

            }
        }
    }
}
