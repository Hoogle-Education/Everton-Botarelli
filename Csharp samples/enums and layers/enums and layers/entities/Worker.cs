using enums_and_layers.entities.enums;

namespace enums_and_layers.entities {

    public class Worker {

        public string Name { get; private set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; private set; }

        List<HourContract> Contracts = new(); // Tem vários
        private Department department;

        public Worker(string name, WorkerLevel level, double baseSalary) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department1) 
            : this(name, level, baseSalary) {
            this.department = department1;
        }

        public Department GetDepartment() {
            return department;
        }

        public void SetDepartment(Department value) {
            department = value;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {

            double total = BaseSalary;

            foreach (HourContract contract in Contracts) {

                if (contract.Date.Year < year) {
                    total += contract.TotalValue();
                } else if (contract.Date.Year == year && contract.Date.Month < month) {
                    total += contract.TotalValue();
                }

            }

            return total;
        }

        public override string ToString() {
            string aux =  $"Name: {Name}\n"
                   + $"Deparment: {department.Name}\n"
                   + $"Worker Level: {Level}\n";

            foreach(HourContract contract in Contracts) {
                aux += contract;
            }           

            return aux;
        }
    }
}
