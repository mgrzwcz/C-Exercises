using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountClassExercise
{

    /*
     * Write an Account class in C# with the following specification:
        A constructor with one parameter to initialise the balance with an opening amount.
        A method to credit the account balance by specified amount with the following header public
        bool Credit( decimal amount )
        A method to debit the account balance by a specified amount with the following header.  The method should return bool indicating whether the debit was successful.
        public bool Debit( decimal amount )
        Also write an auto-implemented property that gets and sets the account balance.
        Write a test code in your Main() function and create two account objects and test all methods. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            Account test1 = new Account(10000);

            Console.WriteLine(test1);

            Account test2 = new Account(100);

            Console.WriteLine(test2);
        }
    }
}
