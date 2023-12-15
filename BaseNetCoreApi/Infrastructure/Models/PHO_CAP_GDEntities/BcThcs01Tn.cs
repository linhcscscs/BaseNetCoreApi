using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThcs01Tn
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? IdToThon { get; set; }

    public string Ma { get; set; } = null!;

    public decimal? T11 { get; set; }

    public decimal? T12 { get; set; }

    public decimal? T13 { get; set; }

    public decimal? T14 { get; set; }

    public decimal? T15 { get; set; }

    public decimal? T16 { get; set; }

    public decimal? T17 { get; set; }

    public decimal? T18 { get; set; }

    public decimal? T11Pt { get; set; }

    public decimal? T11Tx { get; set; }

    public decimal? T12Pt { get; set; }

    public decimal? T12Tx { get; set; }

    public decimal? T13Pt { get; set; }

    public decimal? T13Tx { get; set; }

    public decimal? T14Pt { get; set; }

    public decimal? T14Tx { get; set; }

    public decimal? T15Pt { get; set; }

    public decimal? T15Tx { get; set; }

    public decimal? T15Gdnn { get; set; }

    public decimal? T16Pt { get; set; }

    public decimal? T16Tx { get; set; }

    public decimal? T16Gdnn { get; set; }

    public decimal? T17Pt { get; set; }

    public decimal? T17Tx { get; set; }

    public decimal? T17Gdnn { get; set; }

    public decimal? T18Pt { get; set; }

    public decimal? T18Tx { get; set; }

    public decimal? T18Gdnn { get; set; }

    public decimal? Tong { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
