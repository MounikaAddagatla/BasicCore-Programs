using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{

    class LeapYear
    {
        int year = 2012;
        public void CheckLeap()
        {
            if(year % 4 == 0 && year < 9999 && year > 1000)
            {
                if ((year % 100 == 0) && (year % 400 != 0))
                {
                    Console.Write( year +"is not a leap year");
                }
                else
                    Console.Write(year + " is a leap year");
            }
            else
                Console.WriteLine(year + "is not a leap year");
            Console.ReadLine();
        }
    }
 }

