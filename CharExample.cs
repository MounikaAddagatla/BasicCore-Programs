using System;
using System.Collections.Generic;
using System.Text;

namespace BasicLogicPrograms
{
    class CharExample
    {
        /// <summary>
        /// charecter intialization
        /// </summary>
        char ch;
        public void VowelOrConsonant()
        {
            Console.WriteLine("Enter any character: ");
           char ch = Convert.ToChar(Console.ReadLine());
            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' )
            {
                Console.WriteLine(ch + " is Vowel.");
            }
            else
            {
                Console.WriteLine(ch + " is Consonant.");
            }
            Console.ReadLine();
        }
    }
}
