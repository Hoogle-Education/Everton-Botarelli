namespace Constructor {
    public class Pessoa {

        private string Name;
        private int Age;
        private long Number;

        public Pessoa(string name, int age) {
            Name = name;
            Age = age;
        }

        public Pessoa(string name, int age, long number) {
            Name = name;
            Age = age;
            Number = number;
        }

        public string GetName() {
            return Name;
        }

        public int GetAge() {
            return Age;
        }

        public long GetNumber() {
            return Number;
        }

        public void SetNumber(long number) {
            this.Number = number;
        }



    }
}
