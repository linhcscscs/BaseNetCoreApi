using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class DmDienChinhSach
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public int? IsMn { get; set; }

    public int? IsC1 { get; set; }

    public int? IsC2 { get; set; }

    public int? IsC3 { get; set; }

    public int? IsGdtx { get; set; }

    public string MaSource { get; set; } = null!;
}
