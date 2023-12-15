using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcTh03Tcphcsvc
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

    public decimal? LopTs { get; set; }

    public decimal? LopGhep { get; set; }

    public decimal? PhongKc { get; set; }

    public decimal? PhongBanKc { get; set; }

    public decimal? PhongTam { get; set; }

    public decimal? PhongThueMuon { get; set; }

    public decimal? PhongTl { get; set; }

    public decimal? PhongCnHt { get; set; }

    public decimal? PhongCnPht { get; set; }

    public decimal? PhongCnVp { get; set; }

    public decimal? PhongCnYt { get; set; }

    public decimal? PhongCnTthdDoi { get; set; }

    public decimal? PhongHopSl { get; set; }

    public decimal? PhongHopDt { get; set; }

    public decimal? PhongTvSl { get; set; }

    public decimal? PhongTvDt { get; set; }

    public decimal? PhongTbSl { get; set; }

    public decimal? PhongTbDt { get; set; }

    public decimal? CtvsGvSl { get; set; }

    public decimal? CtvsGvDt { get; set; }

    public decimal? CtvsHsSl { get; set; }

    public decimal? CtvsHsDt { get; set; }

    public decimal? ScSl { get; set; }

    public decimal? ScDt { get; set; }

    public decimal? BtSl { get; set; }

    public decimal? BtDt { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
