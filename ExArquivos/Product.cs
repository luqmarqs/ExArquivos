using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExArquivos
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qtd { get; set; }

        public Product(string name, double price, int qtd)
        {
            Name = name;
            Price = price;
            Qtd = qtd;
        }

        public Product()
        {
        }
    }
}
