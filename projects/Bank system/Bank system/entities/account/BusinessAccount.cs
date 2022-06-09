
namespace Bank_system.entities.account {
    public class BusinessAccount : Account {

        public string Manager { get; set; }
        public double Fees { get; private set; }

        public BusinessAccount(double balance, string holder, int number, string manager) 
            : base(balance, holder) {
            Manager = manager;
            Fees = 0;
        }

        public void Loan(double amount) {
            if(Balance + 100.0 < amount) {
                if(amount < Balance) Balance -= amount;
                else {
                    Balance = 0;
                    amount -= Balance??= 0;
                    Fees += amount;
                }
            } else {
                Console.WriteLine("Cannot loan");
            }
        }

        public override sealed string ToString() {
            return base.ToString() 
                + $"\nFees: {Fees}" ;
        }

    }
}

// new BusinessAccount()
