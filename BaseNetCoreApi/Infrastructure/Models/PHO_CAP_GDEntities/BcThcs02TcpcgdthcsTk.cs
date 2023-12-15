using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThcs02TcpcgdthcsTk
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string Ma { get; set; } = null!;

    public decimal? TsTu { get; set; }

    public decimal? TsMau { get; set; }

    public decimal? KhongThuocKkDbkk { get; set; }

    public decimal? ThuocKkDbkk { get; set; }

    public decimal? KqDgPcgdThcs { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
