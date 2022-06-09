using Bank_system.entities.account;
using Bank_system.entities.product;

namespace Bank_system.entities.person {
    public class Person {

        public string Name { get; private set; }

        public string Adress { get; private set; }

        public int Age { get; private set; }

        public Account? account { get; private set; }

        public List<Product> shoplist { get; set; }

        public Person(string name, string adress, int age) {
            shoplist = new List<Product>();
            Name = name;
            Adress = adress;
            Age = age;
            this.account = account;
        }

        public void AddShoplist(Product product) {
            shoplist.Add(product);
        }

    }
}
