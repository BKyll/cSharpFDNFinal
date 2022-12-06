// Write a program to keep track of some inventory items as shown below.
// Hint: when creating arrays, as you get or read items into
// your array, then initialize each array spot before its use
// and place a counter or use your own Mylength to keep track
// of your array length as it is used.
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Reflection;

struct Item
{
    public string itemID;
    public string itemDesc;
    public double itemPrice; // price to user
    public int itemQuantity; // number in stock
    public double itemCost; // price to us
    public double itemValue; // quantity * cost

    public static string nextItemID = "ABC100";
}

class Program
{
    public static void Main()
    {
        int itemIDNo = 100;
        int currentItem = itemIDNo-100;
        string itemIDStr = "ITM" + itemIDNo.ToString();

        var items = new Item[100];

        bool keepGoing = true;
        while (keepGoing == true)
        {
            // Build command list
            // Add an item
            // Change an item
            // Delete an item
            // List all items
            // List items ordered by user
            // Quit
            Console.WriteLine("1. Add an item");
            Console.WriteLine("2. Change an item");
            Console.WriteLine("3. Delete an item");
            Console.WriteLine("4. List all items");
            Console.WriteLine("5. List items ordered by user");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do?");
            string menuChoice = Console.ReadLine();

            // Switch with cases for things you want to do:
            switch (menuChoice)
            {
                case "1":
                    {
                        // Add an item
                        itemIDStr = "ITM" + itemIDNo.ToString();
                        currentItem = itemIDNo - 100;

                        Console.Write("Item description: ");
                        var inputDesc = Console.ReadLine();
                        while (inputDesc == "")
                        {
                            Console.Write("Item description can't be blank: ");
                            inputDesc = Console.ReadLine();
                        }

                        Console.Write("Item Price: ");
                        string inputPriceStr = Console.ReadLine();
                        double inputPrice = double.Parse(inputPriceStr);

                        // TODO: Always add the pet at the end of the array
                        items[currentItem].itemID = itemIDStr;
                        items[currentItem].itemDesc = inputDesc;

                        itemIDNo++;
                        break;
                    }
                case "2":
                    {
                        // Change an item
                        break;
                    }
                case "3":
                    {
                        // Delete an item
                        break;
                    }
                case "4":
                    {
                        // List all items
                        Console.WriteLine("|{0,5}|{1,5}|{2,5}|{3,5}|", items);
                        foreach (var item in items)
                        {
                            Console.WriteLine();
                        }
                        break;
                    }
                case "5":
                    {
                        // List items ordered by users
                        break;
                    }
                case "6":
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