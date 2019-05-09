using System;
using System.Collections.Generic;
using System.IO;

namespace productosç
{
    class Program
    {
        static void Main(string[] args)
        {           
            List<Product> productos = new List<Product>()
            {
                new Product("AA11","Lápiz Azul",22.50),
                new Product("AA12","Pluma Azul",34.50),
                new Product("AA13","Lápiz Negro",14.50),
            };
            
            ProductDB.SaveProducts("Productos.txt", productos);
        }
    }
    class Product
    {
        public string Code;
        public string Description;
        public double Price;
        public Product(string code, string description, double price){Code = code; Description = description; Price = price;}    
    }

    class ProductDB
    {
        public static void SaveProducts(string path, List<Product> products)
        {
            StreamWriter txtOut = new StreamWriter(
                new FileStream(path,FileMode.Create,FileAccess.Write));
            
            foreach(Product p in products)
            {
                txtOut.Write(p.Code+"|");
                txtOut.Write(p.Description+"|");
                txtOut.WriteLine(p.Price.ToString());                
            }
            txtOut.Close();
        }
    }
}
