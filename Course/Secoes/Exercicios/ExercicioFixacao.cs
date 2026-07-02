using System.Globalization;

namespace Course.Secoes.Exercicios;
using Course.Secoes.Exercicios.entities.ExercicioEntities_1;

public class ExercicioFixacao
{
    public static void Run()
    {
        Console.WriteLine("Entre com a largura e altura do retângulo: ");

        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Retangulo retangulo = new Retangulo(largura, altura);

        Console.WriteLine("AREA = " +  retangulo.Area);
        Console.WriteLine("PERÍMETRO = " +  retangulo.Perimetro);
        Console.WriteLine("DIAGONAL = " +  retangulo.Diagonal);
    }
}