namespace Course.Secoes.Secao_3;

public static class ExFix24
{
    public static void Run()
    {
        Console.WriteLine("Entre com o seu nome completo:");
        var nomeCompleto = Console.ReadLine();
        Console.WriteLine("Quantos quartos tem na sua casa?");
        var quartosCasa = Console.ReadLine();
        Console.WriteLine("Entre com o preço de um produto:");
        var precoProduto = Console.ReadLine();
        Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
        var info =  Console.ReadLine()?.Split(' ');

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine(nomeCompleto);
        Console.WriteLine(quartosCasa);
        Console.WriteLine(precoProduto);
        Console.WriteLine(info[0]);
        Console.WriteLine(info[1]);
        Console.WriteLine(info[2]);
    }
}