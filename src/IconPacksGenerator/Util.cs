using Svg;
using System.Text;
using System.Xml.Linq;

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
                var pe = xd.Descendants("path");
                var dataName = XName.Get("pathData", "http://schemas.android.com/apk/res/android");
                var data = pe.Select(x => x.Attribute(dataName)).First()?.Value;
                return data;
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
        }
        result.Reverse();
        return result.Count > 0 ? string.Join(' ', result) : default;
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
