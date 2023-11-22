using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class Lop
{
    public decimal Id { get; set; }

    public string? MaSoGd { get; set; }

    public decimal? IdPhongGd { get; set; }

    public string? MaPhongGd { get; set; }

    public decimal? IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public string? Ma { get; set; }

    public int MaNamHoc { get; set; }

    public string? MaCapHoc { get; set; }

    public string? MaGiaoVienChuNhiem { get; set; }

    public string? MaKieuLop { get; set; }

    public string? MaKhoi { get; set; }

    public string? MaPhanBan { get; set; }

    public string? MaNhomTuoiMn { get; set; }

    public string? Ten { get; set; }

    public decimal? IdGiaoVienChuNhiem { get; set; }

    public int? TrangThai { get; set; }

    public decimal? IdGiaoVienChuNhiemKy2 { get; set; }

    public int TrangThaiKy2 { get; set; }

    public string? ApiMaHcm { get; set; }

    public Guid MaGuid { get; set; }

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal IdSource { get; set; }

    public int? IsQltp { get; set; }

    public virtual ICollection<DiemDanhHsNhom> DiemDanhHsNhoms { get; set; } = new List<DiemDanhHsNhom>();

    public virtual ICollection<DiemDanhKhoanThuKy> DiemDanhKhoanThuKies { get; set; } = new List<DiemDanhKhoanThuKy>();

    public virtual ICollection<DiemDanhKhoanThuNam> DiemDanhKhoanThuNams { get; set; } = new List<DiemDanhKhoanThuNam>();

    public virtual ICollection<DiemDanhKhoanThu> DiemDanhKhoanThus { get; set; } = new List<DiemDanhKhoanThu>();

    public virtual ICollection<DkKhoanThuSlDg> DkKhoanThuSlDgs { get; set; } = new List<DkKhoanThuSlDg>();

    public virtual ICollection<DkKhoanThuTn> DkKhoanThuTns { get; set; } = new List<DkKhoanThuTn>();

    public virtual ICollection<DotThuDoiTuong> DotThuDoiTuongs { get; set; } = new List<DotThuDoiTuong>();

    public virtual ICollection<HocSinhMienGiam> HocSinhMienGiams { get; set; } = new List<HocSinhMienGiam>();

    public virtual ICollection<KhoaDiemDanhKy> KhoaDiemDanhKies { get; set; } = new List<KhoaDiemDanhKy>();

    public virtual ICollection<KhoaDiemDanhNam> KhoaDiemDanhNams { get; set; } = new List<KhoaDiemDanhNam>();

    public virtual ICollection<KhoaDiemDanh> KhoaDiemDanhs { get; set; } = new List<KhoaDiemDanh>();

    public virtual ICollection<KhoanThuDoiTuong> KhoanThuDoiTuongs { get; set; } = new List<KhoanThuDoiTuong>();

    public virtual ICollection<LichSuThanhToan> LichSuThanhToans { get; set; } = new List<LichSuThanhToan>();

    public virtual ICollection<PhieuThuCt> PhieuThuCts { get; set; } = new List<PhieuThuCt>();

    public virtual ICollection<PhieuThu> PhieuThus { get; set; } = new List<PhieuThu>();
}
