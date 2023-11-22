using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class DmLoaiTruong
{
    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? ThuTu { get; set; }

    public int? IsMamNon { get; set; }

    public int? IsC1 { get; set; }

    public int? IsC2 { get; set; }

    public int? IsC3 { get; set; }

    public int? IsGdtx { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public string MaSource { get; set; } = null!;
}
