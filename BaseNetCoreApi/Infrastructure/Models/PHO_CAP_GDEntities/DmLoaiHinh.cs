using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class DmLoaiHinh
{
    public decimal Id { get; set; }

    public string Ma { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? IsMn { get; set; }

    public int? IsC1 { get; set; }

    public int? IsC2 { get; set; }

    public int? IsC3 { get; set; }

    public int? IsGdtx { get; set; }

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public int? MaNamHoc { get; set; }

    public decimal IdSource { get; set; }
}
