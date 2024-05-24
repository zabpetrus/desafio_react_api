using backend.Domain.Entities;
using backend.InfraData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.InfraData.Repositories
{
    public class ProductRepository : IProductRepository
    {

        private readonly IProductRepository _repository;

        public ProductRepository(IProductRepository repository)
        {
            _repository = repository;
        }


        public int AddProduct(Product product)
        {
            return _repository.AddProduct(product); 
        }

        public int DeleteProduct(int id)
        {
            return  _repository.DeleteProduct(id);    
        }

        public List<Product> GetAllProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
        }

        public int UpdateProduct(Product product)
        {
            return _repository.UpdateProduct(product);    
        }
    }
}
