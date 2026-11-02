using Course.Secoes.Secao_8.Aula109.Entities;

namespace Course.Secoes.Secao_8.Aula109;

public class Program
{
    public static void Run()
    {
        Account acc = new Account(1001, "Alex", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);
        
        // UPCASTING

        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
        Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
        
        // DOWNCASTING

        BusinessAccount acc4 = (BusinessAccount) acc2;
        acc4.Loan(200);

        // BusinessAccount acc5 = (BusinessAccount) acc3;
        if (acc3 is BusinessAccount)
        {
            BusinessAccount acc5 =  (BusinessAccount)acc3;
            acc5.Loan(200);
            Console.WriteLine("loan!");
        }

        if (acc3 is SavingsAccount)
        {
            SavingsAccount acc5 = (SavingsAccount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");
        }
    }
}