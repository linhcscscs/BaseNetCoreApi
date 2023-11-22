using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class CapMaPhieuThu
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaPhieuThu { get; set; } = null!;

    public string TienToPhieuThu { get; set; } = null!;

    public long? SttPhieuThu { get; set; }

    public string? MaSoGd { get; set; }

    public decimal? IdTruong { get; set; }

    public string? MaTruong { get; set; }

    public long? IdDotThu { get; set; }

    public decimal? IdHocSinh { get; set; }

    public string? MaHocSinh { get; set; }

    public long? SttPhieuThuTruong { get; set; }
}
