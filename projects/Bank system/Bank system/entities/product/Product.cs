namespace Bank_system.entities.product {
    public class Product {

        public ProductItem productItem { get; set; }
        public int Quantity { get; set; }

        public Product (ProductItem productItem, int quantity) {
            this.productItem = productItem;
            Quantity = quantity;
        }

        public double getTotal() {
            return Quantity * productItem.Price;
        }

    }
}
