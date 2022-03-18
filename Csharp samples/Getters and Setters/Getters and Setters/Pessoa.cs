namespace Constructor {
    public class Pessoa {

        public string Name { get; private set; }
        public int Age { get; private set; }
        private long _number;

        public Pessoa(string name, int age) {
            Name = name;
            Age = age;
        }

        public Pessoa(string name, int age, long number) {
            Name = name;
            Age = age;
            _number = number;
        }

        public long Number {
            get { return _number; }
            set { 
                if(value > 0) _number = value;
                else Console.WriteLine($"O valor = {value} é inválido!");
            }
        }

        public override string ToString() {
            return "Tipo: Pessoa\n"
                    + $"Nome = {Name}\n"
                    + $"Idade = {Age}\n" 
                    + $"Telefone {_number}\n";
        }
    }
}
