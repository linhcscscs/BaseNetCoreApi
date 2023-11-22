using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class GroupUserSgdmenuSgd
{
    public decimal GroupUserSgdmenuSgdid { get; set; }

    public long MenuSgdid { get; set; }

    public long GroupUserSgdid { get; set; }

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

    public virtual GroupUserSgd GroupUserSgd { get; set; } = null!;

    public virtual MenuSgd MenuSgd { get; set; } = null!;
}
