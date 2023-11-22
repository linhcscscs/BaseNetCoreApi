using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class GroupUserPgdmenuPgd
{
    public decimal GroupUserPgdmenuPgdid { get; set; }

    public long MenuPgdid { get; set; }

    public long GroupUserPgdid { get; set; }

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

    public virtual GroupUserPgd GroupUserPgd { get; set; } = null!;

    public virtual MenuPgd MenuPgd { get; set; } = null!;
}
