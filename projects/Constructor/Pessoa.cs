namespace Constructor {
    public class Pessoa {

        public string Name;
        public int Age;
        public long Number;

        public Pessoa(string name, int age) {
            Name = name;
            Age = age;
        }

        public Pessoa(string name, int age, long number) {
            Name = name;
            Age = age;
            Number = number;
        }

        public void Foo(String random) {
            Console.WriteLine(random);
        }

        public void Birthday() {
            Age++;
            this.Foo("just a test");
        }

        public bool Equals(Pessoa other) {

            if(this.Name == other.Name && this.Age == other.Age) {
                return true;
            }else {
                return false;
            }

        }

    }
}
