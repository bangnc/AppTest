using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppTest;
using Moq;

namespace UnitTestProject1
{
    [TestClass]
    public class ProductDataAccessTest
    {
        // Declare 
        ICalculate _calculate;
        [TestInitialize]
        public void TestInitialize()
        {
            _calculate = new Calculate();
        }

        [TestMethod]
        public void Add()
        {
            var mockDataAccess = new Mock<IProductDataAccess>();
            mockDataAccess.Setup(m => m.CreateProduct(It.IsAny<Product>())).Returns(true);


            var productBusiness = new ProductBusiness(mockDataAccess.Object);
            var result = productBusiness.UpdateProduct(new Product());
            Assert.AreEqual<bool>(false, result);

        }
       
    }
}
