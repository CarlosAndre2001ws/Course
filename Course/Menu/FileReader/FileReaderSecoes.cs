namespace Course.Menu.FileReader;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Course.helpers;

public record SectionDescriptor(string Name, DirectoryInfo Directory);
public record ExerciseDescriptor(string Name, FileInfo File, string FullyQualifiedTypeName);

public class FileReaderSecoes
{
    // Returns the list of section folders found under the Secoes root.
    public IEnumerable<SectionDescriptor> GetSections()
    {
        var root = PathHelper.FindSecoesRoot();
        var dir = new DirectoryInfo(root);
        var secoes = dir.GetDirectories("Secao_*", SearchOption.TopDirectoryOnly);
        var exerciciosMatches = dir.GetDirectories("Exercicios*", SearchOption.TopDirectoryOnly);
        return secoes.Concat(exerciciosMatches).Select(f => new SectionDescriptor(f.Name, f));
    }

    // Returns all .cs files in the given section as exercise descriptors.
    public IEnumerable<ExerciseDescriptor> GetExercises(SectionDescriptor section)
    {
        if (section == null) throw new ArgumentNullException(nameof(section));

        var files = section.Directory.GetFiles("*.cs", SearchOption.TopDirectoryOnly)
            .Where(f => !f.Name.EndsWith(".Designer.cs", StringComparison.OrdinalIgnoreCase));

        foreach (var f in files)
        {
            var className = Path.GetFileNameWithoutExtension(f.Name);
            // Build the expected fully-qualified type name based on project namespace layout
            var fqn = $"Course.Secoes.{section.Name}.{className}";
            yield return new ExerciseDescriptor(className, f, fqn);
        }
    }
}