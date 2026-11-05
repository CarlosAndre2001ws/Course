namespace Course.Secoes.Secao_8.Aula114.Entities;

public class OutsourcedEmployee : Employee
{
    public double AdditionalCharge {get; set;}
    
    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public override double Payment()
    {
        return ((Hours * ValuePerHour) + (AdditionalCharge * 1.1));
    }
}