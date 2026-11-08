using System.Globalization;
using Course.Secoes.Secao_8.Aula109.Entities;

namespace Course.Secoes.Secao_8.Aula109;

public class Program
{
    public static void Run()
    {
        List<Account> list = new List<Account>();
        
        list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
        list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
        list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
        list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

        double sum = 0.0;

        foreach (Account account in list)
        {
            sum += account.Balance;
        }

        Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

        foreach (Account account in list)
        {
            account.Withdraw(10.0);
        }

        foreach (Account account in list)
        {
            Console.WriteLine("Updated balance " + account.Number + " - " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}