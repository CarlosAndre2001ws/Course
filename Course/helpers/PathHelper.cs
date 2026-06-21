namespace Course.helpers;

using System.IO;

public static class PathHelper
{
    public static string FindSecoesRoot()
    {
        var dir = new DirectoryInfo(AppContext.BaseDirectory);

        while (dir != null)
        {
            var secoesFolder = Path.Combine(dir.FullName, "Secoes");
            if (Directory.Exists(secoesFolder))
            {
                return secoesFolder;
            }

            dir = dir.Parent;
        }

        throw new DirectoryNotFoundException("Could not find the Secoes folder.");
    }
    
    public static IEnumerable<DirectoryInfo> FindSectionFolders(string? startDirectory = null)
    {
        startDirectory ??= FindSecoesRoot();

        var dir = new DirectoryInfo(startDirectory);

        while (dir != null)
        {
            var matches = dir.GetDirectories("Secao_*", SearchOption.TopDirectoryOnly);
            if (matches.Any())
                return matches;

            dir = dir.Parent;
        }

        return Enumerable.Empty<DirectoryInfo>();
    }
}