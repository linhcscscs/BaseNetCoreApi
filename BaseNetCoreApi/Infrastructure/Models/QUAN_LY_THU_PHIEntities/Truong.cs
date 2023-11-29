using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class Truong
{
    public decimal Id { get; set; }

    public int MaNamHoc { get; set; }

    public string? MaSoGd { get; set; }

    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string MaNhomCapHoc { get; set; } = null!;

    public string? DsCapHoc { get; set; }

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public string? MaTinh { get; set; }

    public decimal? IdHuyen { get; set; }

    public string? MaHuyen { get; set; }

    public decimal? IdXa { get; set; }

    public string? MaXa { get; set; }

    public string? DiaChi { get; set; }

    public string? MaLoaiHinhTruong { get; set; }

    public string? MaLoaiTruong { get; set; }

    public string? MaKhuVuc { get; set; }

    public string? MaDatChuanDanhGiaClgd { get; set; }

    public string? MaTrucThuoc { get; set; }

    public string? MaDuAn { get; set; }

    public int? SoDiemTruong { get; set; }

    public string? DienThoai { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Website { get; set; }

    public string? ViTriBanDo { get; set; }

    public string? HieuTruong { get; set; }

    public string? DienThoaiHieuTruong { get; set; }

    public string? EmailHieuTruong { get; set; }

    public int? IsCoChiBoDang { get; set; }

    public int? IsDatChuanQg { get; set; }

    public int? IsTruongQuocTe { get; set; }

    public int? IsCapMn { get; set; }

    public int? IsCapTh { get; set; }

    public int? IsCapThcs { get; set; }

    public int? IsCapThpt { get; set; }

    public int? IsCapGdtx { get; set; }

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public int? TrangThai { get; set; }

    public int? IsCoLopNho { get; set; }

    public int? IsNhoTren { get; set; }

    public int? IsNhoDuoi { get; set; }

    public string? KinhTuyen { get; set; }

    public string? ViTuyen { get; set; }

    public decimal IdSource { get; set; }

    public virtual ICollection<CauHinhPhieuThu> CauHinhPhieuThus { get; set; } = new List<CauHinhPhieuThu>();

    public virtual ICollection<DiemDanhHsNhom> DiemDanhHsNhoms { get; set; } = new List<DiemDanhHsNhom>();

    public virtual ICollection<DiemDanhKhoanThuKy> DiemDanhKhoanThuKies { get; set; } = new List<DiemDanhKhoanThuKy>();

    public virtual ICollection<DiemDanhKhoanThuNam> DiemDanhKhoanThuNams { get; set; } = new List<DiemDanhKhoanThuNam>();

    public virtual ICollection<DiemDanhKhoanThu> DiemDanhKhoanThus { get; set; } = new List<DiemDanhKhoanThu>();

    public virtual ICollection<DkKhoanThuTn> DkKhoanThuTns { get; set; } = new List<DkKhoanThuTn>();

    public virtual ICollection<DotThuDoiTuong> DotThuDoiTuongs { get; set; } = new List<DotThuDoiTuong>();

    public virtual ICollection<DotThuKhoanThu> DotThuKhoanThus { get; set; } = new List<DotThuKhoanThu>();

    public virtual ICollection<DotThu> DotThus { get; set; } = new List<DotThu>();

    public virtual ICollection<HocSinhMienGiam> HocSinhMienGiams { get; set; } = new List<HocSinhMienGiam>();

    public virtual ICollection<KhoaDiemDanhKy> KhoaDiemDanhKies { get; set; } = new List<KhoaDiemDanhKy>();

    public virtual ICollection<KhoaDiemDanhNam> KhoaDiemDanhNams { get; set; } = new List<KhoaDiemDanhNam>();

    public virtual ICollection<KhoaDiemDanh> KhoaDiemDanhs { get; set; } = new List<KhoaDiemDanh>();

    public virtual ICollection<KhoanThuDoiTuong> KhoanThuDoiTuongs { get; set; } = new List<KhoanThuDoiTuong>();

    public virtual ICollection<KhoanThuMienGiam> KhoanThuMienGiams { get; set; } = new List<KhoanThuMienGiam>();

    public virtual ICollection<LichSuThanhToan> LichSuThanhToans { get; set; } = new List<LichSuThanhToan>();

    public virtual ICollection<PhieuThuCt> PhieuThuCts { get; set; } = new List<PhieuThuCt>();

    public virtual ICollection<PhieuThu> PhieuThus { get; set; } = new List<PhieuThu>();
}
