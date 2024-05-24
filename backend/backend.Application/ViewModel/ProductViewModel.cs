using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Application.ViewModel
{
    public class ProductViewModel
    {

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; } = 0.0m;

        public ProductViewModel(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }

        public ProductViewModel() {  }
    }
}
