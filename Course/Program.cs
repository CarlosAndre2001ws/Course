using System;
using System.Globalization;
using Course.Secao_3;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");
            Console.WriteLine("------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-------------------------");

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} R$ reais", nome, idade, saldo);
            // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} R$ reais."); */

            // Exercício de Fixação

            /*

            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo o preço é $ {preco2:F2}");
            Console.WriteLine("");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine("");
            Console.WriteLine($"Medida com oito casas decimais: {medida}");
            Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            */


            //string frase = Console.ReadLine();

            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();


            //string[] vect = Console.ReadLine().Split(' ');

            //string a = vect[0];
            //string b = vect[1];
            //string c = vect[2];

            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(a + " " + b + " " + c);

            // int n1 = int.Parse(Console.ReadLine() ?? "");
            // char ch = char.Parse(Console.ReadLine() ?? "");
            // double n2 = double.Parse(Console.ReadLine() ?? "");
            //
            // string[] info = Console.ReadLine().Split(' ');
            //
            // string nome = info[0];
            // char sexo = char.Parse(info[1]);
            // int idade = int.Parse(info[2]);
            // double altura = double.Parse(info[3]);
            //
            //
            // Console.WriteLine("Você digitou:");
            //
            //
            // Console.WriteLine(n1);
            // Console.WriteLine(ch);
            // Console.WriteLine(n2);
            //
            // Console.WriteLine(nome);
            // Console.WriteLine(sexo);
            // Console.WriteLine(idade);
            // Console.WriteLine(altura);
            //

            Ex_Fix_24.Run();

        }
    }
}