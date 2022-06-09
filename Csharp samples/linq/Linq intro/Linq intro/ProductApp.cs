using Linq_intro.entities;
using System.IO;
using System;

namespace Linq_intro {

    public class ProductApp {

        public static void Main(string[] args) {

            List<Category> categories = new List<Category>();
            List<Product> products = new List<Product>();

            try {
                var sourcepath = @"C:\\Users\\hugor\\Desktop\\Aulas\\alunos\\C#\\Everton profes\\Everton-Botarelli-aluno\\Csharp samples\\linq\\Linq intro\\category.csv";
             
                var lines = File.ReadAllLines(sourcepath);

                foreach(var line in lines){
                    var data = line.Split(",");
                    categories.Add(new Category { Id = int.Parse(data[0]) ,
                                                  Name = data[1], 
                                                  Tier = int.Parse(data[2]) });
                }

                sourcepath = @"C:\\Users\\hugor\\Desktop\\Aulas\\alunos\\C#\\Everton profes\\Everton-Botarelli-aluno\\Csharp samples\\linq\\Linq intro\\products.csv";
                lines = File.ReadAllLines(sourcepath);
                
                foreach(var line in lines) {
                    string[] data = line.Split(",").Skip(1);

                    var category = categories
                                    .Where(c => c.Tier == int.Parse(data[3]))
                                    .First();

                    products.Add(new Product {
                        Id = int.Parse(data[0]),
                        Name = data[1],
                        Price = double.Parse(data[2]),
                        Category = category
                    });
                }

                foreach (var product in products) {
                    Console.WriteLine( product );
                }

            } catch (IOException excep) {
                Console.WriteLine(excep.Message); ;
            }

            // data source -> query -> run

            int option;

            do {
                menu();
                option = int.Parse(Console.ReadLine());

                switch (option) {
                    case 1:
                        Console.Write("Digite um preço maximo: ");
                        double priceLimit = double.Parse(Console.ReadLine());
                        Console.Write("Digite um Tier minimo: ");
                        int minimumTier = int.Parse(Console.ReadLine());

                        FilterByTierAndPrice(products, priceLimit, minimumTier);
                        break;
                    case 2:
                        Console.Write("Digite uma categoria: ");
                        string category = Console.ReadLine();

                        Console.Write("Digite o valor a ser aumentado: ");
                        double increment = double.Parse(Console.ReadLine());

                        FilterByCategoryAndIncrement(products, category, increment);
                        break;
                }

            } while (option != 0);


        }

        private static void FilterByCategoryAndIncrement(List<Product> products,
                string category, double increment) {
            var result = products
                            .Where(x => x.Category.Name == category)
                            .Select(p => new Product(p.Id, p.Name, p.Price + increment, p.Category));

            foreach (Product product in result) {
                Console.WriteLine(product);
            }
        }

        private static void FilterByTierAndPrice(List<Product> products,
                        double priceLimit, int minimumTier) {

            // predicate -> pode ser substituida por "tal que"
            /*var result = products.Where(p => (p.Price <= priceLimit && p.Category.Tier <= minimumTier));*/

            var result = from p in products
                         where p.Category.Tier <= minimumTier
                         select p;

            foreach(Product p in result) {
                Console.WriteLine(p);
            }
        }



        public static void menu() {
            Console.WriteLine("1 - to filter by price and tier");
            Console.WriteLine("2 - choose a categort and reajust the price");
            Console.WriteLine("0 - to get out");
            Console.Write("Choose an option: ");
        }



    }

}
/*            menu();
            int option = int.Parse(Console.ReadLine());
            
            while(option != 0){
                Console.WriteLine("running process ...");

                menu();
                option = int.Parse(Console.ReadLine());
            }*/