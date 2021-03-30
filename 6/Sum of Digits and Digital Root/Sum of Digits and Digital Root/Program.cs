using System;

namespace Sum_of_Digits_and_Digital_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(DigitalRoot(493193));
        }
        public static int DigitalRoot(long n)
        {
            // Your awesome code here!
            string nString = n.ToString();
            int sum = 0;
            bool overTwoDigits = true;
            while (overTwoDigits)
            {
                for (int i = 0; i < nString.Length; i++)
                {
                    sum += int.Parse(nString.Substring(i, 1));
                    //Console.WriteLine(sum);
                }
                if (sum >= 10)
                {
                    nString = sum.ToString();
                    sum = 0;
                }
                else
                {
                    overTwoDigits = false;
                }
            }
            return sum;
        }
    }
}

