
namespace CalcularSalarios.Entities
{
    class HourContract
    {
        public DateOnly Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateOnly date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
