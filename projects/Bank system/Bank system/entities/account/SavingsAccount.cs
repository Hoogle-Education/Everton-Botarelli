namespace Bank_system.entities.account {
    public class SavingsAccount : Account {
        
        public double Tax { get; private set; }

        public SavingsAccount(string holder) 
            : base(holder) {
        }

        public SavingsAccount(double balance, string holder, double tax)
            : base(balance, holder) {
            Tax = tax;
        }
        
        public void Invest(int meses){
            if(meses >= 6 ){

                Console.WriteLine($" ### demonstrativo dos investimentos ###");
                double ValorInicial = Balance ?? 0;

                for (int i = 1; i <= 8; i++) { 
                    Console.WriteLine($"Valor {i}° mês: {UpdateBalance()}");
                }

                Console.WriteLine($"Lucro obtido pelos investimentos: {Balance - ValorInicial}");
            }
        }

        private double UpdateBalance(){
            double value = Balance ?? 0.0;
            return (double)(Balance = value * (1.0 + Tax));
        }

        public override string ToString() {
            return "Savings "+ base.ToString();
        }

    }
}

// minhaConta.Invest(8)
// ### demonstrativo dos investimentos ###
// - 1º mês: <total>
// - 2º mês: <total>
// ....
// - 8º mês: <total>
// -----------------------------
// Lucro obtido pelos investimentos: <lucro>
// -----------------------------