using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class LichSuThanhToan
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public int HocKy { get; set; }

    public int Thang { get; set; }

    public int Nam { get; set; }

    public string MaKhoi { get; set; } = null!;

    public string? MaNhomTuoiMn { get; set; }

    public decimal IdLop { get; set; }

    public string MaLop { get; set; } = null!;

    public decimal IdHocSinh { get; set; }

    public string MaHocSinh { get; set; } = null!;

    public string? TaiKhoanThanhToan { get; set; }

    public string? DoiTacThanhToan { get; set; }

    public DateTime? ThoiDiemThanhToan { get; set; }

    public string? GhiChuThanhToan { get; set; }

    public long? IdKhoanThu { get; set; }

    public int? SoNgayThua { get; set; }

    public decimal? DonGia { get; set; }

    public decimal SoTien { get; set; }

    public long? IdLstt { get; set; }

    public int IsSuDung { get; set; }

    public int LoaiSuDung { get; set; }

    public long? IdDotThu { get; set; }

    public long? IdPhieuThu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? DoiTuongThucHien { get; set; }

    public virtual DotThu? IdDotThuNavigation { get; set; }

    public virtual HocSinh IdHocSinhNavigation { get; set; } = null!;

    public virtual Lop IdLopNavigation { get; set; } = null!;

    public virtual PhieuThu? IdPhieuThuNavigation { get; set; }

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;
}
