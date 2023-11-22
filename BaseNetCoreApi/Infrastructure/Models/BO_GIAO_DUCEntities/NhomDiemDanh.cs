using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class NhomDiemDanh
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int ThuTu { get; set; }

    public string? GhiChu { get; set; }

    public int TrangThai { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual ICollection<DiemDanhHsNhom> DiemDanhHsNhoms { get; set; } = new List<DiemDanhHsNhom>();
}
