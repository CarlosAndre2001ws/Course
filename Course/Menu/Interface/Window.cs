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

            var directExercises = reader.GetExercises(section).ToList();
            var modules = reader.GetModules(section).ToList();

            if (!directExercises.Any() && !modules.Any())
            {
                Console.WriteLine("Nenhum exercício encontrado nesta seção.");
                Console.WriteLine("0. Voltar");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Escolha o exercício ou módulo:");

            int optionCount = 0;

            for (int i = 0; i < directExercises.Count; i++)
            {
                Console.WriteLine($"{++optionCount}. {directExercises[i].Name}");
            }

            for (int i = 0; i < modules.Count; i++)
            {
                Console.WriteLine($"{++optionCount}. [Módulo] {modules[i].Name}");
            }

            Console.WriteLine("0. Voltar");

            var input = Console.ReadLine()?.Trim();
            if (!int.TryParse(input, out var selected) || selected < 0 || selected > optionCount)
            {
                Console.WriteLine("Escolha inválida. Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            if (selected == 0) return;

            if (selected <= directExercises.Count)
            {
                var exercise = directExercises[selected - 1];
                ExecuteExercise(exercise);
            }
            else
            {
                var moduleIndex = selected - directExercises.Count - 1;
                var module = modules[moduleIndex];
                ShowModule(reader, module);
            }
        }
    }

    private static void ShowModule(FileReaderSecoes reader, ModuleDescriptor module)
    {
        var directExercises = reader.GetExercisesFromModule(module).ToList();
        var composites = reader.GetCompositeExercises(module).ToList();

        if (!directExercises.Any() && !composites.Any())
        {
            Console.Clear();
            Console.WriteLine("Nenhum exercício encontrado neste módulo.");
            Console.WriteLine("0. Voltar");
            Console.ReadLine();
            return;
        }

        var programExercise = directExercises.FirstOrDefault(e => e.Name.Equals("Program", StringComparison.OrdinalIgnoreCase));
        if (programExercise != null)
        {
            ExecuteExercise(programExercise);
            return;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Módulo: {module.Name}");
            Console.WriteLine("Escolha o exercício ou exercicios compostos:");

            int optionCount = 0;

            for (int i = 0; i < directExercises.Count; i++)
            {
                Console.WriteLine($"{++optionCount}. {directExercises[i].Name}");
            }

            for (int i = 0; i < composites.Count; i++)
            {
                Console.WriteLine($"{++optionCount}. [Compostos] {composites[i].Name}");
            }

            Console.WriteLine("0. Voltar");

            var input = Console.ReadLine()?.Trim();
            if (!int.TryParse(input, out var selected) || selected < 0 || selected > optionCount)
            {
                Console.WriteLine("Escolha inválida. Pressione Enter para continuar...");
                Console.ReadLine();
                continue;
            }

            if (selected == 0) return;

            if (selected <= directExercises.Count)
            {
                var exercise = directExercises[selected - 1];
                ExecuteExercise(exercise);
            }
            else
            {
                var compositeIndex = selected - directExercises.Count - 1;
                var composite = composites[compositeIndex];
                ShowCompositeExercises(reader, composite);
            }
        }
    }

    private static void ShowCompositeExercises(FileReaderSecoes reader, CompositeExerciseDescriptor composite)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Exercicios Compostos: {composite.Name}");

            var exercises = reader.GetExercisesFromComposite(composite).ToList();

            if (!exercises.Any())
            {
                Console.WriteLine("Nenhum exercício encontrado.");
                Console.WriteLine("0. Voltar");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Escolha o exercício:");

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
            ExecuteExercise(exercise);
        }
    }

    private static void ExecuteExercise(ExerciseDescriptor exercise)
    {
        Console.Clear();
        Console.WriteLine($"Executando: {exercise.Name}\n");

        if (!ExerciseRunner.TryRun(exercise.FullyQualifiedTypeName, out var error))
        {
            Console.WriteLine($"Falha ao executar: {error}");
        }

        Console.WriteLine("\nPressione Enter para continuar...");
        Console.ReadLine();
    }

    public static void closeWindow()
    {
        Console.WriteLine("Obrigado por utilizar o programa!");
        Environment.Exit(0);
    }
}