using MessagePack;
using System.ComponentModel;
using TerraformPluginDotNet.Resources;
using TerraformPluginDotNet.Serialization;

namespace TerraformProvider;

[SchemaVersion(1)]
[MessagePackObject]
public class SampleFileResource
{
    [Key("id")]
    [Computed]
    [Description("Unique ID for this resource.")]
    [MessagePackFormatter(typeof(ComputedStringValueFormatter))]
    public string? Id { get; set; }

    [Key("path")]
    [Description("Path to the file.")]
    [Required]
    public string Path { get; set; } = null!;

    [Key("content")]
    [Description("Contents of the file.")]
    [Required]
    public string Content { get; set; } = null!;
}
