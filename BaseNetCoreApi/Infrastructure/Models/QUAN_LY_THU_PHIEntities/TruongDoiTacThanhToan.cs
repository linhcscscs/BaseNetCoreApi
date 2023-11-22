using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class TruongDoiTacThanhToan
{
    public long Id { get; set; }

    public long IdTruongDangKySuDung { get; set; }

    public long IdDoiTacThanhToan { get; set; }

    public int IsDangKy { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual DoiTacThanhToan IdDoiTacThanhToanNavigation { get; set; } = null!;

    public virtual TruongDangKySuDung IdTruongDangKySuDungNavigation { get; set; } = null!;
}
