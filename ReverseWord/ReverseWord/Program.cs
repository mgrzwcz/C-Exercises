using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {

        /*
         * Write a program that asks the user to enter a word.  If the word entered has less than 7 characters, 
         * then tell the user to re-enter a new word until there are at least 7 characters.
         * Enhance the above program with a function that will reverse the word the user 
         * has entered (assuming it has more than 7 characters).  Make sure you do not use any Reverse() functions offered by Microsoft.
        */
        static void Main(string[] args)
        {
            bool loop = true;

            do
            {
                Console.WriteLine("Please enter a word at least 7 characters in length.");
                string wordProvided = Console.ReadLine();
                char[] charArr = wordProvided.ToCharArray();

                if (charArr.Length >= 7)
                {
                    loop = false;

                    for (int i = 0; i < charArr.Length / 2; i++)
                    {
                        char temp = charArr[i];
                        charArr[i] = charArr[charArr.Length - i - 1];
                        charArr[charArr.Length - i - 1] = temp;
                    }

                    string reversedWord = new string(charArr);

                    Console.WriteLine($"Your word in reverse is {reversedWord}.\n");

                }
                else
                {
                    Console.WriteLine("Please provide a longer word.\n");

                }

            } while (loop);
        }
    }
}
