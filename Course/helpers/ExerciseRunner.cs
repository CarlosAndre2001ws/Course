namespace Course.helpers;

using System;
using System.Linq;
using System.Reflection;

public static class ExerciseRunner
{
    // Tries to locate a type by fully-qualified name across loaded assemblies and invoke its
    // public static void Run() method. Returns true on success; on failure returns false and an error message.
    public static bool TryRun(string fullyQualifiedTypeName, out string? error)
    {
        error = null;
        try
        {
            if (string.IsNullOrWhiteSpace(fullyQualifiedTypeName))
            {
                error = "Empty type name.";
                return false;
            }

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            Type? type = null;

            foreach (var asm in assemblies)
            {
                try
                {
                    type = asm.GetType(fullyQualifiedTypeName, false, false);
                    if (type != null) break;
                }
                catch
                {
                    // ignore
                }
            }

            if (type == null)
            {
                // As a fallback try to locate by type name only (last segment) in all assemblies
                var shortName = fullyQualifiedTypeName.Split('.').Last();
                foreach (var asm in assemblies)
                {
                    try
                    {
                        type = asm.GetTypes().FirstOrDefault(t => t.Name.Equals(shortName, StringComparison.OrdinalIgnoreCase));
                        if (type != null) break;
                    }
                    catch
                    {
                        // ignore reflection load issues
                    }
                }
            }

            if (type == null)
            {
                error = $"Type '{fullyQualifiedTypeName}' not found in loaded assemblies.";
                return false;
            }

            var method = type.GetMethod("Run", BindingFlags.Public | BindingFlags.Static);
            if (method == null)
            {
                error = $"No public static Run() method found on type '{type.FullName}'.";
                return false;
            }

            method.Invoke(null, null);
            return true;
        }
        catch (TargetInvocationException tie)
        {
            error = tie.InnerException?.ToString() ?? tie.ToString();
            return false;
        }
        catch (Exception ex)
        {
            error = ex.ToString();
            return false;
        }
    }
}

