using op30.ConsoleApplication.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace op30.ConsoleApplication.Models {
    public class ProductsRepository {
        public void CreateDataBase() {
            using (ApplicationContext context = new ApplicationContext()) {
                context.Database.Migrate();
            }
        }
        public IEnumerable<Product> GetProducts() {
            using (ApplicationContext context = new ApplicationContext()) {
                return context.Products;
            }
        }

        public IEnumerable<Product> GetProductsByBrand(string brand) {
            using (ApplicationContext context = new ApplicationContext()) {
                return context.Products.Where(p => p.Brand == brand);
            }
        }

        public Product GetProductById(int id) {
            using (ApplicationContext context = new ApplicationContext()) {
                return context.Products.SingleOrDefault(p => p.Id == id);
            }
        }
        public void AddProduct(Product product) {
            using (var db = new ApplicationContext()) {
                db.Products.Add(product);
                db.SaveChanges();
            }
        }
    }
}
