using System;
using System.Threading;

namespace OrderLibrary.OrderImplemention
{
    public class VideoAddingOrder : Order
    {
        private readonly string productName = string.Empty;

        public VideoAddingOrder(string productName) : base(productName)
        {
            this.productName = productName;
        }

        public override string GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: 'First aid video' is adding to the packing slip for payment for the video {this.productName}...");
            Thread.Sleep(2000);

            return $"GenerateOrder: 'First aid video' is added to the packing slip for payment for the video {this.productName}.";
        }
    }
}
