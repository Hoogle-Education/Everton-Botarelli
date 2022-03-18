namespace Structs {

    struct Number {
        public int real;
        public int imaginary;
    }

    class Program {

        public static void Swap(int a, int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Main(string[] args) {

            Number Z;
            Z.real = 2;
            Z.imaginary = 3;

            Swap(Z.real, Z.imaginary);

            Console.WriteLine($"{Z.real} + {Z.imaginary}i");

        }
    }
}