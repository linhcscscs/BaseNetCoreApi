using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class LichSuThuTien
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public int KieuThanhToan { get; set; }

    public decimal SoTien { get; set; }

    public int? LoaiHoanTra { get; set; }

    public string? NguoiThu { get; set; }

    public DateTime? NgayThu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? TaiKhoanThanhToan { get; set; }

    public string? DoiTacThanhToan { get; set; }

    public DateTime? ThoiDiemThanhToan { get; set; }

    public string? GhiChuThanhToan { get; set; }

    public virtual ICollection<LichSuThuTienCt> LichSuThuTienCts { get; set; } = new List<LichSuThuTienCt>();
}
