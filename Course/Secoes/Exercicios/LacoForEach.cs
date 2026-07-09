namespace Course.Secoes.Exercicios;

public class LacoForEach
{
    public static void Run()
    {
        string [] vect = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

        foreach (var item in vect)
        {
            Console.WriteLine(item);
        }
    }
}