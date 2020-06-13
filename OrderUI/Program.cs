using OrderLibrary;
using OrderLibrary.OrderImplemention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select any number from 1-6 for the Payment type");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("1. Physical Product");
            Console.WriteLine("2. Book");
            Console.WriteLine("3. Add Membership");
            Console.WriteLine("4. Upgrade Membership");
            Console.WriteLine("5. Learning to Ski");
            Console.WriteLine("6. Physical product Or Book");
            Console.WriteLine("-----------------------------------------------");

            var keyPressed = Console.ReadLine();

            // Create order object
            Order order = null;

            switch (keyPressed)
            {
                case "1":
                    order = new PhysicalProductOrder();
                    order.GenerateOrder();
                    break;
                case "2":
                    order = new BookOrder();
                    order.GenerateOrder();
                    break;

            }



            Console.ReadLine();
        }
    }
}
