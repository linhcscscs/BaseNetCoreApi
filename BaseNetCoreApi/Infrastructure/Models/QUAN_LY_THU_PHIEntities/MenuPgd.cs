using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class MenuPgd
{
    public long MenuPgdid { get; set; }

    public long? ParentId { get; set; }

    public string? MenuPgdcode { get; set; }

    public int? LevelItem { get; set; }

    public string MenuPgdname { get; set; } = null!;

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

    public string? MenuPgdnameEg { get; set; }

    public virtual ICollection<GroupUserPgdmenuPgd> GroupUserPgdmenuPgds { get; set; } = new List<GroupUserPgdmenuPgd>();
}
