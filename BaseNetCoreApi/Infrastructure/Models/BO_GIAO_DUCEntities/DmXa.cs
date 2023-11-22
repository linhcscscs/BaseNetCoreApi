using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DmXa
{
    public decimal Id { get; set; }

    public string Ma { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal? IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? Cap { get; set; }

    public string? MaXaSapNhap { get; set; }

    public decimal IdSource { get; set; }

    public virtual DmHuyen? IdHuyenNavigation { get; set; }

    public virtual DmTinh MaTinhNavigation { get; set; } = null!;
}
