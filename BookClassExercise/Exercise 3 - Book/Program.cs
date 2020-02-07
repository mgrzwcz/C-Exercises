using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClassExercise
{

    /*Create a book class in C# with the following properties:
    ISBN (a string)
    Title (a string)
    Author (a string)
    Publisher (a string)
    Category (an enum—values of SciFi, History, Politics, Geography and Sciences)
    Price (a decimal)
    Create a ToString() method to return the field values of the book class.
    Write a test code in your Main() function to create Book objects and display the details.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Book test = new Book();

            Console.WriteLine(test);

            Console.ReadKey();

            Book test2 = new Book("9780099528128", "Godfather", "Mario Puzo", "Arrow Books (June 1, 2009)", Category.Crime, 10);

            Console.WriteLine(test2);

        }
    }
}
