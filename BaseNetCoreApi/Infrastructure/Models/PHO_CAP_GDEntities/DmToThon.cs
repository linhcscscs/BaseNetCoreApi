using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class DmToThon
{
    public decimal Id { get; set; }

    public string Ma { get; set; } = null!;

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal? IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal? IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string Ten { get; set; } = null!;

    public int? TrangThai { get; set; }

    public int? ThuTu { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiSua { get; set; }

    public DateTime? NgaySua { get; set; }

    public virtual DmHuyen? IdHuyenNavigation { get; set; }

    public virtual DmTinh MaTinhNavigation { get; set; } = null!;

    public virtual ICollection<NguoiDungToThon> NguoiDungToThons { get; set; } = new List<NguoiDungToThon>();

    public virtual ICollection<PhieuDieuTra> PhieuDieuTras { get; set; } = new List<PhieuDieuTra>();
}
