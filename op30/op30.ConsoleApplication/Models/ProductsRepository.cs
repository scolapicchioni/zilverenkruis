using op30.ConsoleApplication.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace op30.ConsoleApplication.Models {
    public class ProductsRepository {
        public IEnumerable<Product> GetProducts() {
            ApplicationContext context = new ApplicationContext();
            return context.Products;
        }

        public IEnumerable<Product> GetProductsByBrand(string brand) {
            ApplicationContext context = new ApplicationContext();
            return context.Products.Where(p=>p.Brand==brand);
        }

        public Product GetProductById(int id) {
            ApplicationContext context = new ApplicationContext();
            return context.Products.SingleOrDefault(p => p.Id == id);
        }
    }
}
