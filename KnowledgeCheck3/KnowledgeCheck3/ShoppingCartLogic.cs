using KnowledgeCheck3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck3
{
    public class ShoppingCartLogic
    {
        private readonly IPriceRepository _priceRepo;
        private readonly IDistributorRepository _distributorRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartLogic(IPriceRepository priceRepo, IDistributorRepository distributorRepo, ShoppingCart shoppingCart)
        {
            _priceRepo = priceRepo;
            _distributorRepo = distributorRepo;
            _shoppingCart = shoppingCart;
        }

        public ShoppingCartResponse AddProductToCart(AddShoppingCartRequest request)
        {
            var latestPrice = _priceRepo.GetUpToDatePrice(request.ProductId);

            if (latestPrice != request.Price)
            {
                throw new Exception("Product price has been updated, please refresh");
            }
            else
            {
                var quantityAvailable = _distributorRepo.CheckQuantityOfProduct(request.ProductId);
                if (quantityAvailable >= request.Quantity)
                {
                    return _shoppingCart.AddCartItem(request);
                }
                else
                {
                    throw new Exception("The distributor doesn't have the requested amount of product available.");
                }
            }

        }
    }
}
