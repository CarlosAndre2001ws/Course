using Course.Secoes.Secao_8.Aula102.Entities.Enums;

namespace Course.Secoes.Secao_8.Aula102.Entities;

public class Worker(string name, string department, string level, double baseSalary)
{
    public string Name {  get; set; } = name;
    public WorkerLevel Level {  get; set; } = Enum.Parse<WorkerLevel>(level);
    public double BaseSalary {  get; set; } = baseSalary;
    private List<HourContract> Contracts {  get; set; } = [];
    public Department Department {  get; set; } = new(department);

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