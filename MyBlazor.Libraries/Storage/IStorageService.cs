using MyBlazor.Libraries.Product.Models;
using MyBlazor.Libraries.ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlazor.Libraries.Storage
{
    public interface IStorageService
    {
        IList<ProductModel> products { get; }

        ShoppingCartModel ShoppingCart { get; }
    }
}
