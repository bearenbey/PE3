using System;

namespace PE3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The prime factors of 13195 are 5, 7, 13 and 29. What is the largest
             * prime factor of the number 600851475143 ?
             */
            
            int i = 1;
            long j;
            long number = 600851475143;
            List<int> primeFactors = new List<int>();

            while (i != 0)
            {
                j = number;
                
                if (number % i == 0)
                {
                    j = number / i;
                    primeFactors.Add(i);
                }
                
                number = j;
                i++;
            }

            int max = primeFactors.Max();
            Console.WriteLine(max);
        }
    }
}