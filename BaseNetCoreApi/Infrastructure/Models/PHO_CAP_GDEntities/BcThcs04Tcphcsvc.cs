using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThcs04Tcphcsvc
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public decimal? DiemTruong { get; set; }

    public decimal? TsLop { get; set; }

    public decimal? PhKc { get; set; }

    public decimal? PhBanKc { get; set; }

    public decimal? PhTam { get; set; }

    public decimal? TlPhLop { get; set; }

    public decimal? CnHieuTruong { get; set; }

    public decimal? CnPhoHieuTruong { get; set; }

    public decimal? CnVp { get; set; }

    public decimal? CnYt { get; set; }

    public decimal? CnPh { get; set; }

    public decimal? CnTv { get; set; }

    public decimal? CnTnDt { get; set; }

    public decimal? CnTnSl { get; set; }

    public decimal? CtvsGvDt { get; set; }

    public decimal? CtvsGvSl { get; set; }

    public decimal? CtvsHsDt { get; set; }

    public decimal? CtvsHsSl { get; set; }

    public decimal? ScDt { get; set; }

    public decimal? ScSl { get; set; }

    public decimal? BtDt { get; set; }

    public decimal? BtSl { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
