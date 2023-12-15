using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThcs02Tcpcgdthc
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal IdToThon { get; set; }

    public decimal? HdTre6tTs { get; set; }

    public decimal? HdTre6tL1 { get; set; }

    public decimal? HdTre6tTl { get; set; }

    public decimal? HdHstnTs { get; set; }

    public decimal? HdHstnVhl6Pt { get; set; }

    public decimal? HdHstnVhl6Gdtx { get; set; }

    public decimal? HdHstnVhl6Cong { get; set; }

    public decimal? HdHstnVhl6Tl { get; set; }

    public decimal? HqT1114Ts { get; set; }

    public decimal? HqT1114Htctth { get; set; }

    public decimal? HqT1114Tl { get; set; }

    public decimal? HqHsl9Ts { get; set; }

    public decimal? HqHsl9Tnthcs { get; set; }

    public decimal? HqHsl9Thcsgdtx { get; set; }

    public decimal? HqHsl9Tl { get; set; }

    public decimal? HqDt1518Ts { get; set; }

    public decimal? HqDt1518TnPt { get; set; }

    public decimal? HqDt1518TnGdtx { get; set; }

    public decimal? HqDt1518TnCong { get; set; }

    public decimal? HqDt1518TnTl { get; set; }

    public decimal? DgPcgdThcs { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
