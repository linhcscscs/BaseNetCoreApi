using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class NhomQuyen
{
    public decimal Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public string? Ten { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? NguoiSua { get; set; }

    public string? DsMaQuyen { get; set; }

    public virtual ICollection<NhomQuyenNguoiDung> NhomQuyenNguoiDungs { get; set; } = new List<NhomQuyenNguoiDung>();
}
