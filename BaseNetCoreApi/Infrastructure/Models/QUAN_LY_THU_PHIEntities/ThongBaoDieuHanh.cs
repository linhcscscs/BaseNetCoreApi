using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class ThongBaoDieuHanh
{
    public long Id { get; set; }

    public string TieuDe { get; set; } = null!;

    public string? UrlAnh { get; set; }

    public int? LoaiThongBao { get; set; }

    public int? CapThongBao { get; set; }

    public string? MoTa { get; set; }

    public string? NoiDung { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public int? IsGuiEmail { get; set; }

    public int? LuotXem { get; set; }

    public int? TrangThai { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
