using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class EvenOrOdd
    {
        public void CheckCond()
        {
             for (int i =0; i<= 20; i++)
             {
                if (i != 0 && i % 2 == 0)
                {
                    Console.Write(i + "Even Number  ");
                }
                if (i != 0 && i % 2 != 0)
                {
                    Console.Write(i + " Odd Number");
                }
                else
                {
                    Console.WriteLine("Your entered a Zero");
                }
                    
             }
        }
    }
}
