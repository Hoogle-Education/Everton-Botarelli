namespace Funcionarios_e_Terceirizados.entities {
    public class DadosPessoais {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string telefone { get; set; }
        public int Idade { get; set; }

        public DadosPessoais() {
        }

        public DadosPessoais(string nome, string sobrenome,
            string telefone, int idade) {
            Nome = nome;
            Sobrenome = sobrenome;
            this.telefone = telefone;
            Idade = idade;
        }
    }
}
