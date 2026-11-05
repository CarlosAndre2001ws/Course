using System.Globalization;
using Course.Secoes.Secao_8.Aula114.Entities;

namespace Course.Secoes.Secao_8.Aula114;

public class Program
{
    public static void Run()
    {
        List<Employee> employees = new List<Employee>();
        
        Console.Write("Enter the number of employees: "); int numberOfEmployees = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine("Employee #{0} data: ", i + 1);
            Console.Write("Outsourced (y/n)? : "); string outsourced = Console.ReadLine();
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Hours: "); int  hours = int.Parse(Console.ReadLine());
            Console.Write("Value per hour: "); double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (outsourced == "y")
            {
                Console.Write("Additional charge: "); double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Employee emp = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                employees.Add(emp);
            }
            else
            {
                Employee emp = new Employee(name, hours, valuePerHour);
                employees.Add(emp);
            }
        }

        Console.WriteLine();
        Console.WriteLine("PAYMENTS:");
        
        foreach (Employee emp in employees)
        {
            Console.WriteLine($"{emp.Name} - $  {emp.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}