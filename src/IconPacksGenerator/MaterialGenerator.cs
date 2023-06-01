namespace IconPacksGenerator;

internal static class MaterialGenerator
{
    private static string rootPath = Path.Combine(Paths.MaterialIconPath, "./symbols/android/");

    internal static void Run()
    {
        var iconKinds = new Dictionary<string, string>();

        foreach (var category in Directory.EnumerateDirectories(rootPath))
        {
            var id = Path.GetFileNameWithoutExtension(category);
            var path = Path.Combine(category, "materialsymbolssharp", $"{id}_24px.xml");
            var data = Util.GetXmlData(path);
            if (!string.IsNullOrEmpty(data))
            {
                iconKinds.Add(Util.GetCamelId(id), data);
            }
        }

        Util.OutputIconKindFile(iconKinds, "Material");
    }
}
