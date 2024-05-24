using backend.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.Interfaces
{
    public interface IProductAppService
    {
        //Lista todos os produtos
        List<ProductViewModel> GetAllProducts();

        //Obtem o produto pelo id
        ProductViewModel GetProductById(int id);

        //Cria um novo Produto
        int CreateNewProduct(ProductViewModel product);

        //Atualiza um produto dado o id e os demais dados do produto
        int UpdateProduct(int id, ProductViewModel product);

        //Exclui um produto por id
        int DeleteProductById(int id);


    }
}
