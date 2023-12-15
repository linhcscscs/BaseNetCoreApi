using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class PhieuDieuTra
{
    public long Id { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string SoPhieu { get; set; } = null!;

    public string HoTenChuHo { get; set; } = null!;

    public string HoChuHo { get; set; } = null!;

    public string TenChuHo { get; set; } = null!;

    public string MaToThon { get; set; } = null!;

    public decimal IdToThon { get; set; }

    public string? DiaChi { get; set; }

    public string? MaDienCuTru { get; set; }

    public string? MaTinhTrangCuTru { get; set; }

    public string? SoDienThoai { get; set; }

    public DateTime? NgayDieuTra { get; set; }

    public string? GhiChu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual DmToThon IdToThonNavigation { get; set; } = null!;
}
