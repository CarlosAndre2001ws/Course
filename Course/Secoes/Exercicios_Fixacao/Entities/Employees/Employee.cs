namespace Course.Secoes.Exercicios_Fixacao.Entities.Employees;

public class Employee (int id, string name, double salary)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public double Salary { get; set; } = salary;
    
    public void IncreaseSalary(double percentage)
    {
        Salary += Salary * percentage / 100.0;
    }
}