using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BieuMauBaoCao
{
    public long Id { get; set; }

    public string MaBieuMau { get; set; } = null!;

    public string TenBieuMau { get; set; } = null!;

    public string? LoaiBaoCao { get; set; }

    public int ThuTu { get; set; }

    public int TrangThai { get; set; }
}
