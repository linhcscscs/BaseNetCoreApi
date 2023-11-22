using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class XemThongBao
{
    public long Id { get; set; }

    public long IdThongBaoDieuHanh { get; set; }

    public string? MaSoGd { get; set; }

    public string? MaPhongGd { get; set; }

    public string? MaTruong { get; set; }

    public decimal IdNguoiDung { get; set; }

    public DateTime ThoiGianXem { get; set; }
}
