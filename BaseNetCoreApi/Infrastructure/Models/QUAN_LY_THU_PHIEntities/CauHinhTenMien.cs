using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class CauHinhTenMien
{
    public long Id { get; set; }

    public string? TenMien { get; set; }

    public string? MaCapDonVi { get; set; }

    public string? MaDonVi { get; set; }

    public string? Logo { get; set; }

    public string? TenDonVi { get; set; }

    public string? TenPhanMem { get; set; }

    public string? AnhDangNhap1 { get; set; }

    public string? AnhDangNhap2 { get; set; }

    public string? AnhDangNhap3 { get; set; }

    public string? HotLine { get; set; }

    public string? Email { get; set; }
}
