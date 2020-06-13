namespace OrderLibrary
{
    public abstract class Order
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal ProductPrice { get; set; }


        public Order(string productName)
        {
            this.ProductName = productName;
        }

        // Abstract method for implementation
        public abstract void GenerateOrder();
    }
}
