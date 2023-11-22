using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class CauHinhTruong
{
    public decimal Id { get; set; }

    public string? MaSoGd { get; set; }

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public decimal? IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string? MaCapHoc { get; set; }

    public int? IsKhoaK1 { get; set; }

    public int? IsKhoaK2 { get; set; }

    public int ThangDauKyI { get; set; }

    public int ThangCuoiKyI { get; set; }

    public int ThangDauKyIi { get; set; }

    public int ThangCuoiKyIi { get; set; }

    public int NgayDauKyI { get; set; }

    public int NgayCuoiKyI { get; set; }

    public int NgayDauKyIi { get; set; }

    public int NgayCuoiKyIi { get; set; }

    public int NamDauKyI { get; set; }

    public int NamCuoiKyI { get; set; }

    public int NamDauKyIi { get; set; }

    public int NamCuoiKyIi { get; set; }

    /// <summary>
    /// Không hiện học sinh nghỉ học, chuyển trường, kỷ luật, miễn môn...(mặc định là hiện):
    /// 0: Có hiện
    /// 1: Không hiện
    /// </summary>
    public int IsKhongHienHocSinhKhongHoc { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal IdSource { get; set; }
}
