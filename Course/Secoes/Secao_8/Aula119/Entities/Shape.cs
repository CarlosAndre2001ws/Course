namespace Course.Secoes.Secao_8.Aula119.Entities;

public abstract class Shape(Color color)
{
    public Color Color { get; set; }

    public abstract double Area();
}