namespace Biblioteca {

    public class Livro {
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public int AnoLancamento { get; private set; }
        public decimal Valor { get; set; }
        public string Descricao { get;  set; }

        public Livro(string titulo, string autor, int anoLancamento, decimal valor) {
            Titulo = titulo;
            Autor = autor;
            AnoLancamento = anoLancamento;
            Valor = valor;
            Descricao = "Nao possui";
        }

        public Livro(string titulo, string autor, int anoLancamento, decimal valor, string descricao) 
            : this(titulo, autor, anoLancamento, valor) {
            Descricao = descricao;
        }

        public override string ToString(){
            return $"Título: {Titulo}\n" +
                   $"Autor: {Autor}\n" +
                   $"Ano de Lançamento {AnoLancamento}\n" +
                   $"Ddescrição: {Descricao}\n" +
                   "---------------------------";
        }

    }

}
