using System.Globalization;

namespace Course.Secoes.Exercicios.entities.ExercicioEntities_3;

public class Aluno (string nome, double nota)
{
    public string Nome { get; set; } = nome;
    public double Nota { get; set; }

    private int _trimestre = 0;

    public bool IncrementarNota(double nota)
    {
        if (!(_trimestre < 1 && nota > 0.00 && nota < 30.00) && !(_trimestre >= 1 && nota > 0.00 && nota < 35.00))
        {
            return false;
        }
        _trimestre++;
        Nota += nota;
        return true;
    }
    
    public void AlunoReport()
    {
        Console.WriteLine("NOTA FINAL: " + Nota.ToString("F2", CultureInfo.InvariantCulture));
        if (Nota >= 60.0)
        {
            Console.WriteLine("APROVADO");
        } else {
            Console.WriteLine("REPROVADO");
            Console.WriteLine("FALTARAM " + (60.0 - Nota).ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
        }
    }
}