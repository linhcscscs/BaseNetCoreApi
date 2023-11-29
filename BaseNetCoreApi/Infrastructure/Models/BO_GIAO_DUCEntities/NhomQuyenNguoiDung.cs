using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class NhomQuyenNguoiDung
{
    public decimal Id { get; set; }

    public decimal NguoiDungId { get; set; }

    public decimal NhomQuyenId { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public DateTime? NgayLap { get; set; }

    public string? NguoiLap { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiTao { get; set; }

    public virtual NguoiDung NguoiDung { get; set; } = null!;

    public virtual NhomQuyen NhomQuyen { get; set; } = null!;
}
