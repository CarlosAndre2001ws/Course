using System.Globalization;
using Course.Secoes.Secao_4.entities;

namespace Course.Secoes.Secao_4;

public class PrimeirosExercicios2
{
    public static void Run()
    {
        Console.WriteLine("Dados do primeiro funcionário: ");
        Console.Write("Nome: "); string nome = Console.ReadLine();
        Console.Write("Salário: "); double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Dados do segundo funcionário: ");
        Console.Write("Nome: "); string nomeB = Console.ReadLine();
        Console.Write("Salário: "); double salarioB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Funcionario a, b;
        
        a = new Funcionario(nome, salario);
        b = new Funcionario(nomeB, salarioB);
        
        Console.WriteLine("Salário médio: " + ((a.Salario + b.Salario) / 2).ToString("F2"));
    }
}