using System;
using System.Collections.Generic;

namespace BaseNetCoreApi.Models.PHO_CAP_GDEntities;

public partial class BcThcs03Dn
{
    public long Id { get; set; }

    public int MaNamHoc { get; set; }

    public string MaTinh { get; set; } = null!;

    public decimal IdHuyen { get; set; }

    public string MaHuyen { get; set; } = null!;

    public decimal IdXa { get; set; }

    public string MaXa { get; set; } = null!;

    public string MaTruong { get; set; } = null!;

    public int? HangTruong { get; set; }

    public decimal? HieuTruong { get; set; }

    public decimal? PhoHieuTruong { get; set; }

    public decimal? GvTs { get; set; }

    public decimal? GvBc { get; set; }

    public decimal? GvHd { get; set; }

    public decimal? GvNu { get; set; }

    public decimal? GvDt { get; set; }

    public decimal? GvTllop { get; set; }

    public decimal? GvTdTrenDh { get; set; }

    public decimal? GvTdDh { get; set; }

    public decimal? GvTdCd { get; set; }

    public decimal? GvTdThsp { get; set; }

    public decimal? GvCnToan { get; set; }

    public decimal? GvCnNguVan { get; set; }

    public decimal? GvCnKhtnLy { get; set; }

    public decimal? GvCnKhtnHoa { get; set; }

    public decimal? GvCnKhtnSinh { get; set; }

    public decimal? GvCnKhxhSu { get; set; }

    public decimal? GvCnKhxhDia { get; set; }

    public decimal? GvCnHdgdNhac { get; set; }

    public decimal? GvCnHdgdMt { get; set; }

    public decimal? GvCnHdgdTd { get; set; }

    public decimal? GvCnGdcd { get; set; }

    public decimal? GvCnCongNghe { get; set; }

    public decimal? GvCnTinHoc { get; set; }

    public decimal? GvCnNnAnh { get; set; }

    public decimal? GvCnNnNga { get; set; }

    public decimal? GvCnNnPhap { get; set; }

    public decimal? GvCnNnKhac { get; set; }

    public decimal? GvTptd { get; set; }

    public decimal? GvCnnXx { get; set; }

    public decimal? GvCnnKha { get; set; }

    public decimal? GvCnnTb { get; set; }

    public decimal? GvCnnKem { get; set; }

    public decimal? NvTv { get; set; }

    public decimal? NvTb { get; set; }

    public decimal? NvVp { get; set; }

    public decimal? NvYt { get; set; }

    public DateTime? NgayTao { get; set; }

    public decimal? NguoiTao { get; set; }

    public DateTime? NgaySua { get; set; }

    public decimal? NguoiSua { get; set; }
}
