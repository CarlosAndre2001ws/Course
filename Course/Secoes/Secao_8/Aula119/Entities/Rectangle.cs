namespace Course.Secoes.Secao_8.Aula119.Entities;

public class Rectangle(Color color, double width, double height) : Shape(color)
{
    public double Width { get; set; } = width;
    public double Height { get; set; } = height;

    public override double Area()
    {
        return Width * Height;
    }
}