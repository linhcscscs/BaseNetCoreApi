using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class NguoiDung
{
    public decimal Id { get; set; }

    public string TenDangNhap { get; set; } = null!;

    public string? TenHienThi { get; set; }

    public string? MatKhau { get; set; }

    public long? GroupUserId { get; set; }

    public string? MaCapDonViHc { get; set; }

    public string? MaTinh { get; set; }

    public string? MaHuyen { get; set; }

    public string? MaXa { get; set; }

    public string? Email { get; set; }

    public string? DienThoaiDiDong { get; set; }

    public string? HoTen { get; set; }

    public string? Ip { get; set; }

    public string? MatKhauBackup { get; set; }

    public string? MaKhoiPhucMatKhau { get; set; }

    public int? IsRoot { get; set; }

    public int? IsRootSys { get; set; }

    public int? TrangThai { get; set; }

    public int? IsUpdate { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }

    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = new List<RefreshToken>();
}
