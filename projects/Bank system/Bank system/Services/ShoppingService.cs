
using Bank_system.entities.fair;
using Bank_system.entities.product;
using System.Linq;

namespace Bank_system.Services {
    public class ShoppingService {

        public void GoToTheShop(Fair fair) {

            // predicate
            // lambda que podemos traduzir para "tal que"

            foreach(Consummer consumer in fair.Consummers) {

                foreach(Product prod in consumer.Shoplist) {
                    Salesman TheSaleman = fair
                                             .Salesmans
                                             .FindAll(s => s.Category == prod.productItem.Category)
                                             .Where((x, y) => x. , y.product.productItem < x.prod.productItem.price);

                }

            }

        }

    }
}
