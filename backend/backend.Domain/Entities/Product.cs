using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Domain.Entities
{
    public class Product
    {

        private int Id;

        private string? Name;

        private string? Description;

        private decimal Price = 0.0m;


        public int id
        {
            get {  return Id;  } 
            set { Id = value; }
        }

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }


        public string description
        {
            get { return Description.Length == 0 || Description.Equals(null) ? "" : Description; }
            set { Description = value; }
        }

        public decimal price
        {
            get { return Price.Equals(null) ? 0.0m : Price; }
            set { Price = value; }
        }


        public Product()
        {
        }

        public Product(int id, string name, string description, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }

        public override bool Equals(object? obj)
        {
            return obj is Product product &&
                   Id == product.Id &&
                   Name == product.Name &&
                   Description == product.Description &&
                   Price == product.Price;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Description, Price);
        }
    }
}
