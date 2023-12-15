using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcMn03Tcphcsvc
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public decimal? DiemTruong { get; set; }

    public decimal? TongSoPhongHoc { get; set; }

    public decimal? Lop5tTs { get; set; }

    public decimal? Lop5tLg { get; set; }

    public decimal? Lop5t2bngay { get; set; }

    public decimal? LopDuoi5t { get; set; }

    public decimal? Phong5tTs { get; set; }

    public decimal? Phong5tTl { get; set; }

    public decimal? Phong5tKcTs { get; set; }

    public decimal? Phong5tKcShc { get; set; }

    public decimal? Phong5tBkcTs { get; set; }

    public decimal? Phong5tBkcShc { get; set; }

    public decimal? Phong5tTtTs { get; set; }

    public decimal? Phong5tTtShc { get; set; }

    public decimal? Phong5tDutb { get; set; }

    public decimal? PhongVs { get; set; }

    public decimal? CtNuocSach { get; set; }

    public decimal? BepAn { get; set; }

    public decimal? SanChoi { get; set; }

    public decimal? SanChoiDc { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
