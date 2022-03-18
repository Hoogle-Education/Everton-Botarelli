namespace Biblioteca {

    public class Sistema {

        public static List<Funcionario> funcionarios = new();
        public static List<Livro> acervo = new();

        public static void menu() {
            Console.WriteLine(
                "1 - Adicionar novo Livro\n" +
                "2 - Adicionar novo funcionario\n" +
                "3 - Mostrar acervo de livros\n" +
                "4 - Mostrar quadro de funcionários\n" +
                "0 - Sair"
                );
        }

        public static void Main(String[] args) {

            menu();
            int option = int.Parse(Console.ReadLine());

            while( option != 0 ) {

                switch (option) {
                    case 1:
                        Console.WriteLine("Coloque os dados Titlo/ Autor/ Ano de Lançamento / Preço");
                        acervo.Add( new Livro(
                               Console.ReadLine(),
                               Console.ReadLine(),
                               int.Parse(Console.ReadLine()),
                               decimal.Parse(Console.ReadLine()) 
                            ));
                        break;
                    case 3:
                        foreach(Livro livro in acervo) Console.WriteLine(livro);
                        break;
                }

                menu();
                option = int.Parse(Console.ReadLine());
            }

        }

    }

}