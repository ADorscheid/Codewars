using System;

namespace You_re_a_Sqaure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSquare(-1));
            Console.WriteLine(IsSquare(0));
            Console.WriteLine(IsSquare(3));
            Console.WriteLine(IsSquare(4));
            Console.WriteLine(IsSquare(25));
            Console.WriteLine(IsSquare(26));
        }
        public static bool IsSquare(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i * i == n)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

