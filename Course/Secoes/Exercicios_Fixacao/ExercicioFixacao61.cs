using Course.Secoes.Exercicios_Fixacao.Entities;

namespace Course.Secoes.Exercicios_Fixacao;

public class ExercicioFixacao61
{
    public static void Run()
    {
        var c = new Conta();
        
        c.Depositar();
        
        c.Sacar();
        
        c.Nome = "Lucas";

        Console.WriteLine(c.Saldo);

        Console.WriteLine(c.NumeroConta);
    }
}