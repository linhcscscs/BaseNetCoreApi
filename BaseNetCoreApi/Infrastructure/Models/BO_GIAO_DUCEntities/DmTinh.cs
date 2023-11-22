using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DmTinh
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? Cap { get; set; }

    public string MaSource { get; set; } = null!;

    public virtual ICollection<DmHuyen> DmHuyens { get; set; } = new List<DmHuyen>();

    public virtual ICollection<DmXa> DmXas { get; set; } = new List<DmXa>();
}
