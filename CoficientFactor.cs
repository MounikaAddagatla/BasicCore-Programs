using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class CoficientFactor
    {
        int dividend = 50, divisor = 8;
        public void Reminder()
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
