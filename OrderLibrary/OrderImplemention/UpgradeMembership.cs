using System;
using System.Threading;

namespace OrderLibrary.OrderImplemention
{
    public class UpgradeMembership : Order
    {
        private readonly string productName = string.Empty;

        public UpgradeMembership(string productName) : base(productName)
        {
            this.productName = productName;
        }

        public override string GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: {this.productName} is in process...");
            Thread.Sleep(2000);
            return $"GenerateOrder: {this.productName} is completed.";
        }
    }
}
