using System;
using System.Collections.Generic;
using System.Text;

namespace Romertal
{
    class RomanNumeralConverter
    {
        //I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000
        //IV
        //XL

        private static void Main() 
        {
            while (true) 
            {
                Console.WriteLine("Skriv et romertal");
                string TextInput = Console.ReadLine();
                Console.WriteLine(ConvertNumerals(TextInput));

            }           

        }

        public static int ConvertNumerals(string roman)
        {
            int outVal = 0;
            roman = roman.ToUpper();
            for(int i = 0; i < roman.Length; i++)
            {
                char character = roman[i];

                if(i != roman.Length - 1 && GetRomanValue(roman[i]) < roman[i + 1])
                {
                    
                    
                        outVal += roman[i + 1] - roman[i];

                        i++;
                        continue;
                    
                }
                else
                {
                    outVal += roman[i];
                }

            }

            return outVal;

        }

        public static int GetRomanValue(char val)
        {
            switch(val)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }       
        }
    }
}
