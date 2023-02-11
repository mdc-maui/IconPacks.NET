using Svg;

namespace IconPacksGenerator;
internal static class SvgExtensions
{
    internal static string ParseCircle(this SvgElement element)
    {
        if (element is not SvgCircle circle) return string.Empty;
        var cx = circle.CenterX;
        var cy = circle.CenterY;
        var r = circle.Radius;
        var result = $"M{cx - r},{cy}a{r},{r} 0 1,0 {2 * r},0a{r},{r} 0 1,0 {-2 * r},0";
        return result;
    }

    internal static string ParseEllipse(this SvgElement element)
    {
        if (element is not SvgEllipse ellipse) return string.Empty;
        var cx = ellipse.CenterX;
        var cy = ellipse.CenterY;
        var rx = ellipse.RadiusX;
        var ry = ellipse.RadiusY;
        var result = $"M{cx - rx},{cy}a{rx},{ry} 0 1,0 {2 * rx},0a{rx},{ry} 0 1,0 {-2 * rx},0";
        return result;
    }

    internal static string ParsePolygon(this SvgElement element)
    {
        if (element is not SvgPolygon polygon) return string.Empty;
        return $"M{polygon.Points}z";
    }

    internal static string ParsePolyline(this SvgElement element)
    {
        if (element is not SvgPolyline polyline) return string.Empty;
        return $"M{polyline.Points}";
    }

    internal static string ParseLine(this SvgElement element)
    {
        if (element is not SvgLine line) return string.Empty;
        if (line.StartX != line.EndX)
        {
            return $"M{line.StartX},{line.StartY} H {line.EndX}";
        }
        else
        {
            return $"M{line.StartX},{line.StartY} V {line.EndY}";
        }

    }

    internal static string ParseRectangle(this SvgElement element)
    {
        if (element is not SvgRectangle rectangle) return string.Empty;
        var x = rectangle.X;
        var y = rectangle.Y;
        var width = rectangle.Width;
        var height = rectangle.Height;

        return $"M{x},{y}L{x + width},{y} {x + width}, {y + height} {x},{y + height}z";
    }

    internal static string ParsePath(this SvgElement element)
    {
        if (element is not SvgPath path) return string.Empty;
        return path.PathData.ToString();
    }
}
