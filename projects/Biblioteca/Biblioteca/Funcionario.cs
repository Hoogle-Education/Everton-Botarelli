namespace Biblioteca {
    public class Funcionario {
     
        public string Nome { get; private set; }
        public string Sexo { get; private set; }
        public long RegistroFuncionario { get; private set; }
        public Cargo Cargo { get; set; }

        public Funcionario(string Nome, string Sexo,
            long RegristroFuncionario, Cargo Cargo){
                this.Nome = Nome;
                this.Sexo = Sexo;
                this.RegistroFuncionario = RegristroFuncionario;
                this.Cargo = Cargo;    
        }

        public override string ToString() {
            return $"Nome: {Nome}\n" +
                   $"Sexo: {Sexo}\n" +
                   $"Número de Registro: {RegistroFuncionario}\n" +
                   $"Cargo: {Cargo}\n" +
                   "---------------------------";
        }

    }
}
