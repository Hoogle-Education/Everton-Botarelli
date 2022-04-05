
namespace enums_and_layers.entities {
    public class HourContract {

        public DateTime Date { get; set; }
        public double perHour { get; set; }
        public double hour { get; set; }

        public HourContract(DateTime date, double perHour, double hour) {
            Date = date;
            this.perHour = perHour;
            this.hour = hour;
        }

        public double TotalValue() {
            return hour * perHour;
        }

        public override string ToString() {
            return $"Date of Contract: {Date.Day}/{Date.Month}/{Date.Year}\n" +
                    $"Total Value = {TotalValue()}";
        }
    }
}
