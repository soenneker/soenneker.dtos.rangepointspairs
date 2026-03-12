using Newtonsoft.Json;
using Soenneker.Attributes.PublicOpenApiObject;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Soenneker.Dtos.RangePointsPairs;

/// <summary>
/// A small, strongly typed data contract for associating a numeric range with a corresponding point value.
/// </summary>
[PublicOpenApiObject]
public sealed record RangePointsPair
{
    [Required]
    [JsonPropertyName("range")]
    [JsonProperty(PropertyName = "range")]
    public MinMax.MinMax Range { get; set; } = null!;

    [Required]
    [JsonPropertyName("points")]
    [JsonProperty("points")]
    public int Points { get; set; }
}