using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

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

    public int? LopCapMn { get; set; }

    public int? LopCapMn5t { get; set; }

    public int? LopCapTh { get; set; }

    public int? LopCapThcs { get; set; }

    public int? LopCapThpt { get; set; }

    public int? LopCapGdtx { get; set; }

    public int? ThuTu { get; set; }

    public string? MaVung { get; set; }

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
}
