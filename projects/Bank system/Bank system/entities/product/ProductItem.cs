using Bank_system.entities.enums;

namespace Bank_system.entities.product {
    public class ProductItem {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public Category Category { get; set; }

        public ProductItem(string name, string description, double price, Category category) {
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Category = category;
        }

    }
}
