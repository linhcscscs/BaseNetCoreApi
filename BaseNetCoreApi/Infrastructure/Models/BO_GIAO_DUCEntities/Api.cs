using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class Api
{
    public long Id { get; set; }

    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public string Url { get; set; } = null!;

    public int? ThuTu { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? NguoiSua { get; set; }
}
