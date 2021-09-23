using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class FlipCoin
    {
        public void Play()
        {

            int head = 0, tail = 0, N = 5, headPercentage, tailPercentage;
            for (int i = 0; i < N; i++)
            {
                Random random = new Random();
                if (random.NextDouble() > 0.5)
                {
                    head++;
                    Console.WriteLine("no of heads" + head);
                }
                else
                {
                    tail++;
                    Console.WriteLine("no of tails" + tail);
                }
                //Console.ReadLine();
            }
            headPercentage = (head / N) * 100;
            tailPercentage = (tail / N) * 100;
            Console.WriteLine(headPercentage);
            Console.WriteLine(tailPercentage);
        }
    }
}
