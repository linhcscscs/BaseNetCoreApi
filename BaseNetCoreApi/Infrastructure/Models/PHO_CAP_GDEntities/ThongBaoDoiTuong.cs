using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class ThongBaoDoiTuong
{
    public long Id { get; set; }

    public long IdThongBaoDieuHanh { get; set; }

    public string? MaTinh { get; set; }

    public string? MaHuyen { get; set; }

    public string? MaXa { get; set; }
}
