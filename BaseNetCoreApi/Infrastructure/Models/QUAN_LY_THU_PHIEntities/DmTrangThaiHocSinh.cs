using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class DmTrangThaiHocSinh
{
    public string Ma { get; set; } = null!;

    public string? MaChuyenDenChuyenDi { get; set; }

    public string Ten { get; set; } = null!;

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string MaSource { get; set; } = null!;
}
