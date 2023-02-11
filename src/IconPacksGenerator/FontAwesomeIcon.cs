
using System.Text.Json.Serialization;

public class FontAwesomeIcon
{
    [JsonPropertyName("changes")]
    public string[]? Changes { get; set; }

    [JsonPropertyName("ligatures")]
    public object[]? Ligatures { get; set; }

    [JsonPropertyName("search")]
    public Search? Search { get; set; }

    [JsonPropertyName("styles")]
    public string[]? Styles { get; set; }

    [JsonPropertyName("unicode")]
    public string? Unicode { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    [JsonPropertyName("voted")]
    public bool Voted { get; set; }

    [JsonPropertyName("svg")]
    public SvgInfo? Svg { get; set; }

    [JsonPropertyName("free")]
    public string[]? Free { get; set; }
}

public class Search
{

    [JsonPropertyName("terms")]
    public object[]? Terms { get; set; }
}

public class SvgInfo
{

    [JsonPropertyName("solid")]
    public Solid? Solid { get; set; }
}

public class Solid
{

    [JsonPropertyName("last_modified")]
    public int? LastModified { get; set; }

    [JsonPropertyName("raw")]
    public string? Raw { get; set; }

    [JsonPropertyName("viewBox")]
    public int[]? ViewBox { get; set; }

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}
