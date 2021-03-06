﻿using OrderLibrary;
using OrderLibrary.OrderImplemention;
using System;

namespace OrderUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Menu based selection 
            Console.WriteLine("Select any number from 1-6 for the Payment type");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("1. Physical Product");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Add Membership");
            Console.WriteLine("4. Upgrade Membership");
            Console.WriteLine("5. Membership or Upgrade");
            Console.WriteLine("6. Learning to Ski");
            Console.WriteLine("7. Physical product Or Book");
            Console.WriteLine("-----------------------------------------------");

            var keyPressed = Console.ReadLine();

            // Create order object
            Order order = null;
            string result = string.Empty;

            switch (keyPressed)
            {
                case "1":
                    order = new PhysicalProductOrder("Physical Product");
                    result = order.GenerateOrder();

                    break;

                case "2":
                    order = new BookOrder("Book");
                    order.GenerateOrder();
                    break;

                case "3":
                    order = new AddMembershipOrder("Add Membership");
                    order.GenerateOrder();
                    break;

                case "4":
                    order = new AddMembershipOrder("Upgrade Membership");
                    order.GenerateOrder();
                    break;

                case "5":
                    order = new MembershipOrUpgradeOrder("Membership or Upgrade");
                    order.GenerateOrder();
                    break;

                case "6":
                    order = new VideoAddingOrder("Learning to Ski");
                    order.GenerateOrder();
                    break;

                case "7":
                    order = new PhysicalProductOrBookOrder("Physical product Or Book");
                    order.GenerateOrder();
                    break;

                default:
                    Console.WriteLine("Wrong selection, select within range.");
                    break;

            }
            Console.WriteLine(result);
            Console.WriteLine();


            Console.WriteLine("Press any key to close the console window.");
            Console.ReadLine();
        }



    }
}
