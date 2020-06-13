using System;
using System.Threading;

namespace OrderLibrary.OrderImplemention
{
    public class PhysicalProductOrder : Order
    {
        private readonly string productName = string.Empty;
        public PhysicalProductOrder(string productName) : base(productName)
        {
            this.productName = productName;
        }

        public override string GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: Generating packing slip for {this.productName}...");
            Thread.Sleep(2000);
            return $"GenerateOrder: Packing slip for {this.productName} is generated.";
        }
    }
}
