using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class NgayHocThang
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public int T1 { get; set; }

    public int T2 { get; set; }

    public int T3 { get; set; }

    public int T4 { get; set; }

    public int T5 { get; set; }

    public int T6 { get; set; }

    public int T7 { get; set; }

    public int T8 { get; set; }

    public int T9 { get; set; }

    public int T10 { get; set; }

    public int T11 { get; set; }

    public int T12 { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
