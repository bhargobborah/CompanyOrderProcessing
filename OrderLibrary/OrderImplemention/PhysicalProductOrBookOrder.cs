using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderLibrary.OrderImplemention
{
    public class PhysicalProductOrBookOrder : Order
    {
        private readonly string productName = string.Empty;

        public PhysicalProductOrBookOrder(string productName) : base(productName)
        {
            this.productName = productName;
        }

        public override void GenerateOrder()
        {
            Console.WriteLine($"GenerateOrder: Commision payment to the agent slip is generating for {this.productName}...");
            Thread.Sleep(2000);

            Console.WriteLine($"GenerateOrder: Commision payment to the agent slip is generated for {this.productName}.");
        }
    }
}
