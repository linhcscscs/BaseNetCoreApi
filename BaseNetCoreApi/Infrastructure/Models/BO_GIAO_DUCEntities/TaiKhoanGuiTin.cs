using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class TaiKhoanGuiTin
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string? MaPhongGd { get; set; }

    public string? MaTruong { get; set; }

    public string MaCapDonVi { get; set; } = null!;

    public string TaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public int TrangThai { get; set; }

    public string? MoTa { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public int IsCapMn { get; set; }

    public int IsCapTh { get; set; }

    public int IsCapThcs { get; set; }

    public int IsCapThpt { get; set; }

    public int IsCapGdtx { get; set; }

    public string IpAccess { get; set; } = null!;

    public DateTime? NgayTao { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? NguoiSua { get; set; }
}
