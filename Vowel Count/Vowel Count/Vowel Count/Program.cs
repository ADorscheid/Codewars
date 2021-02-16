using System;

namespace Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCount("Abrakadabra")); //5
            Console.WriteLine(GetVowelCount("Dinner")); //2
        }
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            str = str.ToLower();
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 'a' || charArray[i] == 'e' || charArray[i] == 'i' || charArray[i] == 'o' || charArray[i] == 'u')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
