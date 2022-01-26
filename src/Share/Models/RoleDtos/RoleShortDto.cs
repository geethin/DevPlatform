namespace Share.Models.RoleDtos;
/// <summary>
/// 角色表
/// </summary>
public class RoleShortDto
{
    /// <summary>
    /// 角色名称
    /// </summary>
    [MaxLength(50)]
    public string Name { get; set; }
    /// <summary>
    /// 图标
    /// </summary>
    [MaxLength(30)]
    public string? Icon { get; set; }
    public Guid Id { get; set; }
    /// <summary>
    /// 状态
    /// </summary>
    public Status Status { get; set; }
    public DateTimeOffset CreatedTime { get; set; }
    public DateTimeOffset UpdatedTime { get; set; }
    
}
