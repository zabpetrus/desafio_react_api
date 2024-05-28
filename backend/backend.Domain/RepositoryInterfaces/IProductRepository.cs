using backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.RepositoryInterfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();

        //Obtem o produto pelo id
        Product GetProductById(int id);

        //Cria um novo Produto
        int AddProduct(Product product);

        //Atualiza um produto dado o id e os demais dados do produto
        int UpdateProduct(Product product);

        //Exclui um produto por id
        int DeleteProduct(int id);

        List<Product> SeachProduct(Product product);

        bool ProductExists(int id);
    }
}
