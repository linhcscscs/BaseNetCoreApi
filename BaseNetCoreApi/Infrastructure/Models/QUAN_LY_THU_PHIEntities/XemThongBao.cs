using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

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
