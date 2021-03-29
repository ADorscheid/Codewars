using System;

namespace Roman_Numerals_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Solution("MCMLXXXVI"));
            //I = 1
            //IV = 4
            //MCMLXXXVI = 1986
        }
        public static int Solution(string roman)
        {
            int number = 0;
            char[] array = roman.ToCharArray();
            char[] reverseArray = new char[roman.Length];
            for (int i = 0; i < roman.Length; i++)
            {
                reverseArray[i] = array[roman.Length - i -1];
            }
            int currentValue = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if (reverseArray[i] == 'I')
                {
                    if (currentValue <= 1)
                    {
                        number += 1;
                    }
                    else
                    {
                        number -= 1;
                    }
                    currentValue = 1;
                }
                if (reverseArray[i] == 'V')
                {
                    if (currentValue <= 5)
                    {
                        number += 5;
                    }
                    else
                    {
                        number -= 5;
                    }
                    currentValue = 5;
                }
                if (reverseArray[i] == 'X')
                {
                    if (currentValue <= 10)
                    {
                        number += 10;
                    }
                    else
                    {
                        number -= 10;
                    }
                    currentValue = 10;
                }
                if (reverseArray[i] == 'L')
                {
                    if (currentValue <= 50)
                    {
                        number += 50;
                    }
                    else
                    {
                        number -= 50;
                    }
                    currentValue = 50;
                }
                if (reverseArray[i] == 'C')
                {
                    if (currentValue <= 100)
                    {
                        number += 100;
                    }
                    else
                    {
                        number -= 100;
                    }
                    currentValue = 100;
                }
                if (reverseArray[i] == 'D')
                {
                    if (currentValue <= 500)
                    {
                        number += 500;
                    }
                    else
                    {
                        number -= 500;
                    }
                    currentValue = 500;
                }
                if (reverseArray[i] == 'M')
                {
                    if (currentValue <= 1000)
                    {
                        number += 1000;
                    }
                    else
                    {
                        number -= 1000;
                    }
                    currentValue = 1000;
                }
            }
            return number;
        }
    }
}
