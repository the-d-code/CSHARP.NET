namespace SimpleIntrestCalculate.Models
{
    public class Intrest
    {
        public decimal Principal { get; set; }
        public decimal Rate { get; set; }
        public int TimePeriod { get; set; }

        public decimal CalculateSimpleInterest()
        {
            return (Principal * Rate * TimePeriod) / 100;
        }

    }
}
