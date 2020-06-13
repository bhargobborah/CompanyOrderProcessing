using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OrderLibrary.OrderImplemention
{
    public class BookOrder : Order
    {
        public override void GenerateOrder()
        {
            Console.WriteLine("GenerateOrder: Generating duplicate packing slip for royalty department...");
            Thread.Sleep(2000);
            Console.WriteLine("GenerateOrder: Packing slip for royalty department is generated.");
        }
    }
}
