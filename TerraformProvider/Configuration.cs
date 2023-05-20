using MessagePack;
using System.ComponentModel;

namespace TerraformProvider;

[MessagePackObject]
public class Configuration
{
    [Key("file_header")]
    [Description("Header text to prepend to every file.")]
    public string? FileHeader { get; set; }
}
