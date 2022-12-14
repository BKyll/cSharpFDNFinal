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
using System.Runtime.CompilerServices;

class Item
{
    public string itemID = "ITM100";
    public string itemDesc = "";
    public double itemPrice = 0.0; // price to user
    public int itemQuantity = 0; // number in stock
    public double itemCost = 0.0; // price to us
    public double itemValue = 0.0; // quantity * cost
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
                case "a":
                case "A":
                    {
                        // ADD AN ITEM
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
                case "c":
                case "C":
                    {
                        // CHANGE AN ITEM
                        // list all items.
                        Print(items);
                        // take item id no
                        Console.WriteLine("What item would you like to change? (enter the number in the item ID)");
                        Console.Write("ITM");
                        int idChoice = int.Parse(Console.ReadLine()) - 100;
                        // print specified item number
                        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}", items[idChoice].itemID, items[idChoice].itemDesc, items[idChoice].itemPrice, items[idChoice].itemQuantity, items[idChoice].itemCost, items[idChoice].itemValue);
                        // ask what aspect to change
                        Console.WriteLine("Which value would you like to change?");
                        Console.WriteLine("1) Description 2) Price 3) Quantity 4) Cost");
                        string choice = Console.ReadLine();
                        // Update item with new changes
                        switch (choice)
                        {
                            case "1":
                                {
                                    Console.WriteLine("Enter a new description: ");
                                    items[idChoice].itemDesc = Console.ReadLine();
                                    break;
                                }
                            case "2":
                                {
                                    Console.WriteLine("Enter a new price: ");
                                    items[idChoice].itemPrice = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case "3":
                                {
                                    Console.WriteLine("Enter a new quantity: ");
                                    items[idChoice].itemQuantity = int.Parse(Console.ReadLine());
                                    break;
                                }
                            case "4":
                                {
                                    Console.WriteLine("Enter a new cost: ");
                                    items[idChoice].itemCost = int.Parse(Console.ReadLine());
                                    break;
                                }
                            default:
                                break;
                        }
                        break;
                    }
                case "3":
                case "d":
                case "D":
                    {
                        // DELETE AN ITEM
                        // List all items
                        Print(items);
                        // Ask which to delete
                        Console.WriteLine("What item would you like to change? (enter the number in the item ID)");
                        Console.Write("ITM");
                        int idChoice = int.Parse(Console.ReadLine()) - 100;
                        // print specified item number
                        Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}", items[idChoice].itemID, items[idChoice].itemDesc, items[idChoice].itemPrice, items[idChoice].itemQuantity, items[idChoice].itemCost, items[idChoice].itemValue);
                        // Remove item from list
                        Console.WriteLine("Delete this item from the list? y/n");
                        string delChoice = Console.ReadLine();

                        switch (delChoice)
                        {
                            case "y":
                            case "Y":
                                {
                                    for (int d = idChoice; d < items.Length; d++)
                                    {
                                        if (items[d] != null)
                                        {
                                            items[d] = items[d + 1];
                                        }
                                    }
                                    break;
                                }
                            case "n":
                            case "N":
                            default:
                                {
                                    break;
                                }
                        }

                        Print(items);
                        Console.ReadLine();
                        break;
                    }
                case "4":
                case "l":
                case "L":
                    {
                        // LIST ALL ITEMS
                        Print(items);
                        Console.ReadLine();
                        break;
                    }
                case "5":
                case "q":
                case "Q":
                    {
                        // QUIT
                        keepGoing = false;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }
    }

    public static void Print(Item[] array)
    {
        Console.Clear();
        Console.WriteLine("__________________________________________________________________________________");
        Console.WriteLine("|{0,-10}|{1,-25}|{2,-10}|{3,-10}|{4,-10}|{5,-10}|", "ID", "Description", "Price", "Quantity", "Cost", "Value");
        Console.WriteLine("----------------------------------------------------------------------------------");
        foreach (var i in array)
        {
            if (i != null)
            {
                Console.WriteLine("|{0,-10}|{1,-25}|{2,-10:C}|{3,-10}|{4,-10:C}|{5,-10:C}|", i.itemID, i.itemDesc, i.itemPrice, i.itemQuantity, i.itemCost, i.itemValue);
            }
        }
        Console.WriteLine("__________________________________________________________________________________");
    }
}