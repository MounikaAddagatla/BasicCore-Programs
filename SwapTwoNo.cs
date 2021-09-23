using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class SwapTwoNo
    {
        int num1 = 25;
        int num2 = 50;
        public  void TwoNumbers()
        {
            num1 -= num2;
            num2 = num1 + num2;
            num1 = num2 - num1;

            Console.WriteLine("After swapping...");
            Console.WriteLine("num1 = {0}", num1); /// {0} indicates place holder for defind varible for store value
            Console.WriteLine("num2 = {0}", num2);
            Console.ReadLine();
        }
       
    }
}
