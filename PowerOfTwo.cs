using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class PowerOfTwo
    {
        int num = Convert.ToInt32(5); //coverting string to int  //
        public void POT() //power of two method //
        {
            // following procedure to define power of two //
            Console.WriteLine("Enter a number:");
            Console.WriteLine("Power of 2 ^ "+num+" is: "+(Math.Pow(2, num)));
             Console.WriteLine ("Printing all till Power Value " + num);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Power of 2^" + i + " is: " + (Math.Pow(2, i)));
            }

        }
    }
}
