namespace Program {
    public class Aluno {

        public string Nome;
        public int Idade;
        public int Matricula;
        public double MediaFinal;

        // fazer prova -> criar e entrar com duas notas
        // calcula media -> receber as provas e retornar a media

        public void FazerProva() {
            double p1, p2;

            Console.Write("Digite a primeira nota: ");
            p1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            p2 = double.Parse(Console.ReadLine());

            MediaFinal = CalculaMedia(p1, p2);

        }

        public double CalculaMedia(double x, double y) {
            return (x + y) / 2.0;
        }

    }
}
