using System.Text.Json;

namespace IconPacksGenerator;

internal class FontAwesomeGenerator
{
    private static string iconsPath = Path.Combine(
        Paths.FontAwesomeIconPath,
        "./metadata/icons.json"
    );

    internal static void Run()
    {
        var iconKinds = new Dictionary<string, string>(1000);

        var icons = JsonSerializer.Deserialize<Dictionary<string, FontAwesomeIcon>>(
            new FileStream(iconsPath, FileMode.Open)
        );

        if (icons != null)
        {
            foreach (var icon in icons)
            {
                var path = icon.Value?.Svg?.Solid?.Path;
                if (!string.IsNullOrEmpty(path))
                {
                    iconKinds.Add(Util.GetCamelId(icon.Key), path);
                }
            }
        }

        Util.OutputIconKinds(iconKinds, "FontAwesome");
    }
}
