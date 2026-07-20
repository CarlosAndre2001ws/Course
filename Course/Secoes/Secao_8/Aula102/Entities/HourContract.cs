namespace Course.Secoes.Secao_8.Aula102.Entities;

public class HourContract
{
    public DateTime Date { get; set; }
    private double ValuePerHour { get; set; }
    public int Hours { get; set; }

    public HourContract(DateTime date, double valuePerHour, int hours)
    {
        Date = date;
        ValuePerHour = valuePerHour;
        Hours = hours;
    }

    public double TotalValue() => ValuePerHour * Hours;
    
    public override string ToString()
    {
        return $"{ValuePerHour} Hours {Hours} hours";
    }
}