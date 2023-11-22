using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class QuyenNguoiDung
{
    public long Id { get; set; }

    public string? MaSoGd { get; set; }

    public string? MaTruong { get; set; }

    public decimal IdNguoiDung { get; set; }

    public string? MaNguoiDung { get; set; }

    public long IdNhomQuyen { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
