using Course.Secoes.Secao_8.Aula109.Entities;

namespace Course.Secoes.Secao_8.Aula109;

public class Program
{
    public static void Run()
    {
        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
        
        Console.WriteLine(account.Balance);
    }
}