namespace Course.Secoes.Secao_3;

public class Concatenacao
{
    public static void Run()
    {
        string frase = Console.ReadLine();

        string x = Console.ReadLine();
        string y = Console.ReadLine();
        string z = Console.ReadLine();


        string[] vect = Console.ReadLine().Split(' ');

        string a = vect[0];
        string b = vect[1];
        string c = vect[2];

        Console.WriteLine(frase);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        Console.WriteLine(a + " " + b + " " + c);
    }
}