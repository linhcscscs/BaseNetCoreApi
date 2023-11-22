using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class KhoanThuMienGiam
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public long IdKhoanThu { get; set; }

    public long IdDmMienGiam { get; set; }

    public decimal? SoTienGiam { get; set; }

    public decimal? PhanTramGiam { get; set; }

    public decimal? SoTienGiamToiDa { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual DmMienGiam IdDmMienGiamNavigation { get; set; } = null!;

    public virtual KhoanThu IdKhoanThuNavigation { get; set; } = null!;

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;
}
