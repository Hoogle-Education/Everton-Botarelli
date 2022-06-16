namespace Funcionarios_e_Terceirizados.entities {
    public class Endereco {

        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }

        public Endereco() {
        }

        public Endereco(string pais, string estado, string cidade,
            string rua, int numero, string cEP) {
            Pais = pais;
            Estado = estado;
            Cidade = cidade;
            Rua = rua;
            Numero = numero;
            CEP = cEP;
        }
    }
}
