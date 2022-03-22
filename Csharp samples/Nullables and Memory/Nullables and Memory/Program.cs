namespace Application {


    public class Test {

        public static int sum(params int[] sequencia) {
            int sum = 0;
            
            for (int i = 0; i < sequencia.Length; i++) {
                sum += sequencia[i];
            }

            return sum;
        }

        public static string crip(params string[] frase) {

/*            string retorno = "";

            foreach(string palavra in frase) {
                int cont = 0;
                for(int i=0; i<palavra.Length; i++) {
                     += cont;
                }
            }*/

            return null;
        }

        public static void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void result(double x, out double r) {
            r = x * 1.1;
        }

    }

    public class Program {

        public static void Main(string[] args) {

            Console.WriteLine( Test.sum(1, 2, 3, 4) );

            int x = 2;
            int y = 3;

            Test.swap(ref x, ref y);
            Test.result(100.0, out double r);

            Console.WriteLine($"x = {x} e y = {y}");

        }
    }


}