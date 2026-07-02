using System.Globalization;
using Course.Secoes.Exercicios.entities.ExercicioEntities_3;

namespace Course.Secoes.Exercicios;

public class ExercicioFixacao3
{
    public static void Run()
    {
        Console.Write("Nome do aluno: "); var nome = Console.ReadLine();
        Console.WriteLine("Digite as três notas do aluno: ");
        Aluno a = new Aluno(nome, 0.0);
        for (int i = 0; i < 3; i++)
        {
            while (true)
            {
                string input = Console.ReadLine()!;
                double nota = double.Parse(input, CultureInfo.InvariantCulture);

                if (a.IncrementarNota(nota))
                {
                    break; 
                }

                Console.WriteLine("Nota inválida, digite novamente: ");
            }
        }
        
        a.AlunoReport();
    }
}