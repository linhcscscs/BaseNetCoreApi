﻿using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class HocSinh
{
    public decimal Id { get; set; }

    public string? MaSoGd { get; set; }

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public decimal? IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string MaCapHoc { get; set; } = null!;

    public string MaKhoi { get; set; } = null!;

    public decimal? IdLop { get; set; }

    public string? MaLop { get; set; }

    public string Ma { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public DateOnly NgaySinh { get; set; }

    public string MaGioiTinh { get; set; } = null!;

    public string? MaDanToc { get; set; }

    public string? MaQuocTich { get; set; }

    public string? MaKhuVuc { get; set; }

    public string? MaLoaiKhuyetTat { get; set; }

    public string? MaTinh { get; set; }

    public decimal? IdHuyen { get; set; }

    public string? MaHuyen { get; set; }

    public decimal? IdXa { get; set; }

    public string? MaXa { get; set; }

    public string? ThonXom { get; set; }

    public string? NoiSinh { get; set; }

    public string? ChoOHienNay { get; set; }

    public string? TenCha { get; set; }

    public int? NamSinhCha { get; set; }

    public string? NgheNghiepCha { get; set; }

    public string? DienThoaiCha { get; set; }

    public string? TenMe { get; set; }

    public int? NamSinhMe { get; set; }

    public string? NgheNghiepMe { get; set; }

    public string? DienThoaiMe { get; set; }

    public string? TenNguoiDd { get; set; }

    public int? NamSinhNguoiDoDau { get; set; }

    public string? NgheNghiepNguoiDd { get; set; }

    public string? DienThoaiNguoiDd { get; set; }

    public string? DienThoaiLienHe { get; set; }

    public string? UrlAnhDaiDien { get; set; }

    public string? DanTocTheoGiayKhaiSinh { get; set; }

    public string? MaCongDan { get; set; }

    public string? QueQuan { get; set; }

    public string? MaDiaPhuong { get; set; }

    public string? MaTonGiao { get; set; }

    public int? IsKhuyetTatKhongDanhGia { get; set; }

    public int? IsHoNgheo { get; set; }

    public int? IsVungKk { get; set; }

    public int? IsMeDt { get; set; }

    public int? IsChaDt { get; set; }

    public string? MaDienChinhSach { get; set; }

    public int? IsMienHocPhi { get; set; }

    public int? IsGiamHocPhi { get; set; }

    public int? IsHoTroChiPhiHocTap { get; set; }

    public int? IsCapTienHangThang { get; set; }

    public int? IsCapGao { get; set; }

    public int? IsHoTroNhaO { get; set; }

    public int? IsHocCtgdCuaBo { get; set; }

    public int? IsHoTroAnTrua { get; set; }

    public int? IsHocLopMg5t { get; set; }

    public int? IsTuyenMoiMn { get; set; }

    public string? MaLoaiBoThuongBinh { get; set; }

    public string? MaSoDinhDanhCaNhan { get; set; }

    public int? IsCoChipCccd { get; set; }

    public string? MaTrangThaiK1 { get; set; }

    public string? MaTrangThaiK2 { get; set; }

    public string MaTrangThaiHienTai { get; set; } = null!;

    public DateOnly? NgayTrangThai { get; set; }

    public int? IsDangHocK1 { get; set; }

    public int? IsDangHocK2 { get; set; }

    public int? ThuTu { get; set; }

    public string? ApiMaHcm { get; set; }

    public string? ApiMaBo { get; set; }

    public string? KeySystem { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal IdSource { get; set; }
}
