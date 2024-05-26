using backend.Domain.Entities;
using backend.InfraData.Context;
using backend.InfraData.Interfaces;
using Microsoft.EntityFrameworkCore;
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


        private readonly backendApiContext _context;

    
        public ProductRepository(IProductRepository repository, backendApiContext context)
        {
            _repository = repository; 
            _context = context;
        }


        public int AddProduct(Product product)
        {
            _context.Product.Add(product);
            _context.SaveChanges();

            return 1;
            
        }

        public int DeleteProduct(int id)
        {
            var product = _context.Product.Find(id);
            if (product == null)
            {
                return 0;  //NoT Found
            }
            else
            {
                _context.Product.Remove(product);
                _context.SaveChanges();
                return 1;  //ok
            }
        }

        public List<Product> GetAllProducts()
        {
            return  _context.Product.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Product.Find(id);
        }

        public bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.id == id);
        }

   
        public int UpdateProduct(Product product)
        {
            _context.Entry(product).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                return 1;
            }
            catch (DbUpdateConcurrencyException)
            {
               return 0;    
            }
        }

        public List<Product> SeachProduct(Product product)
        {
            var query = _context.Product.AsQueryable();

            if (!string.IsNullOrEmpty(product.name))
            {
                query = query.Where(p => p.name.Contains(product.name));
            }

            if (product.price > 0)
            {
                query = query.Where(p => p.price == product.price);
            }            

            return query.ToList();
        }

    }
}

