using backend.Domain.Entities;
using backend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductService _productService;


        public ProductService(IProductService productService)
        {
            _productService = productService;
        }

        public int CreateNewProduct(Product product)
        {
            return _productService.CreateNewProduct(product);
        }

        public int DeleteProductById(int id)
        {
            return (_productService.DeleteProductById(id));
        }

        public List<Product> FindProduct(Product product)
        {
            return _productService.FindProduct(product);
        }

        public Product GetProductById(int id)
        {
            return  _productService.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        public bool ProductExists(Product product)
        {
            return _productService.ProductExists(product);
        }

        public int UpdateProduct(Product product)
        {
             return _productService.UpdateProduct(product); 
        }
    }
}
