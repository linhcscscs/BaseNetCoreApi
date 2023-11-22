using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class SoGd
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string MaTinh { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Website { get; set; }

    public string? GiamDoc { get; set; }

    public string? DienThoaiGiamDoc { get; set; }

    public string? EmailGiamDoc { get; set; }

    public string? ChanhVanPhong { get; set; }

    public string? DienThoaiChanhVanPhong { get; set; }

    public string? EmailChanhVanPhong { get; set; }

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public int? TrangThai { get; set; }

    public string? TenDiaPhuong { get; set; }

    public string MaSource { get; set; } = null!;
}
