using enums_and_layers.entities.enums;
using enums_and_layers.entities;


namespace enums_and_layers.application {
    public class Program {

        public static void Main(string[] args) {
                
            List <Worker> workers = new();

            workers.Add(new Worker("Joao",
                                    WorkerLevel.Pleno,
                                    2000.00,
                                    new Department("Database")
                                   )); 

            workers.Add(new Worker("Maria",
                         WorkerLevel.Senior,
                         3000.00,
                         new Department("Human Resources")
                        ));


            int year = 2020;
            foreach (Worker worker in workers) {
                worker.AddContract(new HourContract( new DateTime(year, 04, 01), 50.0, 20) );
                year += 4;
            }

            foreach (Worker worker in workers) {
                Console.WriteLine(worker);
                Console.WriteLine($"Total Amount = {worker.Income(2022 , 04)}\n");
            }

        }

    }

}