using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DmHinhThucThanhToan
{
    public long Id { get; set; }

    public int Ma { get; set; }

    public string Ten { get; set; } = null!;

    public string? GhiChu { get; set; }

    public int? ThuTu { get; set; }

    public int? TrangThai { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
