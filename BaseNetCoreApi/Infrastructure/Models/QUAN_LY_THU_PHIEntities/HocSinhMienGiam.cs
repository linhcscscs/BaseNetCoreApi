using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class HocSinhMienGiam
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string MaKhoi { get; set; } = null!;

    public string? MaNhomTuoiMn { get; set; }

    public decimal? IdLop { get; set; }

    public string? MaLop { get; set; }

    public decimal IdHocSinh { get; set; }

    public string? MaHocSinh { get; set; }

    public long IdDmMienGiam { get; set; }

    public string? GhiChu { get; set; }

    public int IsAuto { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public DateTime? NgayBatDau { get; set; }

    public DateTime? NgayKetThuc { get; set; }

    public virtual DmMienGiam IdDmMienGiamNavigation { get; set; } = null!;

    public virtual HocSinh IdHocSinhNavigation { get; set; } = null!;

    public virtual Lop? IdLopNavigation { get; set; }

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;
}
