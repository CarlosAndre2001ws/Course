using System.Globalization;

namespace Course.Secoes.Exercicios_Fixacao.Entities;

public class Conta
{
    private const double Taxa = 5.00;
    public string Nome { get; set; } = null!;
    public int NumeroConta { get; private set; }
    public double Saldo { get; private set; }

    public Conta()
    {
        CadastrarConta();
    }

    private void CadastrarConta()
    {
        Console.Write("Entre o número da conta: "); NumeroConta =  int.Parse(Console.ReadLine()!);
        Console.Write("Entre o titular da conta: ");
        Nome = Console.ReadLine()!;


        while (true)
        {
            Console.Write("Haverá depósito inicial (s/n)? "); var option = char.Parse(Console.ReadLine()!);
            
            if (option == 's')
            {
                Console.Write("Entre o valor de depósito inicial: "); Saldo = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                break;
            }

            if (option == 'n')
            {
                break;
            }

            Console.WriteLine("Valor inválido, por favor tente novamente.");
        }
        
        DadosDaConta();
    }
    
    public void Depositar()
    {
        Console.WriteLine();
        Console.Write("Entre um valor para depósito: "); Saldo += double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
        
        DadosAtualizados();
    }

    public void Sacar()
    {
        Console.WriteLine();
        Console.Write("Entre um valor para saque: "); Saldo -= double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture) + Taxa;
        
        DadosAtualizados();
    }

    private void DadosDaConta()
    {
        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine($"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
    }

    private void DadosAtualizados()
    {
        Console.WriteLine("Dados da conta atualizados: ");
        Console.WriteLine($"Conta {NumeroConta}, Titular: {Nome}, Saldo: {Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}