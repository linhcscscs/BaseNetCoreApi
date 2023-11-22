using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DmMienGiam
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string? GhiChu { get; set; }

    public int? ThuTu { get; set; }

    public int? TrangThai { get; set; }

    public int IsCapMn { get; set; }

    public int IsCapTh { get; set; }

    public int IsCapThcs { get; set; }

    public int IsCapThpt { get; set; }

    public int IsCapGdtx { get; set; }

    public long? IdDmMienGiamSo { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual ICollection<HocSinhMienGiam> HocSinhMienGiams { get; set; } = new List<HocSinhMienGiam>();

    public virtual ICollection<KhoanThuMienGiam> KhoanThuMienGiams { get; set; } = new List<KhoanThuMienGiam>();

    public virtual ICollection<MapMienGiamH> MapMienGiamHs { get; set; } = new List<MapMienGiamH>();

    public virtual ICollection<PhieuThuCt> PhieuThuCts { get; set; } = new List<PhieuThuCt>();
}
