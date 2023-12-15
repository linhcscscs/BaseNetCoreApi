using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcTh05Tktdvh
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public decimal? IdToThon { get; set; }

    public int NamSinh { get; set; }

    public int DoTuoi { get; set; }

    public decimal? TongSo { get; set; }

    public decimal? DanToc { get; set; }

    public decimal? Nu { get; set; }

    public decimal? KhuyetTat { get; set; }

    public decimal? TdvhdhTs { get; set; }

    public decimal? TdvhdhMg { get; set; }

    public decimal? TdvhdhL1 { get; set; }

    public decimal? TdvhdhL2 { get; set; }

    public decimal? TdvhdhL3 { get; set; }

    public decimal? TdvhdhL4 { get; set; }

    public decimal? TdvhdhL5 { get; set; }

    public decimal? TdvhdhL6 { get; set; }

    public decimal? TdvhdhL7 { get; set; }

    public decimal? TdvhdhL8 { get; set; }

    public decimal? TdvhdhL9 { get; set; }

    public decimal? TdvhdhTnthTroLen { get; set; }

    public decimal? TdvhdhTnthcsTroLen { get; set; }

    public decimal? CdhbhlTs { get; set; }

    public decimal? CdhbhlChuaDh { get; set; }

    public decimal? CdhbhlL1 { get; set; }

    public decimal? CdhbhlL2 { get; set; }

    public decimal? CdhbhlL3 { get; set; }

    public decimal? CdhbhlL4 { get; set; }

    public decimal? CdhbhlL5 { get; set; }

    public decimal? CdhbhlL6 { get; set; }

    public decimal? CdhbhlL7 { get; set; }

    public decimal? CdhbhlL8 { get; set; }

    public decimal? CdhbhlL9 { get; set; }

    public decimal? CdhbhlTnthTroLen { get; set; }

    public decimal? CdhbhlTnthcsTroLen { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
