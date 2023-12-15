using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class PhieuDieuTraCt
{
    public long Id { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public long IdPhieuDieuTra { get; set; }

    public string MaToThon { get; set; } = null!;

    public decimal IdToThon { get; set; }

    public string SoPhieu { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public string Ho { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public DateTime NgaySinh { get; set; }

    public string MaGioiTinh { get; set; } = null!;

    public string CanCuocCongDan { get; set; } = null!;

    public string? MaDanToc { get; set; }

    public string? MaTonGiao { get; set; }

    public string? DienUuTien { get; set; }

    public string? QuanHeVoiChuHo { get; set; }

    public string? QuanHeKhac { get; set; }

    public string? MaDienCuTru { get; set; }

    public string? MaTinhTrangCuTru { get; set; }

    public string? MaLoaiKhuyetTat { get; set; }

    public int IsCoChungNhanKhuyetTat { get; set; }

    public int IsCoKhaNangHocTap { get; set; }

    public string? MaHoanCanhDacBiet { get; set; }

    public DateTime? NgayTrangThai { get; set; }

    public string? ChiTietHoanCanhDacBiet { get; set; }

    public string? MaCapHoc { get; set; }

    public string? MaKhoi { get; set; }

    public string? TenLop { get; set; }

    public int IsLuuBanNamTruoc { get; set; }

    public string? MaTinhHocTap { get; set; }

    public decimal? IdHuyenHocTap { get; set; }

    public string? MaHuyenHocTap { get; set; }

    public decimal? IdTruongHocTap { get; set; }

    public string? MaTruongHocTap { get; set; }

    public int IsTrongDiaBanHocTap { get; set; }

    public string? MaSoBuoiHocTrenTuan { get; set; }

    public string? DsMaSucKhoeNuoiDuong { get; set; }

    public int IsAnBanTru { get; set; }

    public int IsHocDayDuTheoQuyDinh { get; set; }

    public int IsChuyenCan { get; set; }

    public int IsTreDanTocDuocChuanBiTiengViet { get; set; }

    public int IsHocHeBoTuc { get; set; }

    public string? MaBacTotNghiepPhoThong { get; set; }

    public string? NamTotNghiepPhoThong { get; set; }

    public string? SoBangTotNghiep { get; set; }

    public int IsTotNghiepHeBoTuc { get; set; }

    public string? MaBacTotNghiepNghe { get; set; }

    public string? NamTotNghiepNghe { get; set; }

    public string? MaHocXongLop { get; set; }

    public string? NamHocXongLop { get; set; }

    public string? MaBoHocLop { get; set; }

    public string? NamBoHocLop { get; set; }

    public string? MaMucTaiMuChu { get; set; }

    public string? MaHocXoaMuChuLop { get; set; }

    public string? MaHoanThanhXoaMuChuLop { get; set; }

    public int IsTotNghiepThcsHeBoTuc { get; set; }

    public string? TenCha { get; set; }

    public string? TenMe { get; set; }

    public string? TenNguoiDd { get; set; }

    public string? GhiChu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
