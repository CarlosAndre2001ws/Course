using System.Globalization;
using Course.Secoes.Secao_8.Aula102.Entities;
using Course.Secoes.Secao_8.Aula102.Entities.Enums;

namespace Course.Secoes.Secao_8.Aula102;

public class Program
{
    public static void Run()
    {
        Console.Write("Enter department's name: "); string? deptName = Console.ReadLine();
        Console.WriteLine("Enter worker data:");
        Console.Write("Name: "); string? name = Console.ReadLine();
        Console.WriteLine("Level (Junior/MidLevel/Senior): "); 
        WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
        Console.Write("Base salary: ");
        double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Department dept = new Department(deptName);
        Worker newWorker = new Worker(name, dept, level, baseSalary);

        Console.Write("How many contracts to this worker? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter #{i + 1} contract data");
            Console.Write("Date (DD/MM/YYYY): "); DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Value Per Hour:  "); double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duration (hours): "); int durationHours = int.Parse(Console.ReadLine());
            
        }
    }
}         