using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class NamHoc
{
    public int Ma { get; set; }

    public string Ten { get; set; } = null!;

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string MaSource { get; set; } = null!;

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
