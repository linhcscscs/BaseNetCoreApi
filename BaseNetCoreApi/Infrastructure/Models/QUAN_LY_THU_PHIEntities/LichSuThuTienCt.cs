using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class LichSuThuTienCt
{
    public long Id { get; set; }

    public long IdLstt { get; set; }

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

    public long IdPhieuThu { get; set; }

    public long IdDotThu { get; set; }

    public long IdKhoanThu { get; set; }

    public string? NoiDung { get; set; }

    public decimal SoTien { get; set; }

    public int LoaiCt { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual LichSuThuTien IdLsttNavigation { get; set; } = null!;
}
