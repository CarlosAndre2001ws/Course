namespace Course.Secoes.Secao_8.Aula119.Entities;

public class Circle(Color color, double radius) : Shape(color)
{
    public double Radius { get; set; } = radius;
    
    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}