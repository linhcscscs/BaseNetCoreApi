using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class Lop
{
    public decimal Id { get; set; }

    public string? MaSoGd { get; set; }

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public decimal? IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string? Ma { get; set; }

    public int MaNamHoc { get; set; }

    public string? MaCapHoc { get; set; }

    public string? MaGiaoVienChuNhiem { get; set; }

    public string? MaKieuLop { get; set; }

    public string? MaKhoi { get; set; }

    public string? MaPhanBan { get; set; }

    public string? MaNhomTuoiMn { get; set; }

    public string? Ten { get; set; }

    public decimal? IdGiaoVienChuNhiem { get; set; }

    public int? TrangThai { get; set; }

    public decimal? IdGiaoVienChuNhiemKy2 { get; set; }

    public int TrangThaiKy2 { get; set; }

    public string? ApiMaHcm { get; set; }

    public Guid MaGuid { get; set; }

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal IdSource { get; set; }
}
