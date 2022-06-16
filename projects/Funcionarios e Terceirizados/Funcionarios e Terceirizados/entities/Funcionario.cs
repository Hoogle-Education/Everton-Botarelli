
using Funcionarios_e_Terceirizados.entities.enums;
using Funcionarios_e_Terceirizados.entities.interfaces;

namespace Funcionarios_e_Terceirizados.entities {
    
    public class Funcionario : ReajusteSalarial {

        public DadosPessoais DadosPessoais { get; set; }
        public Endereco Endereco { get; set; }

        public Cargo Cargo { get; set; }
        public double Salario { get; set; }
        public DateTime Data_contratacao { get;  set; }

        public Funcionario() {
        }

        public Funcionario(DadosPessoais dadosPessoais, Endereco endereco,
            Cargo cargo, double salario, DateTime data_contratacao) {
            DadosPessoais = dadosPessoais;
            Endereco = endereco;
            Cargo = cargo;
            Salario = salario;
            Data_contratacao = data_contratacao;
        }

        public virtual void ReajustaSalario() {
            if (TempoNaEmpresa() && Salario < 10000) {
                Salario *= 1.1;
            }
        }

        public virtual Boolean TempoNaEmpresa() {
            DateTime Actual = DateTime.Now;
            int tempo = Actual.Year - Data_contratacao.Year;
            return tempo > 2;
        }

    }
}
