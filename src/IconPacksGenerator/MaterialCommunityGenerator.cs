namespace IconPacksGenerator;

internal static class MaterialCommunityGenerator
{
    private static string rootPath = Path.Combine(Paths.MaterialCommunityIconPath, "./svg/");

    internal static void Run()
    {
        var iconKinds = new Dictionary<string, string>(5000);

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

        Util.OutputIconKinds(iconKinds, "MaterialCommunity");
    }
}
