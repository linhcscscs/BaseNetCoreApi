using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class PhanQuyenApi
{
    public long Id { get; set; }

    public long IdTaiKhoanGuiTin { get; set; }

    public long IdApi { get; set; }

    public int TrangThai { get; set; }

    public DateTime? NgayTao { get; set; }

    public string? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public string? NguoiSua { get; set; }
}
