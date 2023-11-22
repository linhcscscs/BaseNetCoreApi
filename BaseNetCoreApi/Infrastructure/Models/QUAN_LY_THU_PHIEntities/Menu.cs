using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class Menu
{
    public long MenuId { get; set; }

    public long? ParentId { get; set; }

    public string? MenuCode { get; set; }

    public int? LevelItem { get; set; }

    public string MenuName { get; set; } = null!;

    public string? Icon { get; set; }

    public string? Link { get; set; }

    public int? TypeHelp { get; set; }

    public string? DesHelp { get; set; }

    public string? LinkYoutube { get; set; }

    public string? Order { get; set; }

    public int IsView { get; set; }

    public int Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateAt { get; set; }

    public string? AuthBy { get; set; }

    public DateTime? AuthAt { get; set; }

    public string? MenuNameEg { get; set; }

    public virtual ICollection<GroupUserMenu> GroupUserMenus { get; set; } = new List<GroupUserMenu>();
}
