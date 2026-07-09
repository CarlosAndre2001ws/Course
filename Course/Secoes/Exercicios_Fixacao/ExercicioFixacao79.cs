using System.Globalization;
using Course.Secoes.Exercicios_Fixacao.Entities.Employees;

namespace Course.Secoes.Exercicios_Fixacao;

public class ExercicioFixacao79
{
    public static void Run()
    {
        Console.Write("How many employees will be registered? "); int n = int.Parse(Console.ReadLine()!);
        List<Employee> employees = new List<Employee>();
        
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Employee #{i + 1}:");
            Console.Write("Id: "); int id = int.Parse(Console.ReadLine()!);
            Console.Write("Name: "); string name = Console.ReadLine()!;
            Console.Write("Salary: "); double salary = double.Parse(Console.ReadLine()!);
            Console.WriteLine();
            Employee employee = new Employee(id, name, salary);
            
            employees.Add(employee);
        }

        Console.Write("Enter the employee id that will have an salary increase: "); int  empId = int.Parse(Console.ReadLine()!);
        
        Employee? emp = employees.FirstOrDefault(x => x.Id == empId);
        
        if (emp != null)
        {
            Console.Write("Enter the percentage: "); double percentage = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            emp.IncreaseSalary(percentage);
        }
        else
        {
            Console.WriteLine("This id does not exist!");
        }

        Console.WriteLine("Updated list of employees:");
        foreach (var obj in employees)
        {
            Console.WriteLine($"{obj.Id}, {obj.Name}, {obj.Salary.ToString("F2", CultureInfo.CurrentCulture)}");
        }
        
    }
}