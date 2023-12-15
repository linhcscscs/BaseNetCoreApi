using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class GroupUser
{
    public long GroupUserId { get; set; }

    public string GroupUserCode { get; set; } = null!;

    public string GroupUserName { get; set; } = null!;

    public string? TinhMa { get; set; }

    public string? XaMa { get; set; }

    public int Isroot { get; set; }

    public int Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateAt { get; set; }

    public string? AuthBy { get; set; }

    public DateTime? AuthAt { get; set; }

    public virtual ICollection<GroupUserMenu> GroupUserMenus { get; set; } = new List<GroupUserMenu>();
}
