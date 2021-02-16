using System;

namespace Convert_string_to_camel_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ToCamelCase("the-stealth-warrior")); //theStealthWarrior
            Console.WriteLine(ToCamelCase("The_stealth_warrior")); //TheStealthWarrior
        }
        public static string ToCamelCase(string str)
        {
            char[] array = str.ToCharArray();
            string returnString = "";
            for (int i = 0; i < str.Length; i++)
            {
                //if its a letter, add it to the return string
                if (char.IsLetter(array[i]) == true)
                {
                    returnString += array[i].ToString();
                }
                //if not a letter, we found the seperator
                else if (i<str.Length-1) //to ensure no index out of range
                {
                    //get the upper case of letter after the seperator (i+1)
                    string upperCase = str.Substring(i + 1, 1).ToUpper();
                    returnString += upperCase; //update return string
                    //move the loop up 1
                    i+=1;
                }
            }
            return returnString;
        }
    }
}
