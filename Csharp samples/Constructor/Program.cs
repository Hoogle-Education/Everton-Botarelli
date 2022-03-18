namespace Constructor {

   public class Program {

        public static void Main(string[] args) {

            Pessoa maria = new Pessoa("Maria da Silva", 25);

            Pessoa maria2 = new Pessoa("Maria da Silva", 25, 121826);

            maria.Birthday();

            Console.WriteLine(maria.Age);

            Console.WriteLine(maria.Equals(maria2));

        }

   }
    
}