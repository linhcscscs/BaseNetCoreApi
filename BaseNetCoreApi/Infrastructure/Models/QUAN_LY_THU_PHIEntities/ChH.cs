using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class ChH
{
    public int Id { get; set; }

    public string? TenCot { get; set; }

    public string? TenCotHienThi { get; set; }

    public int? LoaiDuLieu { get; set; }

    public string? KieuDuLieu { get; set; }

    public string? MinValue { get; set; }

    public string? MaxValue { get; set; }

    public string? GiaTri { get; set; }

    public virtual ICollection<MapMienGiamH> MapMienGiamHs { get; set; } = new List<MapMienGiamH>();

    public virtual ICollection<MapMienGiamHsSo> MapMienGiamHsSos { get; set; } = new List<MapMienGiamHsSo>();
}
