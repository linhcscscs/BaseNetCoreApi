using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThpt01Hdpc
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? IdToThon { get; set; }

    public decimal? TongSo { get; set; }

    public decimal? Dt1518TnThcsTspc { get; set; }

    public decimal? Dt1518TnThcsTstn { get; set; }

    public decimal? Dt1518TnThcsTl { get; set; }

    public decimal? Dt1518TnThcsConHoc { get; set; }

    public decimal? Dt1518TnThcsBoHoc { get; set; }

    public decimal? TnThcsVuaQuaL9 { get; set; }

    public decimal? TnThcsVuaQuaTn { get; set; }

    public decimal? TnThcsVuaQuaTl { get; set; }

    public decimal? Dt1518dnThpt { get; set; }

    public decimal? Dt1518dnGdtx { get; set; }

    public decimal? Dt1518dnTccn { get; set; }

    public decimal? Dt1518dnDn { get; set; }

    public decimal? Dt1518dnTlVaoThcn { get; set; }

    public decimal? Dt1518dnTlVaoTdn { get; set; }

    public decimal? Dt1518dnTl { get; set; }

    public decimal? DanhGia { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
