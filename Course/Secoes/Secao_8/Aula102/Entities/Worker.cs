using Course.Secoes.Secao_8.Aula102.Entities.Enums;

namespace Course.Secoes.Secao_8.Aula102.Entities;

public class Worker
{
    public string Name {  get; set; }
    public WorkerLevel Level {  get; set; }
    public double BaseSalary {  get; set; }
    private List<HourContract> Contracts {  get; set; }
    public Department Department {  get; set; }
    
    public Worker(string name, Department department, WorkerLevel level, double baseSalary)
    {
        Name = name;
        Department = department;
        Level = level;
        BaseSalary = baseSalary;
    }
    
    public void AddContract(HourContract contract)
    {
        Contracts.Add(contract);
    }

    public void RemoveContract(HourContract contract)
    {
        Contracts.Remove(contract);
    }

    public double Income(int year, int month)
    {
        return BaseSalary + Contracts.Where(contract => contract.Date.Year == year && contract.Date.Month == month).Sum(contract => contract.TotalValue());
    }
}