namespace Course.Secoes.Exercicios_Fixacao.Entities.Params;

public class Calculator
{
    public static int Sum(params int[] values)
    {
        int sum = 0;
        for(int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum;
    }
}