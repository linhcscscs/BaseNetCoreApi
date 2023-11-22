using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class PhongGd
{
    public decimal Id { get; set; }

    public string Ma { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string MaTinh { get; set; } = null!;

    public decimal? IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Website { get; set; }

    public string? TruongPhong { get; set; }

    public string? DienThoaiTruongPhong { get; set; }

    public string? EmailTruongPhong { get; set; }

    public string? CanBoPhuTrach { get; set; }

    public string? DienThoaiCanBoPhuTrach { get; set; }

    public string? EmailCanBoPhuTrach { get; set; }

    public int? ThuTu { get; set; }

    public int? TrangThai { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal IdSource { get; set; }
}
