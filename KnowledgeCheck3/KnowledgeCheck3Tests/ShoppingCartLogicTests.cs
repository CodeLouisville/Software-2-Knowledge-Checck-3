using KnowledgeCheck3.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck3
{
    [TestClass]
    public class ShoppingCartLogicTests
    {
        private Mock<IPriceRepository> _priceRepoMock;
        private Mock<IDistributorRepository> _distributorRepoMock;
        
        private ShoppingCartLogic _shoppingCartLogic;

        public ShoppingCartLogicTests()
        {
            _priceRepoMock = new Mock<IPriceRepository>();
            _distributorRepoMock = new Mock<IDistributorRepository>();

            _shoppingCartLogic = new ShoppingCartLogic(_priceRepoMock.Object, _distributorRepoMock.Object, );
        }
        [TestMethod]
        public void AddProductToCartTest()
        {
            // Arrange
            var request = new AddShoppingCartRequest
            {
                Price = 10m
            };

            _priceRepoMock.Setup(x => x.GetUpToDatePrice(10))
                .Returns(10m);

            // Act
            ShoppingCartResponse response = ;

            // Assert
            Assert.AreEqual(987, response.ProductId);
            Assert.IsTrue();
        }
    }
}
