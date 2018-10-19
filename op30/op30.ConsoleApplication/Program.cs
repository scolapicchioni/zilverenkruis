using op30.ConsoleApplication.Models;
using System;

namespace op30.ConsoleApplication {
    class Program {
        static void Main(string[] args) {
            ProductsRepository repo = new ProductsRepository();
            //how do I connect my DBContext with a real DB (SQL Server)?

            //how do I create the DataBase?
            repo.CreateDataBase();

            //how do I add a new Product?
            repo.AddProduct(new Product() { Name = "Laptop Latitude E5570", Brand = "Dell", Price = 1234 });

            //how do I list all the products?
            Console.WriteLine("**********************");
            foreach (Product product in repo.GetProducts()) {
                Console.WriteLine($"{product.Id} - {product.Brand} {product.Name} {product.Price}");
            }

            //how do I get a specific product?
            Product p = repo.GetProductById(1);
            Console.WriteLine($"{p.Id} - {p.Brand} {p.Name} {p.Price}");

            //how do I update an existing Product?
            p.Price = 9999;
            
            //how do I delete a Product?

            Console.ReadLine();
        }
    }
}
