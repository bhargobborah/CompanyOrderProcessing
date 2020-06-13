using System;
using System.Threading;

namespace OrderLibrary.OrderImplemention
{
    public class AddMembershipOrder : Order
    {
        private readonly string productName = string.Empty;

        public AddMembershipOrder(string productName) : base(productName)
        {
            this.productName = productName;
        }

        public override void GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: {this.productName} in process...");
            Thread.Sleep(2000);
            Console.WriteLine($"GenerateOrder: {this.productName} completed.");
        }
    }
}
