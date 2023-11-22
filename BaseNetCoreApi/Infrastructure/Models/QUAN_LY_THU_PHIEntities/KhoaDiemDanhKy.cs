using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class KhoaDiemDanhKy
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public int HocKy { get; set; }

    public int Nam { get; set; }

    public string MaKhoi { get; set; } = null!;

    public decimal IdLop { get; set; }

    public string MaLop { get; set; } = null!;

    public int IsKhoa { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual Lop IdLopNavigation { get; set; } = null!;

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;
}
