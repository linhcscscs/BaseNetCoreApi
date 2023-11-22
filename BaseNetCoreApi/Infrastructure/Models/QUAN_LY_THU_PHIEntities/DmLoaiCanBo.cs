using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class DmLoaiCanBo
{
    public string Ma { get; set; } = null!;

    public string MaNhomCanBo { get; set; } = null!;

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

    public int? IsPhong { get; set; }

    public int? IsSo { get; set; }

    public int? IsBo { get; set; }

    public string MaSource { get; set; } = null!;
}
