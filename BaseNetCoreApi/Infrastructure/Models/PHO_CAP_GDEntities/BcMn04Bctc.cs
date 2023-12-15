using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcMn04Bctc
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string Ma { get; set; } = null!;

    public decimal? TongSo { get; set; }

    public decimal? N1 { get; set; }

    public decimal? N2 { get; set; }

    public decimal? N3 { get; set; }

    public decimal? N4 { get; set; }

    public decimal? N5 { get; set; }

    public string? GhiChu { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
