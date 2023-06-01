namespace IconPacksGenerator;

internal static class FeatherGenerator
{
    private static string rootPath = Path.Combine(Paths.FeatherIconPath, "./icons/");

    internal static void Run()
    {
        var iconKinds = new Dictionary<string, string>();

        foreach (var path in Directory.EnumerateFiles(rootPath))
        {
            if (path.EndsWith(".svg"))
            {
                var id = Path.GetFileNameWithoutExtension(path);
                var data = Util.GetSvgData(path);
                if (!string.IsNullOrEmpty(data))
                {
                    iconKinds.Add(Util.GetCamelId(id), data);
                }
            }
        }

        Util.OutputIconKindFile(iconKinds, "Feather");
    }
}
