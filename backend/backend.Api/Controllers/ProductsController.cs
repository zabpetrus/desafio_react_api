using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Domain.Entities;
using backend.Application.Interfaces;
using backend.Application.ViewModel;

namespace backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductsController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var response = await Task.Run(() => _productAppService.GetAllProducts());
            return Ok(response);
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await Task.Run(() => _productAppService.GetProductById(id));

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, [FromBody] ProductViewModel productViewModel)
        {
            try
            {
                var productUpdated = await Task.Run(() => _productAppService.UpdateProduct(id, productViewModel));
                if (productUpdated == 1) return Ok("Atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                return NotFound(ex);
            }

            return NoContent();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct([FromBody] ProductViewModel product)
        {
            var response = await Task.Run(() => _productAppService.CreateNewProduct(product));
            return Ok(response);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var response = await Task.Run(() => _productAppService.DeleteProductById(id));
            return Ok(response);
        }

        private bool ProductExists(int id)
        {
            return _productAppService.ProductExists(id);
        }

        // POST: api/Products/Search
        [HttpPost("Search")]
        public async Task<IActionResult> SearchProduct([FromBody] ProductViewModel productViewModel)
        {
            var response = await Task.Run(() => _productAppService.SeachProduct(productViewModel));
            if (response.Any())
            {
                return Ok(response);
            }
            return NoContent();
        }
    }
}
