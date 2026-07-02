namespace Course.Secoes.Exercicios.entities.ExercicioEntities_2;

public class Funcionario (string nome, double salarioBruto, double imposto)
{
    public string Nome { get; } = nome;
    public double SalarioBruto { get; set; } = salarioBruto;
    public double Imposto { get; set; } = imposto;
    
    public double SalarioLiquido => SalarioBruto - Imposto;
    
    public void AumentarSalario(double porcentagem) => SalarioBruto += SalarioBruto * (porcentagem / 100.00);

    public string FuncionarioInfo => $"{Nome}, $ {SalarioLiquido:F2}";
}