using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseWord
{
    class Program
    {
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
