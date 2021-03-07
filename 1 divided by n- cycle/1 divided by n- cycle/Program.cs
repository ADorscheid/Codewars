using System;

namespace _1_divided_by_n__cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Running(18118));
        }
        public static int Running(int n)
        {
            // your code
            double number = 1 / (double)n;
            string myString = number.ToString();
            int digits = 0;
            int firstDigit = 0;
            bool numberFound = false;
            for (int i = 0; i < myString.Length; i++)
            {
                if (myString.Substring(i,1) != "0" && myString.Substring(i, 1) != "." && numberFound==false)
                {
                    numberFound = true;
                    firstDigit = i;
                }
                    
                if (myString.Substring(i, 1) == "0" && i!=0 && numberFound)
                {
                    digits = i;
                    break;
                }
            }
            if (digits-firstDigit == 0)
            {
                return -1;
            }
            return digits-firstDigit+1;
        }
    }
}
