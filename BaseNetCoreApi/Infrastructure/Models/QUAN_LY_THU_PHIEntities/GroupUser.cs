using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class GroupUser
{
    public long GroupUserId { get; set; }

    public string GroupUserCode { get; set; } = null!;

    public string GroupUserName { get; set; } = null!;

    public string? SoGdma { get; set; }

    public string? TruongMa { get; set; }

    public int Isroot { get; set; }

    public int Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateAt { get; set; }

    public string? AuthBy { get; set; }

    public DateTime? AuthAt { get; set; }

    public int? IsnotCheckPc { get; set; }

    public virtual ICollection<GroupUserMenu> GroupUserMenus { get; set; } = new List<GroupUserMenu>();
}
