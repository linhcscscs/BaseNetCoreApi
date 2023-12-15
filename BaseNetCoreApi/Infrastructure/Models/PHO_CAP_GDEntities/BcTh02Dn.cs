using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcTh02Dn
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public int? HangTruong { get; set; }

    public decimal? Ngay2Buoi { get; set; }

    public decimal? HieuTruong { get; set; }

    public decimal? PhoHieuTruong { get; set; }

    public decimal? GvTs { get; set; }

    public decimal? GvBc { get; set; }

    public decimal? GvHd { get; set; }

    public decimal? GvNu { get; set; }

    public decimal? GvDt { get; set; }

    public decimal? GvTlgvl { get; set; }

    public decimal? GvTdTrenDh { get; set; }

    public decimal? GvTdDh { get; set; }

    public decimal? GvTdCd { get; set; }

    public decimal? GvTdThsp { get; set; }

    public decimal? GvTdDuoiThsp { get; set; }

    public decimal? GvLhTh { get; set; }

    public decimal? GvLhAn { get; set; }

    public decimal? GvLhMt { get; set; }

    public decimal? GvLhTd { get; set; }

    public decimal? GvLhTinHoc { get; set; }

    public decimal? GvLhNn { get; set; }

    public decimal? GvLhKhac { get; set; }

    public decimal? GvCcnnXx { get; set; }

    public decimal? GvCcnnKha { get; set; }

    public decimal? GvCcnnTb { get; set; }

    public decimal? GvCcnnKem { get; set; }

    public decimal? TptDoi { get; set; }

    public decimal? NvVp { get; set; }

    public decimal? NvTvTbdh { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
