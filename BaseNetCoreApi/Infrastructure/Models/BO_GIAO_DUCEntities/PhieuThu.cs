using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class PhieuThu
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

    public long IdDotThu { get; set; }

    public string? MaPhieuThu { get; set; }

    public string? TienToPhieuThu { get; set; }

    public long? SttPhieuThu { get; set; }

    public string MaKhoi { get; set; } = null!;

    public string? MaNhomTuoiMn { get; set; }

    public decimal IdLop { get; set; }

    public string MaLop { get; set; } = null!;

    public decimal IdHocSinh { get; set; }

    public string MaHocSinh { get; set; } = null!;

    public string? TenHocSinh { get; set; }

    public decimal TongTienPhaiThu { get; set; }

    public decimal TienDaThu { get; set; }

    public decimal ConLai { get; set; }

    public int IsDaThanhToan { get; set; }

    public int KieuThanhToan { get; set; }

    public string? TaiKhoanThanhToan { get; set; }

    public string? DoiTacThanhToan { get; set; }

    public DateTime? ThoiDiemThanhToan { get; set; }

    public string? AnhThanhToanLocal { get; set; }

    public string? AnhThanhToanDo { get; set; }

    public string? GhiChuThanhToan { get; set; }

    public int IsChot { get; set; }

    public int IsEdited { get; set; }

    public string? FileName { get; set; }

    public string? FilePathLocal { get; set; }

    public string? FilePathDo { get; set; }

    public int IsUploadDo { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public long? SttPhieuThuTruong { get; set; }

    public virtual HocSinh IdHocSinhNavigation { get; set; } = null!;

    public virtual Lop IdLopNavigation { get; set; } = null!;

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual ICollection<LichSuThanhToan> LichSuThanhToans { get; set; } = new List<LichSuThanhToan>();

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;

    public virtual ICollection<PhieuThuCt> PhieuThuCts { get; set; } = new List<PhieuThuCt>();
}
