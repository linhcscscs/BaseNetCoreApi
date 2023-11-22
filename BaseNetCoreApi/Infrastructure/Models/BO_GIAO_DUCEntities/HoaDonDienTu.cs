using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class HoaDonDienTu
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public long? IdDotThu { get; set; }

    public string MaKhoi { get; set; } = null!;

    public string? MaNhomTuoiMn { get; set; }

    public decimal? IdLop { get; set; }

    public string? MaLop { get; set; }

    public decimal? IdHocSinh { get; set; }

    public string? MaHocSinh { get; set; }

    public string? MaDonVi { get; set; }

    public long? IdPhieuThu { get; set; }

    public string? IdHoaDon { get; set; }

    public string? MaLoaiHoaDon { get; set; }

    public string? MauSo { get; set; }

    public string? KyHieu { get; set; }

    public string? SoHoaDon { get; set; }

    public string? SoBienLai { get; set; }

    public DateTime? ThoiGianXuatHd { get; set; }

    public DateTime? ThoiGianHuyHd { get; set; }

    public int? TrangThai { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
