namespace Course.Secoes.Exercicios_Fixacao;

public class ExercicioFixacao82
{
    public static void Run()
    {
        int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = dimensions[0];
        int cols = dimensions[1];
        
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            int[] rowData = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = rowData[j];
            }
        }
        
        int x = int.Parse(Console.ReadLine());

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] == x)
                {
                    Console.WriteLine($"Position {i},{j}:");
                    if (j - 1 >= 0)                Console.WriteLine("Left: " + matrix[i, j - 1]);
                    if (j + 1 < cols)              Console.WriteLine("Right: "+ matrix[i, j + 1]);
                    if (i - 1 >= 0)                Console.WriteLine("Up: "   + matrix[i - 1, j]);
                    if (i + 1 < rows)              Console.WriteLine("Down: " + matrix[i + 1, j]);
                }
            }
        }
    }
}