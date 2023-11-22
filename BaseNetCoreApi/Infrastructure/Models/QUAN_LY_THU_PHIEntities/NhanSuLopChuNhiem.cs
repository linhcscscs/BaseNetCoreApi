using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class NhanSuLopChuNhiem
{
    public decimal Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public decimal IdLop { get; set; }

    public decimal IdNhanSu { get; set; }

    public int HocKy { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }

    public decimal IdSource { get; set; }
}
