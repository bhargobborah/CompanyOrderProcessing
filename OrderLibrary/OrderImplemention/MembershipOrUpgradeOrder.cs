using System;
using System.Threading;

namespace OrderLibrary.OrderImplemention
{
    public class MembershipOrUpgradeOrder : Order
    {
        private readonly string productName = string.Empty;

        public MembershipOrUpgradeOrder(string productName) : base(productName)
        {
            this.productName = productName;
        }

        public override string GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: {this.productName} is in process...");
            Thread.Sleep(2000);
            Console.WriteLine($"Email is send to the owner and informed them for {this.productName}.");
            Thread.Sleep(2000);
            return $"GenerateOrder: {this.productName} is completed.";
        }
    }
}
