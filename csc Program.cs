using System;

namespace PrimeNumberChecker
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num <= 1)
                return false;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            int number = int.Parse(Console.ReadLine());

            if (IsPrime(number))
                Console.WriteLine($"{number} is a prime number.");
            else
                Console.WriteLine($"{number} is not a prime number.");
        }
    }
}
