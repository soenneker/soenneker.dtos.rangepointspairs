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
    /// <summary>
    /// Gets the numeric bounds associated with the point value.
    /// </summary>
    [Required]
    [JsonPropertyName("range")]
    public required MinMax.MinMax Range { get; set; }

    /// <summary>
    /// Gets or sets the points assigned to the range.
    /// </summary>
    [Required]
    [JsonPropertyName("points")]
    public int Points { get; set; }
}
