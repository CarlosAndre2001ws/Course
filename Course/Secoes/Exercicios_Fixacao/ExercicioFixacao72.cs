using Course.Secoes.Exercicios_Fixacao.Rent;

namespace Course.Secoes.Exercicios_Fixacao;

public class ExercicioFixacao72
{
    public static void Run()
    {
        Console.Write("How many rooms will be rented? "); int rooms =  int.Parse(Console.ReadLine());
        
        Aluno[] apartamentos = new Aluno[9];

        for (int i = 0; i < rooms; i++)
        {
            Console.WriteLine($"Rent #{i + 1}:");
            Console.Write("Name: "); string name = Console.ReadLine();
            Console.Write("Email: "); string email = Console.ReadLine();
            Console.Write("Room:  "); int room = int.Parse(Console.ReadLine());
            apartamentos[room - 1] = new Aluno(name, email);
            Console.WriteLine();
        }

        Console.WriteLine("Busy rooms:");
        for (int i = 0; i < apartamentos.Length; i++)
        {
            if (apartamentos[i] != null)
            {
                Console.WriteLine($"{i + 1}. {apartamentos[i].Nome}, {apartamentos[i].Email}");
            }
        }
    }
}