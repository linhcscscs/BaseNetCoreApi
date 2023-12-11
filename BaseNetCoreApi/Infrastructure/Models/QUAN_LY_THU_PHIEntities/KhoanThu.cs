using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class KhoanThu
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string Ten { get; set; } = null!;

    public int DonViTinh { get; set; }

    public int KyThu { get; set; }

    public int? ThoiDiemThuQ1 { get; set; }

    public int? ThoiDiemThuQ2 { get; set; }

    public int? ThoiDiemThuQ3 { get; set; }

    public int? ThoiDiemThuQ4 { get; set; }

    public int? ThoiDiemThuK1 { get; set; }

    public int? ThoiDiemThuK2 { get; set; }

    public int? ThoiDiemThuCn { get; set; }

    public int IsBatBuoc { get; set; }

    public int IsMienGiam { get; set; }

    public int IsXuatHd { get; set; }

    public int IsXuatCt { get; set; }

    public int IsThuNoiBo { get; set; }

    public int IsDiemDanh { get; set; }

    public int IsKhauTru { get; set; }

    public long? IdNhomDiemDanh { get; set; }

    public long? IdDmKhoanThu { get; set; }

    public long? IdDmNhomKhoanThu { get; set; }

    public int TrangThai { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public int IsThuHoChiHo { get; set; }

    public int IsThuThoaThuan { get; set; }

    public int IsThuLienKet { get; set; }

    public int IsLaySlDgHs { get; set; }

    public virtual ICollection<DiemDanhKhoanThuKy> DiemDanhKhoanThuKies { get; set; } = new List<DiemDanhKhoanThuKy>();

    public virtual ICollection<DiemDanhKhoanThuNam> DiemDanhKhoanThuNams { get; set; } = new List<DiemDanhKhoanThuNam>();

    public virtual ICollection<DiemDanhKhoanThu> DiemDanhKhoanThus { get; set; } = new List<DiemDanhKhoanThu>();

    public virtual ICollection<DkKhoanThuSlDg> DkKhoanThuSlDgs { get; set; } = new List<DkKhoanThuSlDg>();

    public virtual ICollection<DkKhoanThuTn> DkKhoanThuTns { get; set; } = new List<DkKhoanThuTn>();

    public virtual ICollection<DotThuKhoanThu> DotThuKhoanThus { get; set; } = new List<DotThuKhoanThu>();

    public virtual ICollection<KhoanThuDoiTuong> KhoanThuDoiTuongs { get; set; } = new List<KhoanThuDoiTuong>();

    public virtual ICollection<KhoanThuMienGiam> KhoanThuMienGiams { get; set; } = new List<KhoanThuMienGiam>();

    public virtual ICollection<PhieuThuCt> PhieuThuCts { get; set; } = new List<PhieuThuCt>();
}
