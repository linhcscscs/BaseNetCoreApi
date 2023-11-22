using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class DmMienGiamSo
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

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual ICollection<MapMienGiamHsSo> MapMienGiamHsSos { get; set; } = new List<MapMienGiamHsSo>();
}
