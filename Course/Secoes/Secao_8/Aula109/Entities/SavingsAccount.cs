namespace Course.Secoes.Secao_8.Aula109.Entities;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount(int number, string holder, double balance, double interestRate) 
        :  base(number, holder, balance)
    {
        InterestRate = interestRate;
    }
    
    public override void Withdraw(double amount)
    {
        Balance -= amount + 7.0;
    }

    public void UpdateBalance()
    {
        Balance += Balance * InterestRate;
    }
}