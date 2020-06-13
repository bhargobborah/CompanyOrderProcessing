using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderLibrary.OrderImplemention
{
    public class PhysicalProductOrder : Order
    {
        public override void GenerateOrder()
        {
            Console.WriteLine("GenerateOrder: Generating packing slip for shipping...");
            Thread.Sleep(2000);
            Console.WriteLine("GenerateOrder: Packing slip for shipping is generated.");
        }
    }
}
