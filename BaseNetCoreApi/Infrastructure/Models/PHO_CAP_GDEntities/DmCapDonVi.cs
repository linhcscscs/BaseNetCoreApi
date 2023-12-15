using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class DmCapDonVi
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? ThuTu { get; set; }

    public string MaSource { get; set; } = null!;

    public virtual ICollection<PhongBan> PhongBans { get; set; } = new List<PhongBan>();
}
