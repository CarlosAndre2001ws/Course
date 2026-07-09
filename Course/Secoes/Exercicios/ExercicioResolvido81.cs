namespace Course.Secoes.Exercicios;

public class ExercicioResolvido81
{
    public static void Run()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(values[j]);
            }
        }

        List<int> mainDiag = new List<int>();
        int negatives = 0;
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == j)
                {
                    mainDiag.Add(matrix[i, j]);
                }

                if (matrix[i, j] < 0)
                {
                    negatives++;
                }
            }
        }

        Console.WriteLine("Main diagonal: ");
        foreach (var number in mainDiag)
        {
            Console.Write($"{number} ");
        }

        Console.WriteLine();
        Console.WriteLine($"Negative numbers: = {negatives}");
    }
}