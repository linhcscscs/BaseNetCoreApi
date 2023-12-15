using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcMn02Dn
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public decimal? TongSo { get; set; }

    public decimal? HdLv { get; set; }

    public decimal? CbgvnvHdTs { get; set; }

    public decimal? CbgvnvHdDhqd { get; set; }

    public decimal? CbgvnvCbqlTs { get; set; }

    public decimal? CbgvnvCbqlPht { get; set; }

    public decimal? CbgvnvGvTs { get; set; }

    public decimal? CbgvnvGvDtts { get; set; }

    public decimal? CbgvnvGvTlgvl { get; set; }

    public decimal? CbgvnvNv { get; set; }

    public decimal? Gvmn5tTs { get; set; }

    public decimal? Gvmn5tHdlv { get; set; }

    public decimal? Gvmn5tHdldTs { get; set; }

    public decimal? Gvmn5tHdldDhqd { get; set; }

    public decimal? Gvmn5tTlgvl { get; set; }

    public decimal? Gvmn5tTddtDc { get; set; }

    public decimal? Gvmn5tTddtTc { get; set; }

    public decimal? Gvmn5tGcnn { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
