using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThpt03TtCsdn
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? ThTs { get; set; }

    public decimal? ThDcqg { get; set; }

    public decimal? ThTl { get; set; }

    public decimal? ThcsTs { get; set; }

    public decimal? ThcsThcsTs { get; set; }

    public decimal? ThcsThcsDcqg { get; set; }

    public decimal? ThcsThcsTl { get; set; }

    public decimal? ThcsNcTs { get; set; }

    public decimal? ThcsNcDcqg { get; set; }

    public decimal? ThcsNcTl { get; set; }

    public decimal? ThptTs { get; set; }

    public decimal? ThptThptTs { get; set; }

    public decimal? ThptThptDcqg { get; set; }

    public decimal? ThptThptTl { get; set; }

    public decimal? ThptNcTs { get; set; }

    public decimal? ThptNcDcqg { get; set; }

    public decimal? ThptNcTl { get; set; }

    public decimal? TtgdtxTtktth { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
