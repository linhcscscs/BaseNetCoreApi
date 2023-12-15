using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcXmc03Tknmcdt
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? IdToThon { get; set; }

    public string NhomTuoi { get; set; } = null!;

    public decimal? DsTs { get; set; }

    public decimal? DsNu { get; set; }

    public decimal? DsDt { get; set; }

    public decimal? DsTg { get; set; }

    public decimal? McMuc1Ts { get; set; }

    public decimal? McMuc1Nu { get; set; }

    public decimal? McMuc1Dt { get; set; }

    public decimal? McMuc1Tg { get; set; }

    public decimal? McMuc2Ts { get; set; }

    public decimal? McMuc2Nu { get; set; }

    public decimal? McMuc2Dt { get; set; }

    public decimal? McMuc2Tg { get; set; }

    public decimal? TlMc { get; set; }

    public decimal? TmcTs { get; set; }

    public decimal? TmcNu { get; set; }

    public decimal? TmcDt { get; set; }

    public decimal? TmcTg { get; set; }

    public string? GhiChu { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
