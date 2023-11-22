using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class GroupUserMenu
{
    public decimal GroupUserMenuId { get; set; }

    public long MenuId { get; set; }

    public long GroupUserId { get; set; }

    public int? IsView { get; set; }

    public int IsAdd { get; set; }

    public int IsEdit { get; set; }

    public int IsDelete { get; set; }

    public int IsUpload { get; set; }

    public int IsAuth { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateAt { get; set; }

    public string? AuthBy { get; set; }

    public DateTime? AuthAt { get; set; }

    public virtual GroupUser GroupUser { get; set; } = null!;

    public virtual Menu Menu { get; set; } = null!;
}
