namespace IconPacksGenerator;
internal static class Paths
{

    internal static string RootPath = Path.GetFullPath(
        "../../../../",
        AppDomain.CurrentDomain.BaseDirectory
    );

    internal static string FeatherIconPath = Path.Combine(RootPath, "3rdparty/Feather/");

    internal static string FontAwesomeIconPath = Path.Combine(RootPath, "3rdparty/FontAwesome/");

    internal static string IonicIconPath = Path.Combine(RootPath, "3rdparty/Ionic/");

    internal static string MaterialIconPath = Path.Combine(RootPath, "3rdparty/Material/");

    internal static string MaterialCommunityIconPath = Path.Combine(RootPath, "3rdparty/MaterialCommunity/");

    internal static string SimpleIconPath = Path.Combine(RootPath, "3rdparty/Simple/");

    internal static string TablerIconPath = Path.Combine(RootPath, "3rdparty/Tabler/");


}
