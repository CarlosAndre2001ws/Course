using System.Globalization;

namespace Course.Secoes.Secao_3;

public class Formatting
{
    public static void Run()
    {
        char genero = 'F';
        int idade = 32;
        double saldo = 10.35784;
        string nome = "Maria";

        Console.Write("Bom dia!");
        Console.WriteLine("Boa tarde!");
        Console.WriteLine("Boa noite!");
        Console.WriteLine("------------------------");
        Console.WriteLine(genero);
        Console.WriteLine(idade);
        Console.WriteLine(saldo);
        Console.WriteLine(nome);
        Console.WriteLine(saldo.ToString("F2"));
        Console.WriteLine(saldo.ToString("F4"));
        Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

        Console.WriteLine("-------------------------");

        Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} R$ reais", nome, idade, saldo);
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} R$ reais.");
    }
}