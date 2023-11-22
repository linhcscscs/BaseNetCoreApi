using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.QUAN_LY_THU_PHIEntities;

public partial class ApiToken
{
    public long Id { get; set; }

    public long IdTaiKhoanGuiTin { get; set; }

    public string TaiKhoan { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string IpAddress { get; set; } = null!;

    public string AuthToken { get; set; } = null!;

    public DateTime ExpiresOn { get; set; }
}
