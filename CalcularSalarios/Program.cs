using System.Globalization;
using CalcularSalarios.Entities.Enums;
using CalcularSalarios.Entities;


namespace CalcularSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name': ");
            string dptName = Console.ReadLine();
            Console.WriteLine("Enter worker data. ");
            Console.WriteLine();
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Júnior, MidLevel,Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Departament dept = new Departament(dptName);
            Worker worker = new Worker(name, level, baseSalary, dept);


            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contrat data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateOnly date = DateOnly.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valurPerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration hours: ");
                int durationHour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valurPerHour, durationHour);
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Departament: {worker.Departament.Name} ");
            Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year,month).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}