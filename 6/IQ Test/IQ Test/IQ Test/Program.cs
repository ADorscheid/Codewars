using System;

namespace IQ_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("1 2 1 1")); //should return 2 since the 2nd number is even, while the rest are odd
            Console.WriteLine(Test("2 4 7 8 10"));  //should return 3 since the 3rd number is odd while the rest are even
        }
        public static int Test(string numbers)
        {
            int[] array = Array.ConvertAll((numbers.Split(" ")), s => int.Parse(s));
            int numEven = 0;
            int evenIndex = 0;
            int numOdd = 0;
            int oddIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    numEven++;
                    evenIndex = i+1; //the test wants us to return a 1 based index
                }
                else
                {
                    numOdd++;
                    oddIndex = i+1; //the test wants us to return a 1 based index
                }
            }
            if (numOdd > numEven)
            {
                return evenIndex;
            }
            else
            {
                return oddIndex;
            }
        }
    }
}
