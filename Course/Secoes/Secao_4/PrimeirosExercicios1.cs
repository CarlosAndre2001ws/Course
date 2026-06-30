using Course.Secoes.Secao_4.entities;

namespace Course.Secoes.Secao_4;

public class PrimeirosExercicios1
{
    public static void Run()
    {
        Console.WriteLine("Dados da primeira pessoa");
        Console.Write("Nome: "); string nome = Console.ReadLine();
        Console.Write("Idade: "); int idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Dados da segunda pessoa");
        Console.Write("Nome: "); string nomeB = Console.ReadLine();
        Console.Write("Idade: "); int idadeB = int.Parse(Console.ReadLine());
        
        Pessoa a, b;
        
        a =  new Pessoa(nome, idade);
        b =  new Pessoa(nomeB, idadeB);
        
        Console.WriteLine("Pessoa mais velha: " + (a.Idade > b.Idade ? a.Nome : b.Nome));
    }
}