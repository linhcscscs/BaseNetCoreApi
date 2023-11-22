using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DmKhoanThu
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string? Ma { get; set; }

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

    public int? NamBatDau { get; set; }

    public int TrangThai { get; set; }

    public int? ThuTu { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
