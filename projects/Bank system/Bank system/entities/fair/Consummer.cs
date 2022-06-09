using Bank_system.entities.account;
using Bank_system.entities.product;

namespace Bank_system.entities.fair {
    public class Consummer {

        public string Name { get; private set; }

        public Account Account { get; set; }

        public List<Product> Shoplist { get; private set; }

        public Consummer(string name, Account account) {
            Name = name;
            Account = account;
            Shoplist = new List<Product>();
        }

        public void AddToShoplist(Product product) {
            Shoplist.Add(product);
        }

    }
}
