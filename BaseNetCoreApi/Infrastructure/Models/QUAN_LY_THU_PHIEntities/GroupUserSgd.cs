using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class GroupUserSgd
{
    public long GroupUserSgdid { get; set; }

    public string GroupUserSgdcode { get; set; } = null!;

    public string GroupUserSgdname { get; set; } = null!;

    public string? SoGdma { get; set; }

    public int Isroot { get; set; }

    public int Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateAt { get; set; }

    public string? AuthBy { get; set; }

    public DateTime? AuthAt { get; set; }

    public virtual ICollection<GroupUserSgdmenuSgd> GroupUserSgdmenuSgds { get; set; } = new List<GroupUserSgdmenuSgd>();
}
