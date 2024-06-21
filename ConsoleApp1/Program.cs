using System;
using System.Collections.Generic;

namespace InventoryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nInventory Management System");
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. View Items");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter item name: ");
                        string itemName = Console.ReadLine();
                        inventory.AddItem(itemName);
                        break;
                    case "2":
                        Console.Write("Enter item name to remove: ");
                        string removeItemName = Console.ReadLine();
                        inventory.RemoveItem(removeItemName);
                        break;
                    case "3":
                        inventory.ViewItems();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }

    class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine($"{item} added to inventory.");
        }

        public void RemoveItem(string item)
        {
            if (items.Contains(item))
            {
                items.Remove(item);
                Console.WriteLine($"{item} removed from inventory.");
            }
            else
            {
                Console.WriteLine($"{item} not found in inventory.");
            }
        }

        public void ViewItems()
        {
            Console.WriteLine("\nCurrent Inventory:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }
        }
    }
}

