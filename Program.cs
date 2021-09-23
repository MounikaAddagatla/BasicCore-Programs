using System;

namespace BasicLogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic logic problem");
            Console.WriteLine(" Enter Y for repeat again else N for quit ");
            char ch = Convert.ToChar(Console.ReadLine());
            while (ch == 'Y' || ch == 'y')
            {
                Console.WriteLine("1.Flip Coin \n2.Leap Year \n3.Swap Two no" +
                       "\n4.Power of Two no \n5.Harmonic no \n6.Factor no of 2 \n7.Reminder Coficient\n8.Even or odd " +
                       "\n9.Is ovwel or not \n10. Biggest of three nos");

                Console.WriteLine("\nEnter Your Option:");

                //Switch Case starts

                int option = Convert.ToInt32(Console.ReadLine());
                //// switch case for accessing block of program in given cases. 
                switch (option)
                {
                    case 1:
                        //// flip the coin and count the percentage of heads and tails. 
                        FlipCoin flip = new FlipCoin();
                        flip.Play();
                        break;
                    case 2:
                        //// create LeapYear class object to accessing LeapYear class. . 
                        LeapYear year = new LeapYear();
                        year.CheckLeap();
                        break;

                    case 3:
                        //// 
                        SwapTwoNo swap = new SwapTwoNo();
                        swap.TwoNumbers();
                        break;
                    case 4:
                        ///create PoweofTwo class object to accessing PowerofTwo class.
                        PowerOfTwo power = new PowerOfTwo();
                        power.POT();
                        break;
                    case 5:
                        ////  
                        HarmonicNo hm = new HarmonicNo();
                        hm.NumSeries();
                        break;
                    case 6:
                        //// factorial number finding
                        Factors fact = new Factors();
                        fact.PrimeFactors();
                        break;
                    case 7:
                        /// here the program define the reminder value
                        CoficientFactor factor = new CoficientFactor();
                        factor.Reminder();
                        break;
                    case 8:
                        ///check the conditions whether you enter a no is even or odd number
                        EvenOrOdd number = new EvenOrOdd();
                        number.CheckCond();
                        break;
                    case 9:
                        /// checking the given character is ovwel or consonant
                        CharExample charecter = new CharExample();
                        charecter.VowelOrConsonant();
                        break;
                    case 10:
                        ///biggest of three numbers
                        LargestNum largest = new LargestNum();
                        largest.BiggestNum();
                        break;

                    default:
                        Console.WriteLine("Wrong option! please enter option again.");
                        break;
                }

                //Switch Case ends 


                // This for running the while loop again 
                Console.WriteLine(" Enter Y for repeat again else N for quit ");
                ch = Convert.ToChar(Console.ReadLine());
                //// holds the console.
            }
        }

    }
}
