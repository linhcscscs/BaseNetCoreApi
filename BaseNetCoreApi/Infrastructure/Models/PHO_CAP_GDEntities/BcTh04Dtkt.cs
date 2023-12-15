using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcTh04Dtkt
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? IdToThon { get; set; }

    public int NamSinh { get; set; }

    public int DoTuoi { get; set; }

    public decimal? TongSo { get; set; }

    public decimal? VanDong { get; set; }

    public decimal? NgheNoi { get; set; }

    public decimal? Nhin { get; set; }

    public decimal? Tktt { get; set; }

    public decimal? TriTue { get; set; }

    public decimal? Rlptk { get; set; }

    public decimal? HocTap { get; set; }

    public decimal? Khac { get; set; }

    public decimal? HsktTcGdTs { get; set; }

    public decimal? HsktTcGdTl { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
