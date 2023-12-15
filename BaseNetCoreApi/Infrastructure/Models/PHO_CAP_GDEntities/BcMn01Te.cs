using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcMn01Te
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? IdToThon { get; set; }

    public string Ma { get; set; } = null!;

    public decimal? T0 { get; set; }

    public decimal? T1 { get; set; }

    public decimal? T2 { get; set; }

    public decimal? T3 { get; set; }

    public decimal? T4 { get; set; }

    public decimal? T5 { get; set; }

    public decimal? T6 { get; set; }

    public decimal? Tong { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
