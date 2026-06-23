using System;

namespace Course.Secoes.Secao_4;

public class AreaDoTrianguloSemClasse
{
    public static void Run()
    {
        Console.WriteLine("Entre com as medidads do triângulo x:");
        var x1 =  double.Parse(Console.ReadLine());
        var x2 =  double.Parse(Console.ReadLine());
        var x3 =  double.Parse(Console.ReadLine());

        Console.WriteLine("Entre com as medidas do triângulo y:");
        var y1 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var y3 = double.Parse(Console.ReadLine());
        
        
        var px = (x1 + x2 + x3) / 2;
        var py = (y1 + y2 + y3) / 2;
        
        var areax = Math.Sqrt(px*(px - x1)*(px - x2)*(px - x3));
        var areay = Math.Sqrt(py*(py - y1)*(py - y2)*(py - y3));

        Console.WriteLine("Área de X = {0:F4}", areax);
        Console.WriteLine("Área de Y = {0:F4}", areay);

        Console.WriteLine("Maior área: {0}", areax > areay ? "X" : "Y");
    }
}