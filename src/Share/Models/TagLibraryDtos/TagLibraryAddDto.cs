using System.ComponentModel.DataAnnotations;

namespace Share.Models.TagLibraryDtos;

/// <summary>
/// 标签库
/// </summary>

public class TagLibraryAddDto
{
    [MaxLength(40)]
    public string Type { get; set; } = "default";
    [MaxLength(40)]
    public string Name { get; set; } = string.Empty;
    [MaxLength(20)]
    public string? Color { get; set; }
    [MaxLength(40)]
    public string? Style { get; set; }

}
