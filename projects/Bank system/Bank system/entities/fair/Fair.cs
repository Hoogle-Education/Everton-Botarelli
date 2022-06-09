
namespace Bank_system.entities.fair {
    public class Fair {

        public List<Consummer> Consummers { get; set; }
        public List<Salesman> Salesmans { get; set; }

        public Fair() {
            Consummers = new List<Consummer> ();
            Salesmans = new List<Salesman> ();
        }

    }
}
