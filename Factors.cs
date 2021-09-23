using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class Factors
    {
        int n = 315;
        public void PrimeFactors()
        {

                // Print the number of 2s that divide n
                while (n % 2 == 0)
                {
                    Console.Write(2 + " ");
                    n /= 2;
                    break;
                }

                // n must be odd at this point. So we can
                // skip one element (Note i = i +2)
                for (int i = 3; i <=i*i; i += 2)
                {
                    // While i divides n, print i and divide n
                    while (n % i == 0)
                    {
                        Console.Write(i + " ");
                        n /= i;
                    }
                }

            // This condition is to handle the case whien
            // n is a prime number greater than 2
            if (n > 2)
            {
                Console.Write(n);
            }
            Console.ReadLine();
        }
    }
}
    

