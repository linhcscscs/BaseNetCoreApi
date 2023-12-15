using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcMn05Dtkt
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

    public decimal? CtNgheNoi { get; set; }

    public decimal? CtNhin { get; set; }

    public decimal? CtTktt { get; set; }

    public decimal? CtTt { get; set; }

    public decimal? CtRlptk { get; set; }

    public decimal? CtHt { get; set; }

    public decimal? CtKhac { get; set; }

    public decimal? HsktTcGdTs { get; set; }

    public decimal? HsktTcGdTl { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
