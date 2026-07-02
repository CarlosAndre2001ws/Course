namespace Course.Secoes.Exercicios.entities.ExercicioEntities_1;

public class Retangulo (double largura, double altura)
{
    public double Largura { get; set; } = largura;
    public double Altura { get; set; } =  altura;
    
    public string Area => (Largura * Altura).ToString("F2");
    
    public string Perimetro => (2.00 * Largura + 2.00 * Altura).ToString("F2");
    
    public string Diagonal => (Math.Sqrt(Math.Pow(Largura, 2.00) + Math.Pow(Altura, 2.00))).ToString("F2");
}