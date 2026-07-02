using System.Globalization;
using Course.Secoes.Exercicios.entities.ExercicioEntities_2;

namespace Course.Secoes.Exercicios;

public class ExercicioFixacao2
{
    public static void Run()
    {
        Console.Write("Nome: "); var nome = Console.ReadLine();
        Console.Write("Salário bruto: "); var salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: "); var imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Funcionario f = new Funcionario(nome, salarioBruto, imposto);
        
        Console.WriteLine("Funcionário: " + f.FuncionarioInfo);

        Console.Write("Digite a porcentagem para aumentar o salário: ");  var porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        f.AumentarSalario(porcentagem);

        Console.WriteLine("Dados atualizados: " + f.FuncionarioInfo);
    }
}