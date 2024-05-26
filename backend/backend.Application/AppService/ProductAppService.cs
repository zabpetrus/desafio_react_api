using backend.Application.Interfaces;
using backend.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.AppService
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductAppService _productAppService;


        public ProductAppService(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }



        public int CreateNewProduct(ProductViewModel product)
        {
            return _productAppService.CreateNewProduct(product);
        }

        public int DeleteProductById(int id)
        {
            return _productAppService.DeleteProductById(id);
        }

        public List<ProductViewModel> GetAllProducts()
        {
            return _productAppService.GetAllProducts();
        }

        public ProductViewModel GetProductById(int id)
        {
            return _productAppService.GetProductById(id);
        }

        public bool ProductExists(int id)
        {
            return (_productAppService.ProductExists(id));  
        }

        public List<ProductViewModel> SeachProduct(ProductViewModel productviewmodel)
        {
            return _productAppService.SeachProduct(productviewmodel);
        }

        public int UpdateProduct(int id, ProductViewModel product)
        {
            return _productAppService.UpdateProduct(id, product);
        }
    }
}
