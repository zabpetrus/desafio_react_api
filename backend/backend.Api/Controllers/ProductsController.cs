using backend.Application.Interfaces;
using backend.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductAppService _productAppService;


        public ProductsController( IProductAppService productAppService )
        {
            _productAppService = productAppService;
        }


        // GET: api/<ProductsController>
        [HttpGet]
        public List<ProductViewModel> Get()
        {             
            return _productAppService.GetAllProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public ProductViewModel Get(int id)
        {
           return _productAppService.GetProductById(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] ProductViewModel productviewmodel)
        {
            _productAppService.CreateNewProduct(productviewmodel);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProductViewModel productviewmodel)
        {
           if(productviewmodel.Equals(null) || id == 0 )
           {
                return BadRequest();
           }

            int result = _productAppService.UpdateProduct(id, productviewmodel);

            if (result == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Desculpa...Não foi possivel atualizar o produto");
            }
            else
            {
                return Ok("Requisição feita com sucesso!");
            }
           
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int result = _productAppService.DeleteProductById(id);
            if(result== 0 )
            {
                return BadRequest("Não foi possivel excluir o produto!");
            }
            else
            {
                return Ok("Exclusão feita com sucesso!");
            }

        }
    }
}
