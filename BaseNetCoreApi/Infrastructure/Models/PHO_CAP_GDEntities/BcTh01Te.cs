using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcTh01Te
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

    public decimal? T6 { get; set; }

    public decimal? T7 { get; set; }

    public decimal? T8 { get; set; }

    public decimal? T9 { get; set; }

    public decimal? T10 { get; set; }

    public decimal? Tong610 { get; set; }

    public decimal? T11 { get; set; }

    public decimal? T12 { get; set; }

    public decimal? T13 { get; set; }

    public decimal? T14 { get; set; }

    public decimal? Tong1114 { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
