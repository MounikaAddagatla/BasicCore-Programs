using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class LargestNum
    {
        int num1, num2, num3;
        public void BiggestNum()
        {
            Console.WriteLine("Enter three numbers: \n");

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                if (num1 >= num3)
                    Console.WriteLine(num1 + " is the largest number");
                else
                    Console.WriteLine(num3 + " is the largest number");
            }

            else if (num2 >= num3)
            {
                Console.WriteLine(num2 + " is the largest number");
            }
            else
            {
                Console.WriteLine(num3 + " is the largest number");
            }
            Console.ReadLine();
        }
    }
}
