
using System.IO;

namespace Exceptions {

    public class Program {

        public static double Divide(double a, double b) {
            try {

                if (b > 200) throw new OverflowException("you reach the limit!");

                if( b == 0) throw new DivideByZeroException();

                return a / b;
            } catch (DivideByZeroException) {
                throw new DivideByZeroException("you cannot divide by zero!");
            } catch (OverflowException overflowException) {
                throw overflowException;
            }
        }

        public static void Main(string[] args) {

            double a, b;
            string outputText = null;
            string outputPath = @"C:\Users\hugor\Desktop\Aulas\alunos\" +
                                            @"C#\Everton profes\Everton-Botarelli-aluno\Csharp samples" +
                                            @"\Exceptions\Exceptions\output.txt";

            string[] input = File.ReadAllLines(@"C:\Users\hugor\Desktop\Aulas\alunos\" + 
                                            @"C#\Everton profes\Everton-Botarelli-aluno\Csharp samples" + 
                                            @"\Exceptions\Exceptions\input.txt");
        

            try {
                a = double.Parse(input[0]);
                b = double.Parse(input[1]);

                outputText = Divide(a, b).ToString();

            } catch (Exception excep) {
                outputText = "Error Message: " + excep.Message;
            } finally {
                using (StreamWriter sw = File.AppendText(outputPath)) {
                    sw.WriteLine(outputText);
                }
            }
        }
    }
}