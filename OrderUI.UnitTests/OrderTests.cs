using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderLibrary.OrderImplemention;

namespace OrderUI.UnitTests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void Order_PhysicalProduct_GeneratePackingSlip()
        {
            // Arrange 
            var order = new PhysicalProductOrder("Physical Product");

            // Act

            var result = order.GenerateOrder();

            // Assert
            Assert.AreEqual("GenerateOrder: Packing slip for Physical Product is generated.", result);
        }

        [TestMethod]
        public void Order_BookProduct_GenerateDuplicatePackingSlip()
        {
            // Arrange 
            var order = new BookOrder("Book");

            // Act

            var result = order.GenerateOrder();

            // Assert
            Assert.AreEqual("GenerateOrder: Packing slip for royalty department is generated for item Book.", result);
        }
    }
}
