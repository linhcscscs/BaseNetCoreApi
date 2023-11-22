using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class DkKhoanThuTn
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string MaKhoi { get; set; } = null!;

    public string? MaNhomTuoiMn { get; set; }

    public decimal IdLop { get; set; }

    public string MaLop { get; set; } = null!;

    public decimal IdHocSinh { get; set; }

    public string MaHocSinh { get; set; } = null!;

    public long IdKhoanThu { get; set; }

    public int DkNam { get; set; }

    public int DkK1 { get; set; }

    public int DkK2 { get; set; }

    public int DkT1 { get; set; }

    public int DkT2 { get; set; }

    public int DkT3 { get; set; }

    public int DkT4 { get; set; }

    public int DkT5 { get; set; }

    public int DkT6 { get; set; }

    public int DkT7 { get; set; }

    public int DkT8 { get; set; }

    public int DkT9 { get; set; }

    public int DkT10 { get; set; }

    public int DkT11 { get; set; }

    public int DkT12 { get; set; }

    public string? GhiChu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual HocSinh IdHocSinhNavigation { get; set; } = null!;

    public virtual KhoanThu IdKhoanThuNavigation { get; set; } = null!;

    public virtual Lop IdLopNavigation { get; set; } = null!;

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;
}
