using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class CapMaBienLai
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaSoGd { get; set; } = null!;

    public string MaCapHoc { get; set; } = null!;

    public decimal IdTruong { get; set; }

    public string MaTruong { get; set; } = null!;

    public long IdLstt { get; set; }

    public decimal IdHocSinh { get; set; }

    public string MaHocSinh { get; set; } = null!;

    public string SoBienLai { get; set; } = null!;

    public long SttBienLai { get; set; }
}
