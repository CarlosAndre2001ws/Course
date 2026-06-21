using System;
using System.Linq;
using Course.Menu.FileReader;
using Course.helpers;

namespace Course.Menu.Interface;

public class Window
{
    public static void newWindow()
    {
        var reader = new FileReaderSecoes();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Bem Vindo!");
            Console.WriteLine("Escolha a Seção:");

            var sections = reader.GetSections().ToList();
            if (!sections.Any())
            {
                Console.WriteLine("Nenhuma seção encontrada.");
                closeWindow();
            }

            for (int i = 0; i < sections.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sections[i].Name}");
            }

            Console.WriteLine("0. Sair");

            var input = Console.ReadLine()?.Trim();
            if (!int.TryParse(input, out var selected) || selected < 0 || selected > sections.Count)
            {
                Console.WriteLine("Escolha inválida. Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            if (selected == 0)
            {
                closeWindow();
            }

            var section = sections[selected - 1];
            ShowSection(reader, section);
        }
    }

    private static void ShowSection(FileReaderSecoes reader, SectionDescriptor section)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Seção: {section.Name}");
            Console.WriteLine("Escolha o exercício:");

            var exercises = reader.GetExercises(section).ToList();
            if (!exercises.Any())
            {
                Console.WriteLine("Nenhum exercício encontrado nesta seção.");
                Console.WriteLine("0. Voltar");
                var b = Console.ReadLine();
                return;
            }

            for (int i = 0; i < exercises.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {exercises[i].Name}");
            }

            Console.WriteLine("0. Voltar");

            var input = Console.ReadLine()?.Trim();
            if (!int.TryParse(input, out var selected) || selected < 0 || selected > exercises.Count)
            {
                Console.WriteLine("Escolha inválida. Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            if (selected == 0) return;

            var exercise = exercises[selected - 1];

            Console.Clear();
            Console.WriteLine($"Executando: {exercise.Name}\n");

            if (!ExerciseRunner.TryRun(exercise.FullyQualifiedTypeName, out var error))
            {
                Console.WriteLine($"Falha ao executar: {error}");
            }

            Console.WriteLine("\nPressione Enter para continuar...");
            Console.ReadLine();
        }
    }

    public static void closeWindow()
    {
        Console.WriteLine("Obrigado por utilizar o programa!");
        Environment.Exit(0);
    }
}