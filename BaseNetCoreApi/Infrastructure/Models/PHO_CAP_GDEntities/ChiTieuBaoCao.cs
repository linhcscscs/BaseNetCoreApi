using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class ChiTieuBaoCao
{
    public long Id { get; set; }

    public string Ma { get; set; } = null!;

    public string? NoiDungCha2 { get; set; }

    public string? NoiDungCha1 { get; set; }

    public string? NoiDungCha { get; set; }

    public string NoiDung { get; set; } = null!;

    public int? RowMerge { get; set; }

    public int? ColMerge { get; set; }

    public string? DonVi { get; set; }

    public string ThuTu { get; set; } = null!;

    public string MaBieuMau { get; set; } = null!;

    public int MaNamHoc { get; set; }
}
