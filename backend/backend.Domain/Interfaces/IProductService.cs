using backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts();

        //Obtem o produto pelo id
        Product GetProductById(int id);

        //Cria um novo Produto
        int CreateNewProduct(Product product);

        //Atualiza um produto dado o id e os demais dados do produto
        int UpdateProduct(Product product);

        //Exclui um produto por id
        int DeleteProductById(int id);
    }
}
