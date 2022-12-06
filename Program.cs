// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection;
using System.Security.Principal;

class Item
{
    public string itemID = "ITM100";
    public string itemDesc = "";
    public double itemPrice = 0.0; // price to user
    public int itemQuantity = 0; // number in stock
    public double itemCost = 0.0; // price to us
    public double itemValue = 0.0 ; // quantity * cost

    /*public void Print()
    {
        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}", itemID, itemDesc, itemPrice, itemQuantity, itemCost, itemValue);
    }*/
}

class Program
{
    public static void Main()
    {
        int itemIDNo = 100;
        int currentIDLocation = itemIDNo - 100;

        var items = new Item[100];

        bool keepGoing = true;
        while (keepGoing == true)
        {
            // Build command list
            // Add an item
            // Change an item
            // Delete an item
            // List all items
            // Quit
            Console.Clear();
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Change an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string menuChoice = Console.ReadLine();

            // Switch with cases for things you want to do:
            switch (menuChoice)
            {
                case "1":
                    {
                        // Add an item
                        currentIDLocation = itemIDNo - 100;

                        items[currentIDLocation] = new Item();

                        items[currentIDLocation].itemID = "ITM" + itemIDNo.ToString();

                        Console.Write("Enter an item description:");
                        items[currentIDLocation].itemDesc = Console.ReadLine();

                        Console.Write("Enter the sale price of the item: ");
                        items[currentIDLocation].itemPrice = double.Parse(Console.ReadLine());

                        Console.Write("Enter the number of items in inventory: ");
                        items[currentIDLocation].itemQuantity = int.Parse(Console.ReadLine());

                        Console.Write("Enter the cost of the item: ");
                        items[currentIDLocation].itemCost = double.Parse(Console.ReadLine());

                        items[currentIDLocation].itemValue = items[currentIDLocation].itemCost * items[currentIDLocation].itemQuantity;

                        itemIDNo++;

                        break;
                    }
                case "2":
                    {
                        // Change an item
                        Console.WriteLine("What item would you like to change?");
                        // list all items.
                        // take item id no
                        // print specified item number
                        // ask what aspect to change
                        // Update item with new changes
                        break;
                    }
                case "3":
                    {
                        // Delete an item
                        //List all items
                        // Ask which to delete
                        // Remove item from list
                        break;
                    }
                case "4":
                    {
                        // List all items
                        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}", "ID", "Desc", "Price", "Quan", "Cost", "Value");
                        foreach (var i in items)
                        {
                            if (i != null)
                            {
                                Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}", i.itemID, i.itemDesc, i.itemPrice, i.itemQuantity, i.itemCost, i.itemValue);
                            }
                        }
                        Console.ReadLine();
                        break;
                    }
                case "5":
                    {
                        // Quit
                        keepGoing = false;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
        Console.ReadLine();
    }
}