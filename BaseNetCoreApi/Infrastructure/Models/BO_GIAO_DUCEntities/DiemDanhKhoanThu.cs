using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DiemDanhKhoanThu
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

    public int Thang { get; set; }

    public int Ngay1 { get; set; }

    public int Ngay2 { get; set; }

    public int Ngay3 { get; set; }

    public int Ngay4 { get; set; }

    public int Ngay5 { get; set; }

    public int Ngay6 { get; set; }

    public int Ngay7 { get; set; }

    public int Ngay8 { get; set; }

    public int Ngay9 { get; set; }

    public int Ngay10 { get; set; }

    public int Ngay11 { get; set; }

    public int Ngay12 { get; set; }

    public int Ngay13 { get; set; }

    public int Ngay14 { get; set; }

    public int Ngay15 { get; set; }

    public int Ngay16 { get; set; }

    public int Ngay17 { get; set; }

    public int Ngay18 { get; set; }

    public int Ngay19 { get; set; }

    public int Ngay20 { get; set; }

    public int Ngay21 { get; set; }

    public int Ngay22 { get; set; }

    public int Ngay23 { get; set; }

    public int Ngay24 { get; set; }

    public int Ngay25 { get; set; }

    public int Ngay26 { get; set; }

    public int Ngay27 { get; set; }

    public int Ngay28 { get; set; }

    public int Ngay29 { get; set; }

    public int Ngay30 { get; set; }

    public int Ngay31 { get; set; }

    public int TongThang { get; set; }

    public int TongThangTam { get; set; }

    public int SoNgayDaThuTien { get; set; }

    public int SoNgayThua { get; set; }

    public int DaChot { get; set; }

    public string? GhiChu { get; set; }

    public int IsAuto { get; set; }

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
