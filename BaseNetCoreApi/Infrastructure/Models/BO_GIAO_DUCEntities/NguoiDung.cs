using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class NguoiDung
{
    public decimal Id { get; set; }

    public string? MaNhanSu { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public int? MaNamHoc { get; set; }

    public string? TenHienThi { get; set; }

    public string? MatKhau { get; set; }

    public string? MaNhomQuyen { get; set; }

    public string? MaCapDonVi { get; set; }

    public string? MaSoGd { get; set; }

    public string? MaPhongGd { get; set; }

    public string? MaTruong { get; set; }

    public int? IsRoot { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }

    public int? IsRootSys { get; set; }

    public int? TrangThai { get; set; }

    public int? IsUpdate { get; set; }

    public string? Email { get; set; }

    public string? DienThoaiDiDong { get; set; }

    public string? HoTen { get; set; }

    public string? ChucVuPhongBan { get; set; }

    public string? ConnectionId { get; set; }

    public string? Ip { get; set; }

    public string? MatKhauBackup { get; set; }

    public int? IsMasterRootSys { get; set; }

    public string? MaKhoiPhucMatKhau { get; set; }

    public decimal IdSource { get; set; }

    public virtual ICollection<NhomQuyenNguoiDung> NhomQuyenNguoiDungs { get; set; } = new List<NhomQuyenNguoiDung>();

    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}
