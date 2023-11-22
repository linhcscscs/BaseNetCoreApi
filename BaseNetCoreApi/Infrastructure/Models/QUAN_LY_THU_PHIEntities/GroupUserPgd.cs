using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class GroupUserPgd
{
    public long GroupUserPgdid { get; set; }

    public string GroupUserPgdcode { get; set; } = null!;

    public string GroupUserPgdname { get; set; } = null!;

    public string? SoGdma { get; set; }

    public string? PhongGdma { get; set; }

    public int Isroot { get; set; }

    public int Status { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateAt { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateAt { get; set; }

    public string? AuthBy { get; set; }

    public DateTime? AuthAt { get; set; }

    public virtual ICollection<GroupUserPgdmenuPgd> GroupUserPgdmenuPgds { get; set; } = new List<GroupUserPgdmenuPgd>();
}
