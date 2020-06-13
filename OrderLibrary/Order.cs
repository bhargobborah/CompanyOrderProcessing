using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public abstract class Order
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }


        public Order(int id, string productName)
        {
            this.Id = id;
            this.ProductName = productName;
        }

        // Abstract method for implementation
        public abstract void GenerateOrder(string paymentType);
    }
}
