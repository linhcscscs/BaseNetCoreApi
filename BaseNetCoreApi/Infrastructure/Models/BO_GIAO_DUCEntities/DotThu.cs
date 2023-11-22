using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DotThu
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

    public string Ten { get; set; } = null!;

    public int IsKhauTru { get; set; }

    public int IsTraTungPhan { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public string? GhiChu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual ICollection<DotThuDoiTuong> DotThuDoiTuongs { get; set; } = new List<DotThuDoiTuong>();

    public virtual ICollection<DotThuKhoanThu> DotThuKhoanThus { get; set; } = new List<DotThuKhoanThu>();

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual ICollection<LichSuThanhToan> LichSuThanhToans { get; set; } = new List<LichSuThanhToan>();

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;
}
