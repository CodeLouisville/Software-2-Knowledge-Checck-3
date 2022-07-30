using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck3
{
    public class ShoppingCart
    {
        public ShoppingCartResponse AddCartItem(AddShoppingCartRequest request)
        {
            return new ShoppingCartResponse
            {
                Success = true,
                ProductId = request.ProductId
            };
        }
    }
}
