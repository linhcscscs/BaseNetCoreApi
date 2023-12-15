using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThpt02Hqpc
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

    public decimal? Dt1821TnTspc { get; set; }

    public decimal? Dt1821TnTstnThpt { get; set; }

    public decimal? Dt1821TnTstnBt { get; set; }

    public decimal? Dt1821TnTstnThcn { get; set; }

    public decimal? Dt1821TnTl { get; set; }

    public decimal? TnThptVuaQuaL12 { get; set; }

    public decimal? TnThptVuaQuaTn { get; set; }

    public decimal? TnThptVuaQuaTlThpt { get; set; }

    public decimal? TnThptVuaQuaL12Gdtx { get; set; }

    public decimal? TnThptVuaQuaTnGdtx { get; set; }

    public decimal? TnThptVuaQuaTlGdtx { get; set; }

    public decimal? Dt1821CoBangTsHoc3n { get; set; }

    public decimal? Dt1821CoBangTs { get; set; }

    public decimal? Dt1821CoBangTl { get; set; }

    public decimal? DanhGia { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
