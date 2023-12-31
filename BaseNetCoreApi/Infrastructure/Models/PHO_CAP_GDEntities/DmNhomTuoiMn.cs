﻿using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class DmNhomTuoiMn
{
    public string Ma { get; set; } = null!;

    public string? MaNhomTre { get; set; }

    public string? Ten { get; set; }

    public DateOnly? NgayTao { get; set; }

    public DateOnly? NgaySua { get; set; }

    public decimal? NguoiTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public string MaSource { get; set; } = null!;
}
