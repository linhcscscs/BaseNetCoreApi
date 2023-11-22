using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class PhieuThuCt
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public int HocKy { get; set; }

    public int Thang { get; set; }

    public int Nam { get; set; }

    public long IdDotThu { get; set; }

    public string MaKhoi { get; set; } = null!;

    public string? MaNhomTuoiMn { get; set; }

    public decimal IdLop { get; set; }

    public string MaLop { get; set; } = null!;

    public decimal IdHocSinh { get; set; }

    public string MaHocSinh { get; set; } = null!;

    public long IdPhieuThu { get; set; }

    public int LoaiCt { get; set; }

    public long? IdKhoanThu { get; set; }

    public long? IdDmMienGiam { get; set; }

    public string? NoiDung { get; set; }

    public int? DonViTinh { get; set; }

    public double SoLuong { get; set; }

    public double SoLuongHt { get; set; }

    public double SoLuongTruoc { get; set; }

    public decimal? DonGia { get; set; }

    public decimal? ThanhTien { get; set; }

    public decimal? PcMienGiam { get; set; }

    public decimal? StMienGiam { get; set; }

    public decimal? MienGiam { get; set; }

    public decimal? DaThu { get; set; }

    public decimal? ConLai { get; set; }

    public decimal? HoanTra { get; set; }

    public int? LoaiHoanTra { get; set; }

    public int IsEdited { get; set; }

    public string? GhiChu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual DmMienGiam? IdDmMienGiamNavigation { get; set; }

    public virtual HocSinh IdHocSinhNavigation { get; set; } = null!;

    public virtual KhoanThu? IdKhoanThuNavigation { get; set; }

    public virtual Lop IdLopNavigation { get; set; } = null!;

    public virtual PhieuThu IdPhieuThuNavigation { get; set; } = null!;

    public virtual Truong IdTruongNavigation { get; set; } = null!;

    public virtual DmCapHoc MaCapHocNavigation { get; set; } = null!;

    public virtual NamHoc MaNamHocNavigation { get; set; } = null!;
}
