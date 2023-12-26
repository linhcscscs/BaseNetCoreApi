using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class RefreshToken
{
    public decimal Id { get; set; }

    public decimal NguoiDungId { get; set; }

    public DateTime ExpDate { get; set; }

    public string Token { get; set; } = null!;

    public bool Active { get; set; }

    public string MaTinh { get; set; } = null!;

    public string MaHuyen { get; set; } = null!;

    public string MaXa { get; set; } = null!;

    public virtual NguoiDung NguoiDung { get; set; } = null!;
}
