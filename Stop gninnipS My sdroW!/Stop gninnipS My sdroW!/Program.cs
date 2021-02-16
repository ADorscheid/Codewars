using System;

namespace Stop_gninnipS_My_sdroW_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseFourOrGreater("Hey fellow warriors"));
            Console.WriteLine(ReverseFourOrGreater("This is a test"));
            Console.WriteLine(ReverseFourOrGreater("Hello my name is Andrew"));
        }
        public static string ReverseFourOrGreater(string sentence)
        {
            string finalString = "";
            string[] sentenceArray = sentence.Split(" ");

            //loop through array
            for (int i = 0; i < sentenceArray.Length; i++)
            {

                //this adds the spaces between each word back into the final string to be returned
                if (i > 0)
                {
                    finalString += " ";
                }

                //if it is greater than 4, run this code to reverse
                if (sentenceArray[i].Length > 4)
                {
                    //blank array to be updated with backwards letters
                    string[] backwardWord = new string[sentenceArray[i].Length];
                    //array of the letters straight
                    char[] word = sentenceArray[i].ToCharArray();
                    //counter to start at the length of the array-1 so i can swap positions of the letters
                    int counter = sentenceArray[i].Length - 1;
                    for (int j = 0; j < sentenceArray[i].Length; j++)
                    {
                        //loop through and add the backwards words from word into backwardWord
                        backwardWord[j] = (word[counter]).ToString();
                        counter--;
                    }
                    //join the array into a string
                    string wordToAdd = string.Join("", backwardWord);
                    //add it to the final return string
                    finalString = finalString + wordToAdd;
                }
                else
                {
                    //if its not >4 length, just add the word as is
                    finalString = finalString + sentenceArray[i];
                }
            }
            return finalString;
        
        }
    }
}
