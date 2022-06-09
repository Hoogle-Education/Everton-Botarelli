using Bank_system.entities.account;

namespace FairSystem {

    public class Program {

        public static void Main(string[] args) {
            Account ac = new SavingsAccount("teste");
            Account ac2 = new SavingsAccount("teste");

            Console.WriteLine(ac.Number);
            Console.WriteLine(ac2.Number);
        }

    }
}