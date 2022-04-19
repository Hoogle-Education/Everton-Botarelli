
namespace Bank_system.entities {
    public class Account {

        public double Balance { get; protected set; }
        public string Holder { get; set; }
        public int Number { get; private set; }

        public Account(double balance, string holder, int number) {
            Balance = balance;
            Holder = holder;
            Number = number;
        }

        public Account(string holder, int number) {
            Balance = 0;
            Holder = holder;
            Number = number;
        }

        public void Deposit(double amount) {
            Balance += amount; // balance = balance + amount
        }

        public void withdraw(double amount) {
            Balance -= amount;
        }

        public override string ToString() {
            return $"Balance: {Balance}";
        }

    }
}
