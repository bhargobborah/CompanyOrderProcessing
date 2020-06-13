using System;
using System.Threading;

namespace OrderLibrary.OrderImplemention
{
    public class BookOrder : Order
    {
        private readonly string productName = string.Empty;

        public BookOrder(string productName) : base(productName)
        {
            this.productName = productName;
        }

        public override string GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: Generating duplicate packing slip for royalty department for item {this.productName}...");
            Thread.Sleep(2000);
            return $"GenerateOrder: Packing slip for royalty department is generated for item {this.productName}.";


        }
    }
}
