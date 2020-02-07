using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClassExercise
{

    /*
     * Create a class called Inventory that a retail store might use to represent an inventory item sold at the store. 
     * An inventory should include four pieces of information as either instance variables or auto-implemented properties 
     * - an item number (type string), an item description (type string), a quantity of the item stored (type int) 
     * and a price per item (type decimal). Your class should have a constructor that initialises the four values. 
     * For the quantity and PricePerItem, if the value passed in to the accessor is negative, the value of the 
     * instance variable should be left unchanged. Also provide a method named GetTotalCost that calculates the 
     * total inventory cost of the item (i.e. multiplies the quantity by the price per item), then returns the amount
     * as a decimal value. Write test code in your Main() function that demonstrates the class Inventory's capabilities
     * by creating several instances of Inventory objects and invoke various properties and the method GetTotalCost.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Inventory test1 = new Inventory();

            Inventory test2 = new Inventory("004568", "Awesome pencil", 200, 2);

            Inventory test3 = new Inventory("02232", "Sony TV 4K HDR", 5, 1200);

            Inventory test4 = new Inventory("12", "Mario Keychain", 3000, 4);

            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3);
            Console.WriteLine(test4);
        }
    }
}
