using System;
using System.Threading;

namespace OrderLibrary.OrderImplemention
{
    public class PhysicalProductOrBookOrder : Order
    {
        private readonly string productName = string.Empty;

        public PhysicalProductOrBookOrder(string productName) : base(productName)
        {
            this.productName = productName;
        }

        /* Thread is used to just to simulate a delay(in real case actual functinality will happen here)*/
        public override void GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: Commision payment to the agent slip is generating for {this.productName}...");
            Thread.Sleep(2000);

            Console.WriteLine($"GenerateOrder: Commision payment to the agent slip is generated for {this.productName}.");
        }
    }
}
