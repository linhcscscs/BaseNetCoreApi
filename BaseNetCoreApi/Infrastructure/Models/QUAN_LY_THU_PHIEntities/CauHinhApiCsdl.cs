using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class CauHinhApiCsdl
{
    public long Id { get; set; }

    public string MaSoGd { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string Url { get; set; } = null!;

    public string? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }
}
