using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class NhanSu
{
    public decimal Id { get; set; }

    public string? HoTen { get; set; }

    public string? Ma { get; set; }

    public DateOnly? NgaySinh { get; set; }

    public string? NoiSinh { get; set; }

    public string? MaCapDonVi { get; set; }

    public int? MaNamHoc { get; set; }

    public string? MaSoGd { get; set; }

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public decimal? IdTruong { get; set; }

    public string? MaTruong { get; set; }

    public string? MaTinh { get; set; }

    public decimal? IdHuyen { get; set; }

    public string? MaHuyen { get; set; }

    public decimal? IdXa { get; set; }

    public string? MaXa { get; set; }

    public string? MaCapHoc { get; set; }

    public string SoCmtnd { get; set; } = null!;

    public string? NoiCap { get; set; }

    public DateOnly? NgayCap { get; set; }

    public string? UrlAnhDaiDien { get; set; }

    public string? DiDong { get; set; }

    public string? Email { get; set; }

    public string? MaGioiTinh { get; set; }

    public string? MaDanToc { get; set; }

    public string? MaTonGiao { get; set; }

    public string? MaNuoc { get; set; }

    public string? MaLoaiCanBo { get; set; }

    public string? MaNhomCanBo { get; set; }

    public string? MaPhongBan { get; set; }

    public int? IsMn { get; set; }

    public int? IsC1 { get; set; }

    public int? IsC2 { get; set; }

    public int? IsC3 { get; set; }

    public int? IsGdtx { get; set; }

    public string? ApiMaBo { get; set; }

    public string? MaSoDinhDanhCaNhan { get; set; }

    public int? IsCoChipCccd { get; set; }

    public string? MaCapHocChinh { get; set; }

    public string? MaTrangThaiCanBo { get; set; }

    public int? IsTrangThaiKy1 { get; set; }

    public int? IsTrangThaiKy2 { get; set; }

    public int? TrangThai { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal IdSource { get; set; }

    public string? Ten { get; set; }
}
