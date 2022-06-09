using Bank_system.entities.enums;
using Bank_system.entities.product;

namespace Bank_system.entities.fair {
    public class Salesman {

        public string Seller { get; set; }
        public double baseCost { get; set; }
        
        public Category Category { get; set; }
        List<Product> Products { get; set; }

        public Salesman(string seller, double baseCost, Category category) {
            Seller = seller;
            this.baseCost = baseCost;
            this.Category = category;
            Products = new List<Product>();
        }

        public bool IsOutOfStock() {
            int count = 0;

            foreach (Product product in Products) {
                count += product.Quantity;    
            }

            return count == 0;
        }

        public bool AddProduct(Product product) {

            if (product.productItem.category == Category) {
                Products.Add(product);
                return true;
            } else return false;

        }
    }
}
