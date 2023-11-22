using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class MenuSgd
{
    public long MenuSgdid { get; set; }

    public long? ParentId { get; set; }

    public string? MenuSgdcode { get; set; }

    public int? LevelItem { get; set; }

    public string MenuSgdname { get; set; } = null!;

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

    public string? MenuSgdnameEg { get; set; }

    public virtual ICollection<GroupUserSgdmenuSgd> GroupUserSgdmenuSgds { get; set; } = new List<GroupUserSgdmenuSgd>();
}
