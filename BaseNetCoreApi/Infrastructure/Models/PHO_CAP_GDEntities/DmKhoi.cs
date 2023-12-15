using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class DmKhoi
{
    public decimal Id { get; set; }

    public string Ma { get; set; } = null!;

    public string? MaCapHoc { get; set; }

    public string? Ten { get; set; }

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? MaLoaiLop { get; set; }

    public decimal IdSource { get; set; }

    public virtual DmCapHoc? MaCapHocNavigation { get; set; }
}
