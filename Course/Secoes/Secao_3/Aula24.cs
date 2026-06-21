namespace Course.Secoes.Secao_3;

public class Aula24
{
    public static void Run()
    {
        int n1 = int.Parse(Console.ReadLine() ?? "");
        char ch = char.Parse(Console.ReadLine() ?? "");
        double n2 = double.Parse(Console.ReadLine() ?? "");
        
        string[] info = Console.ReadLine().Split(' ');
        
        string nome = info[0];
        char sexo = char.Parse(info[1]);
        int idade = int.Parse(info[2]);
        double altura = double.Parse(info[3]);
        
        
        Console.WriteLine("Você digitou:");
        
        
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2);
        
        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura);
    }
}