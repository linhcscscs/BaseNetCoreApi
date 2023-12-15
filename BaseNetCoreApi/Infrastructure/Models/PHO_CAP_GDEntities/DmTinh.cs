using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

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

    public virtual ICollection<DmToThon> DmToThons { get; set; } = new List<DmToThon>();

    public virtual ICollection<DmXa> DmXas { get; set; } = new List<DmXa>();
}
