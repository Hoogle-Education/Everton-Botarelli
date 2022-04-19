namespace Bank_system.entities {
    public class SavingsAccount : Account {
        
        public double Tax { get; private set; }

        public SavingsAccount(string holder, int number) 
            : base(holder, number) {
        }

        public SavingsAccount(double balance, string holder, int number, double tax)
            : base(balance, holder, number) {
            Tax = tax;
        }
        
        public void Invest(int meses){
            if(meses >= 6 ){

                Console.WriteLine($" ### demonstrativo dos investimentos ###");
                double ValorInicial = Balance;

                for (int i = 1; i <= 8; i++) { 
                    Console.WriteLine($"Valor {i}° mês: {UpdateBalance()}");
                }

                Console.WriteLine();
            }
        }

        private double UpdateBalance(){
            return Balance *= (1.0 + Tax);
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