using AutoMapper;
using backend.Application.Interfaces;
using backend.Application.ViewModel;
using backend.Domain.Entities;
using backend.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.AppService
{
    public class ProductAppService : IProductAppService
    {

        private readonly IProductAppService _productAppService;

        private readonly IProductService _productService;

        private readonly IMapper _mapper;


        public ProductAppService(){ }


        public ProductAppService
        (             
            IProductService productService, 
            IMapper mapper 
        ){ 
            _productService = productService; 
            _mapper = mapper;         
        }   
        
       
        public int CreateNewProduct(ProductViewModel productviewmodel)
        {
            Product product = _mapper.Map<Product>(productviewmodel);
            return _productService.CreateNewProduct(product);
            
        }

        public int DeleteProductById(int id)
        {
            return _productService.DeleteProductById(id);   
        }

        public List<ProductViewModel> GetAllProducts()
        {
            var productlist = _productService.GetProducts();
            return _mapper.Map<List<Product>, List<ProductViewModel>>(productlist);
        }

        public ProductViewModel GetProductById(int id)
        {
            Product product = _productService.GetProductById(id);
            return  _mapper.Map<ProductViewModel>(product);
        }

        public bool ProductExists(ProductViewModel productViewModel)
        {
            Product product = _mapper.Map<Product>(productViewModel);
            return _productService.ProductExists(product);  
        }

        public List<ProductViewModel> SeachProduct(ProductViewModel productviewmodel)
        {
            Product pr = _mapper.Map<Product>(productviewmodel);
            List<Product> productlist = _productService.FindProduct(pr);
            return _mapper.Map<List<Product>, List<ProductViewModel>>(productlist);

        }

        public int UpdateProduct(int id, ProductViewModel productviewmodel)
        {
            var product_mapped = _mapper.Map<Product>(productviewmodel);
            return _productService.UpdateProduct(product_mapped);
        }
    }
}
