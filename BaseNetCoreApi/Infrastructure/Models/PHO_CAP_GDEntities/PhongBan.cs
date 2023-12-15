using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class PhongBan
{
    public string Ma { get; set; } = null!;

    public string? MaParent { get; set; }

    public string? MaDonVi { get; set; }

    public string? MaCapDonVi { get; set; }

    public string? MaNhomQuyen { get; set; }

    public string? Ten { get; set; }

    public string? MaPhanCap { get; set; }

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Website { get; set; }

    public string? TruongDonVi { get; set; }

    public string? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public int? TrangThai { get; set; }

    public string? MaBaoCao { get; set; }

    public string MaSource { get; set; } = null!;

    public virtual DmCapDonVi? MaCapDonViNavigation { get; set; }
}
