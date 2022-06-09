
namespace Bank_system.entities.account {
    public abstract class Account : Random {

        public override int Next() { 
            int number;
            do {
                number = base.Next(3333, 9987);
            } while ((Lista[number] != false) && (Lista[number] = true));
            return number;
        }

        // set false initially
        private static bool[] Lista = new bool[10000];

        public double? Balance { get; protected set; }
        public string? Holder { get; set; }
        public int? Number { get; private set; }

        public Account(double balance, string holder) {
            Balance = balance;
            Holder = holder;
            Number = Next();
        }

        public Account(string holder) {
            Balance = 0;
            Holder = holder;
            Number = Next();
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

        public override bool Equals(object? obj) {
            return obj is Account account &&
                   Balance == account.Balance &&
                   Holder == account.Holder &&
                   Number == account.Number;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Balance, Holder, Number);
        }
    }
}
