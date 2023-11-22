using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class TruongDangKySuDung
{
    public long Id { get; set; }

    public string? MaSoGd { get; set; }

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public int IsThuPhi { get; set; }

    public int? IsHoaDonDienTu { get; set; }

    public string? MaSoThue { get; set; }

    public string? MaBaoMat { get; set; }

    public string? KyHieu { get; set; }

    public string? MaLoaiHoaDon { get; set; }

    public string? MaMauHoaDon { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual ICollection<TruongDoiTacThanhToan> TruongDoiTacThanhToans { get; set; } = new List<TruongDoiTacThanhToan>();
}
