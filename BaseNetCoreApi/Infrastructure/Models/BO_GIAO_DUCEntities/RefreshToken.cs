using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.BO_GIAO_DUCEntities;

public partial class RefreshToken
{
    public decimal Id { get; set; }

    public decimal NguoiDungId { get; set; }

    public DateTime ExpDate { get; set; }

    public string Token { get; set; } = null!;

    public bool Active { get; set; }

    public virtual NguoiDung NguoiDung { get; set; } = null!;
}
