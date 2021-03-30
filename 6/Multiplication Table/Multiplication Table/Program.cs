using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static int[,] MultiplicationTable(int size)
        {
            int[,] array = new int[size, size];

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    array[i-1, j-1] = i * j;
                }
            }
            return array;
        }
    }
}
