using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcXmc02Thkqxmc
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? IdToThon { get; set; }

    public int DoTuoi { get; set; }

    public int NamSinh { get; set; }

    public decimal? TongSo { get; set; }

    public decimal? Nu { get; set; }

    public decimal? Dt { get; set; }

    public decimal? DtNu { get; set; }

    public decimal? Mc1TongSo { get; set; }

    public decimal? Mc1Nu { get; set; }

    public decimal? Mc1Dt { get; set; }

    public decimal? Mc1DtNu { get; set; }

    public decimal? Mc2TongSo { get; set; }

    public decimal? Mc2Nu { get; set; }

    public decimal? Mc2Dt { get; set; }

    public decimal? Mc2DtNu { get; set; }

    public decimal? BcTongSo { get; set; }

    public decimal? BcNu { get; set; }

    public decimal? BcDt { get; set; }

    public decimal? BcDtNu { get; set; }

    public decimal? Tlbc { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
