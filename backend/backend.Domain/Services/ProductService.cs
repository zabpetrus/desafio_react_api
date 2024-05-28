using backend.Domain.Entities;
using backend.Domain.Interfaces;
using backend.Domain.RepositoryInterfaces;

namespace backend.Domain.Services
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        private readonly IProductService _productService;


        public ProductService(IProductService productService)
        {
            _productService = productService;
        }

        public int CreateNewProduct(Product product)
        {
            return _productRepository.AddProduct(product);
        }

        public int DeleteProductById(int id)
        {
           return _productRepository.DeleteProduct(id);
        }

        public List<Product> FindProduct(Product product)
        {
           return _productRepository.SeachProduct(product);
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public List<Product> GetProducts()
        {
            return _productRepository.GetAllProducts();                                     
        }

        public bool ProductExists(Product product)
        {
            return _productRepository.ProductExists(product);                        
        }

        public int UpdateProduct(Product product)
        {
            return _productRepository.UpdateProduct(product);
        }
    }
}
