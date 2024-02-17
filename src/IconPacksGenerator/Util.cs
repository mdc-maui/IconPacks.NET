using System.Text;
using System.Xml.Linq;
using Microsoft.Maui.Graphics;
using Svg;

namespace IconPacksGenerator;

internal static class Util
{
    internal static string GetCamelId(this string id)
    {
        var result = new List<string>();
        var list = id.Replace('-', '_').Split('_');
        if (int.TryParse(list[0][0..1], out var v))
        {
            list[0] = $"_{list[0]}";
        }
        foreach (var s in list)
        {
            if (s.Length > 1)
                result.Add($"{s[0..1].ToUpper()}{s[1..]}");
            else
                result.Add(s.ToUpper());
        }
        return string.Join(string.Empty, result);
    }

    internal static string? GetXmlData(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                var xd = XDocument.Load(path);

                var vector = xd.Descendants("vector");

                var viewportWidthName = XName.Get(
                    "viewportWidth",
                    "http://schemas.android.com/apk/res/android"
                );
                var viewportWidth = vector
                    .Select(x => x.Attribute(viewportWidthName))
                    .First()
                    ?.Value;

                var viewportHeightName = XName.Get(
                    "viewportHeight",
                    "http://schemas.android.com/apk/res/android"
                );
                var viewportHeight = vector
                    .Select(x => x.Attribute(viewportWidthName))
                    .First()
                    ?.Value;

                var pe = xd.Descendants("path");
                var dataName = XName.Get("pathData", "http://schemas.android.com/apk/res/android");
                var data = pe.Select(x => x.Attribute(dataName)).First()?.Value;

                if (!string.IsNullOrEmpty(data))
                {
                    if (
                        int.TryParse(viewportWidth, out var width)
                        && int.TryParse(viewportHeight, out var height)
                    )
                        return GetScaledPathData(
                            data,
                            new SvgViewBox(width, height, width, height)
                        );
                    else
                        return GetScaledPathData(data, new SvgViewBox(24f, 24f, 24f, 24f));
                }
            }
            return default;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"{path}: {ex.Message}");
            return default;
        }
    }

    internal static string? GetSvgData(string path)
    {
        var result = new List<string>();
        if (File.Exists(path))
        {
            var svgDoc = SvgDocument.Open(path);
            foreach (var element in svgDoc.Children)
            {
                if (element is SvgCircle)
                    result.Add(element.ParseCircle());
                else if (element is SvgEllipse)
                    result.Add(element.ParseEllipse());
                else if (element is SvgPolygon)
                    result.Add(element.ParsePolygon());
                else if (element is SvgPolyline)
                    result.Add(element.ParsePolyline());
                else if (element is SvgLine)
                    result.Add(element.ParseLine());
                else if (element is SvgRectangle)
                    result.Add(element.ParseRectangle());
                else if (element is SvgPath)
                    result.Add(element.ParsePath());
            }
            result.Reverse();
            return GetScaledPathData(
                result.Count > 0 ? string.Join(' ', result) : default,
                svgDoc.ViewBox
            );
        }
        return default;
    }

    internal static string? GetScaledPathData(string? pathData, SvgViewBox viewBox)
    {
        if (string.IsNullOrEmpty(pathData))
            return default;

        var scaleX = 24f / viewBox.Width;
        var scaleY = 24f / viewBox.Height;

        var path = PathBuilder.Build(pathData);
        var scaledPath = path.AsScaledPath(scaleX, scaleY);
        return scaledPath.ToDefinitionString();
    }

    internal static void OutputIconKindFile(Dictionary<string, string> iconKinds, string type)
    {
        var sb = new StringBuilder();
        sb.AppendLine("using System.Collections.Generic;");
        sb.AppendLine("namespace IconPacks.IconKind");
        sb.AppendLine("{");
        sb.AppendLine($"\tpublic static class {type}");
        sb.AppendLine("\t{");

        if (iconKinds.Count > 0)
        {
            foreach (var kind in iconKinds)
            {
                if (string.Equals(kind.Key, type))
                    sb.AppendLine($"\t\tpublic static string _{kind.Key} = \"{kind.Value}\";");
                else
                    sb.AppendLine($"\t\tpublic static string {kind.Key} = \"{kind.Value}\";");
            }
            sb.AppendLine("\t}\r\n}");

            if (!Directory.Exists(Path.Combine(Paths.RootPath, $"./IconPacks.{type}")))
            {
                Directory.CreateDirectory(Path.Combine(Paths.RootPath, $"./IconPacks.{type}"));
            }

            File.WriteAllText(
                Path.Combine(Paths.RootPath, $"./IconPacks.{type}/{type}.cs"),
                sb.ToString()
            );
        }
    }
}
