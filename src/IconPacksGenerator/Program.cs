using System.Text;
using CliWrap;
using CliWrap.Buffered;
using IconPacksGenerator;

internal class Program
{
    private static string? apiKey;

    private static async Task Main(string[] args)
    {
        if (args.Length > 0 && !string.IsNullOrEmpty(args[0]))
            apiKey = args[0];

        Console.WriteLine("Icons initializing...");
        await InitIcons();

        Console.WriteLine();
        Console.WriteLine("Icons updating...");

        await UpdateIcons();

        Console.WriteLine();
        Console.WriteLine("Generator running...");

        RunIconsGenerator();

        Console.WriteLine();
        Console.WriteLine("Packs building...");

        await BuildIconPacks(apiKey);

        Console.WriteLine();
        Console.WriteLine("Done!");
    }

    private static async Task InitIcons()
    {
        await InitIcons(
            Paths.FeatherIconPath,
            "https://github.com/feathericons/feather.git",
            "main",
            "icons/"
        );
        await InitIcons(
            Paths.FontAwesomeIconPath,
            "https://github.com/FortAwesome/Font-Awesome.git",
            "6.x",
            "metadata/icons.json"
        );
        await InitIcons(
            Paths.IonicIconPath,
            "https://github.com/ionic-team/ionicons.git",
            "main",
            "src/svg/"
        );
        await InitIcons(
            Paths.MaterialIconPath,
            "https://github.com/google/material-design-icons.git",
            "master",
            "symbols/android/*/materialsymbolssharp/*_24px.xml"
        );
        await InitIcons(
            Paths.MaterialCommunityIconPath,
            "https://github.com/Templarian/MaterialDesign.git",
            "master",
            "svg/"
        );
        await InitIcons(
            Paths.TablerIconPath,
            "https://github.com/tabler/tabler-icons.git",
            "dev",
            "icons/"
        );
    }

    private static async Task InitIcons(
        string workPath,
        string remote,
        string branch,
        string sparseCheckout
    )
    {
        if (!Directory.Exists(workPath))
        {
            Directory.CreateDirectory(workPath);
        }
        if (!Directory.Exists(Path.Combine(workPath, ".git")))
        {
            await Cli.Wrap("git")
                .WithWorkingDirectory(workPath)
                .WithArguments("init")
                .ExecuteBufferedAsync();
            await Cli.Wrap("git")
                .WithWorkingDirectory(workPath)
                .WithArguments($"remote add remote {remote}")
                .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
                .ExecuteBufferedAsync();
            await Cli.Wrap("git")
                .WithWorkingDirectory(workPath)
                .WithArguments("config core.sparsecheckout true")
                .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
                .ExecuteBufferedAsync();
            File.WriteAllText(Path.Combine(workPath, ".git/info/sparse-checkout"), sparseCheckout);
            await Cli.Wrap("git")
                .WithWorkingDirectory(workPath)
                .WithArguments($"pull remote {branch}:master")
                .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
                .ExecuteBufferedAsync();
        }
    }

    private static async Task UpdateIcons()
    {
        await UpdateIcons(Paths.FeatherIconPath, "main", "icons/");
        await UpdateIcons(Paths.FontAwesomeIconPath, "6.x", "metadata/icons.json");
        await UpdateIcons(Paths.IonicIconPath, "main", "src/svg/");
        await UpdateIcons(
            Paths.MaterialIconPath,
            "master",
            "symbols/android/*/materialsymbolssharp/*_24px.xml"
        );
        await UpdateIcons(Paths.MaterialCommunityIconPath, "master", "svg/");
        await UpdateIcons(Paths.TablerIconPath, "dev", "icons/");
    }

    private static async Task UpdateIcons(string workPath, string branch, string sparseCheckout)
    {
        if (Directory.Exists(Path.Combine(workPath, ".git")))
        {
            await Cli.Wrap("git")
                .WithWorkingDirectory(workPath)
                .WithArguments("config core.sparsecheckout true")
                .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
                .ExecuteBufferedAsync();
            File.WriteAllText(Path.Combine(workPath, ".git/info/sparse-checkout"), sparseCheckout);
            await Cli.Wrap("git")
                .WithWorkingDirectory(workPath)
                .WithArguments($"pull remote {branch}:master")
                .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
                .ExecuteBufferedAsync();
        }
    }

    private static void RunIconsGenerator()
    {
        FeatherGenerator.Run();
        FontAwesomeGenerator.Run();
        IonicGenerator.Run();
        MaterialGenerator.Run();
        MaterialCommunityGenerator.Run();
        TablerGenerator.Run();
    }

    private static async Task BuildIconPacks(string? apiKey)
    {
        var oldNupkgs = Directory.EnumerateFiles(
            Paths.RootPath,
            "*.nupkg",
            SearchOption.AllDirectories
        );
        foreach (var nupkg in oldNupkgs)
        {
            File.Delete(nupkg);
        }

        await Cli.Wrap("dotnet")
            .WithWorkingDirectory(Paths.RootPath)
            .WithArguments("pack ./IconPacks.Feather -c release")
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
            .ExecuteBufferedAsync();
        await Cli.Wrap("dotnet")
            .WithWorkingDirectory(Paths.RootPath)
            .WithArguments("pack ./IconPacks.FontAwesome -c release")
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
            .ExecuteBufferedAsync();
        await Cli.Wrap("dotnet")
            .WithWorkingDirectory(Paths.RootPath)
            .WithArguments("pack ./IconPacks.Ionic -c release")
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
            .ExecuteBufferedAsync();
        await Cli.Wrap("dotnet")
            .WithWorkingDirectory(Paths.RootPath)
            .WithArguments("pack ./IconPacks.Material -c release")
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
            .ExecuteBufferedAsync();
        await Cli.Wrap("dotnet")
            .WithWorkingDirectory(Paths.RootPath)
            .WithArguments("pack ./IconPacks.MaterialCommunity -c release")
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
            .ExecuteBufferedAsync();
        await Cli.Wrap("dotnet")
            .WithWorkingDirectory(Paths.RootPath)
            .WithArguments("pack ./IconPacks.Tabler -c release")
            .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
            .ExecuteBufferedAsync();

        if (string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Please input you nuget api-key...");
            apiKey = Console.ReadLine();
        }

        if (string.IsNullOrEmpty(apiKey))
        {
            Console.WriteLine("Error: Nuget api-key is empty!");
            return;
        }

        var newNupkgs = Directory.EnumerateFiles(
            Paths.RootPath,
            "*.nupkg",
            SearchOption.AllDirectories
        );

        foreach (var nupkg in newNupkgs)
        {
            await Cli.Wrap("dotnet")
                .WithStandardOutputPipe(PipeTarget.ToDelegate(Console.WriteLine, Encoding.UTF8))
                .WithArguments(
                    $"nuget push {nupkg} --api-key {apiKey} --source https://api.nuget.org/v3/index.json"
                )
                .ExecuteBufferedAsync();
        }
    }
}
