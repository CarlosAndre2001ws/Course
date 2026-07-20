namespace Course.Menu.FileReader;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Course.helpers;

public record SectionDescriptor(string Name, DirectoryInfo Directory);
public record ExerciseDescriptor(string Name, FileInfo File, string FullyQualifiedTypeName);
public record ModuleDescriptor(string Name, DirectoryInfo Directory, string ParentSectionName);
public record CompositeExerciseDescriptor(string Name, DirectoryInfo Directory, string ParentModuleName, string ParentSectionName);

public class FileReaderSecoes
{
    public IEnumerable<SectionDescriptor> GetSections()
    {
        var root = PathHelper.FindSecoesRoot();
        var dir = new DirectoryInfo(root);
        var secoes = dir.GetDirectories("Secao_*", SearchOption.TopDirectoryOnly);
        var exerciciosMatches = dir.GetDirectories("Exercicios*", SearchOption.TopDirectoryOnly);
        return secoes.Concat(exerciciosMatches).Select(f => new SectionDescriptor(f.Name, f));
    }

    public IEnumerable<ExerciseDescriptor> GetExercises(SectionDescriptor section)
    {
        if (section == null) throw new ArgumentNullException(nameof(section));

        var files = section.Directory.GetFiles("*.cs", SearchOption.TopDirectoryOnly)
            .Where(f => !f.Name.EndsWith(".Designer.cs", StringComparison.OrdinalIgnoreCase));

        foreach (var f in files)
        {
            var className = Path.GetFileNameWithoutExtension(f.Name);
            var fqn = $"Course.Secoes.{section.Name}.{className}";
            yield return new ExerciseDescriptor(className, f, fqn);
        }
    }

    public IEnumerable<ModuleDescriptor> GetModules(SectionDescriptor section)
    {
        if (section == null) throw new ArgumentNullException(nameof(section));

        var subfolders = section.Directory.GetDirectories();
        foreach (var folder in subfolders)
        {
            var hasFiles = folder.GetFiles("*.cs", SearchOption.TopDirectoryOnly).Any();
            if (hasFiles)
            {
                yield return new ModuleDescriptor(folder.Name, folder, section.Name);
            }
        }
    }

    public IEnumerable<ExerciseDescriptor> GetExercisesFromModule(ModuleDescriptor module)
    {
        if (module == null) throw new ArgumentNullException(nameof(module));

        var files = module.Directory.GetFiles("*.cs", SearchOption.TopDirectoryOnly)
            .Where(f => !f.Name.EndsWith(".Designer.cs", StringComparison.OrdinalIgnoreCase));

        foreach (var f in files)
        {
            var className = Path.GetFileNameWithoutExtension(f.Name);
            var fqn = $"Course.Secoes.{module.ParentSectionName}.{module.Name}.{className}";
            yield return new ExerciseDescriptor(className, f, fqn);
        }
    }

    public IEnumerable<CompositeExerciseDescriptor> GetCompositeExercises(ModuleDescriptor module)
    {
        if (module == null) throw new ArgumentNullException(nameof(module));

        var subfolders = module.Directory.GetDirectories();
        foreach (var folder in subfolders)
        {
            var hasFiles = folder.GetFiles("*.cs", SearchOption.TopDirectoryOnly).Any();
            if (hasFiles)
            {
                yield return new CompositeExerciseDescriptor(folder.Name, folder, module.Name, module.ParentSectionName);
            }
        }
    }

    public IEnumerable<ExerciseDescriptor> GetExercisesFromComposite(CompositeExerciseDescriptor composite)
    {
        if (composite == null) throw new ArgumentNullException(nameof(composite));

        var files = composite.Directory.GetFiles("*.cs", SearchOption.TopDirectoryOnly)
            .Where(f => !f.Name.EndsWith(".Designer.cs", StringComparison.OrdinalIgnoreCase));

        foreach (var f in files)
        {
            var className = Path.GetFileNameWithoutExtension(f.Name);
            var fqn = $"Course.Secoes.{composite.ParentSectionName}.{composite.ParentModuleName}.{composite.Name}.{className}";
            yield return new ExerciseDescriptor(className, f, fqn);
        }
    }
}