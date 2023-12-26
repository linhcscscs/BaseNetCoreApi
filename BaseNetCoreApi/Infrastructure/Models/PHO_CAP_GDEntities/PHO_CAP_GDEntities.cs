using System;
using System.Collections.Generic;
using BaseNetCoreApi.Models.PHO_CAP_GDEntities;
using Microsoft.EntityFrameworkCore;

namespace BaseNetCoreApi.Infrastructure.Models.PHO_CAP_GDEntities;

public partial class PHO_CAP_GDEntities : DbContext
{
    public PHO_CAP_GDEntities()
    {
    }

    public PHO_CAP_GDEntities(DbContextOptions<PHO_CAP_GDEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<BcMn01Te> BcMn01Tes { get; set; }

    public virtual DbSet<BcMn01TeTh> BcMn01TeThs { get; set; }

    public virtual DbSet<BcMn02Dn> BcMn02Dns { get; set; }

    public virtual DbSet<BcMn03Tcphcsvc> BcMn03Tcphcsvcs { get; set; }

    public virtual DbSet<BcMn04Bctc> BcMn04Bctcs { get; set; }

    public virtual DbSet<BcMn05Dtkt> BcMn05Dtkts { get; set; }

    public virtual DbSet<BcTh01Te> BcTh01Tes { get; set; }

    public virtual DbSet<BcTh01TeTh> BcTh01TeThs { get; set; }

    public virtual DbSet<BcTh02Dn> BcTh02Dns { get; set; }

    public virtual DbSet<BcTh02DnTh> BcTh02DnThs { get; set; }

    public virtual DbSet<BcTh03Tcphcsvc> BcTh03Tcphcsvcs { get; set; }

    public virtual DbSet<BcTh04Dtkt> BcTh04Dtkts { get; set; }

    public virtual DbSet<BcTh05Tktdvh> BcTh05Tktdvhs { get; set; }

    public virtual DbSet<BcTh06HsTraiTuyenTaiTruong> BcTh06HsTraiTuyenTaiTruongs { get; set; }

    public virtual DbSet<BcTh07HsHocTaiTruongTraiTuyen> BcTh07HsHocTaiTruongTraiTuyens { get; set; }

    public virtual DbSet<BcThcs01Tn> BcThcs01Tns { get; set; }

    public virtual DbSet<BcThcs01TnTh> BcThcs01TnThs { get; set; }

    public virtual DbSet<BcThcs02Tcpcgdthc> BcThcs02Tcpcgdthcs { get; set; }

    public virtual DbSet<BcThcs02TcpcgdthcsTk> BcThcs02TcpcgdthcsTks { get; set; }

    public virtual DbSet<BcThcs03Dn> BcThcs03Dns { get; set; }

    public virtual DbSet<BcThcs03DnTh> BcThcs03DnThs { get; set; }

    public virtual DbSet<BcThcs04Tcphcsvc> BcThcs04Tcphcsvcs { get; set; }

    public virtual DbSet<BcThcs05Kqpcgdth> BcThcs05Kqpcgdths { get; set; }

    public virtual DbSet<BcThcs05KqpcgdthTh> BcThcs05KqpcgdthThs { get; set; }

    public virtual DbSet<BcThcs06Dtkt> BcThcs06Dtkts { get; set; }

    public virtual DbSet<BcThcs07HsTraiTuyenTaiTruong> BcThcs07HsTraiTuyenTaiTruongs { get; set; }

    public virtual DbSet<BcThcs08HsHocTaiTruongTraiTuyen> BcThcs08HsHocTaiTruongTraiTuyens { get; set; }

    public virtual DbSet<BcThpt01Hdpc> BcThpt01Hdpcs { get; set; }

    public virtual DbSet<BcThpt02Hqpc> BcThpt02Hqpcs { get; set; }

    public virtual DbSet<BcThpt03TtCsdn> BcThpt03TtCsdns { get; set; }

    public virtual DbSet<BcXmc01Thxmc> BcXmc01Thxmcs { get; set; }

    public virtual DbSet<BcXmc02Thkqxmc> BcXmc02Thkqxmcs { get; set; }

    public virtual DbSet<BcXmc03Tknmcdt> BcXmc03Tknmcdts { get; set; }

    public virtual DbSet<BcXmc04TkhtMuc1> BcXmc04TkhtMuc1s { get; set; }

    public virtual DbSet<BcXmc05TkhtMuc2> BcXmc05TkhtMuc2s { get; set; }

    public virtual DbSet<BcXmc06TkkqHmcMuc1> BcXmc06TkkqHmcMuc1s { get; set; }

    public virtual DbSet<BcXmc07TkkqHmcMuc2> BcXmc07TkkqHmcMuc2s { get; set; }

    public virtual DbSet<BcXmc08Tkkqxmc> BcXmc08Tkkqxmcs { get; set; }

    public virtual DbSet<BieuMauBaoCao> BieuMauBaoCaos { get; set; }

    public virtual DbSet<CauHinhApiCsdl> CauHinhApiCsdls { get; set; }

    public virtual DbSet<ChiTieuBaoCao> ChiTieuBaoCaos { get; set; }

    public virtual DbSet<DmBacTotNghiepNghe> DmBacTotNghiepNghes { get; set; }

    public virtual DbSet<DmBacTotNghiepPhoThong> DmBacTotNghiepPhoThongs { get; set; }

    public virtual DbSet<DmBoHocLop> DmBoHocLops { get; set; }

    public virtual DbSet<DmCapDonVi> DmCapDonVis { get; set; }

    public virtual DbSet<DmCapDonViHc> DmCapDonViHcs { get; set; }

    public virtual DbSet<DmCapHoc> DmCapHocs { get; set; }

    public virtual DbSet<DmDanToc> DmDanTocs { get; set; }

    public virtual DbSet<DmDienChinhSach> DmDienChinhSaches { get; set; }

    public virtual DbSet<DmDienCuTru> DmDienCuTrus { get; set; }

    public virtual DbSet<DmGioiTinh> DmGioiTinhs { get; set; }

    public virtual DbSet<DmHoanCanhDacBiet> DmHoanCanhDacBiets { get; set; }

    public virtual DbSet<DmHoanThanhXoaMuChuLop> DmHoanThanhXoaMuChuLops { get; set; }

    public virtual DbSet<DmHocXoaMuChuLop> DmHocXoaMuChuLops { get; set; }

    public virtual DbSet<DmHocXongLop> DmHocXongLops { get; set; }

    public virtual DbSet<DmHuyen> DmHuyens { get; set; }

    public virtual DbSet<DmKhoi> DmKhois { get; set; }

    public virtual DbSet<DmKhuVuc> DmKhuVucs { get; set; }

    public virtual DbSet<DmKieuLop> DmKieuLops { get; set; }

    public virtual DbSet<DmLoaiCanBo> DmLoaiCanBos { get; set; }

    public virtual DbSet<DmLoaiHinh> DmLoaiHinhs { get; set; }

    public virtual DbSet<DmLoaiKhuyetTat> DmLoaiKhuyetTats { get; set; }

    public virtual DbSet<DmLoaiTruong> DmLoaiTruongs { get; set; }

    public virtual DbSet<DmMucDatChuanQgClgd> DmMucDatChuanQgClgds { get; set; }

    public virtual DbSet<DmMucTaiMuChu> DmMucTaiMuChus { get; set; }

    public virtual DbSet<DmNhomCanBo> DmNhomCanBos { get; set; }

    public virtual DbSet<DmNhomTuoiMn> DmNhomTuoiMns { get; set; }

    public virtual DbSet<DmNuoc> DmNuocs { get; set; }

    public virtual DbSet<DmPhanBan> DmPhanBans { get; set; }

    public virtual DbSet<DmSoBuoiHocTrenTuan> DmSoBuoiHocTrenTuans { get; set; }

    public virtual DbSet<DmSucKhoeNuoiDuong> DmSucKhoeNuoiDuongs { get; set; }

    public virtual DbSet<DmTinh> DmTinhs { get; set; }

    public virtual DbSet<DmTinhTrangCuTru> DmTinhTrangCuTrus { get; set; }

    public virtual DbSet<DmToThon> DmToThons { get; set; }

    public virtual DbSet<DmTonGiao> DmTonGiaos { get; set; }

    public virtual DbSet<DmTrangThaiHocSinh> DmTrangThaiHocSinhs { get; set; }

    public virtual DbSet<DmXa> DmXas { get; set; }

    public virtual DbSet<GroupUser> GroupUsers { get; set; }

    public virtual DbSet<GroupUserMenu> GroupUserMenus { get; set; }

    public virtual DbSet<HocSinh> HocSinhs { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<NamHoc> NamHocs { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NguoiDungToThon> NguoiDungToThons { get; set; }

    public virtual DbSet<NhanSu> NhanSus { get; set; }

    public virtual DbSet<NhanSuLopChuNhiem> NhanSuLopChuNhiems { get; set; }

    public virtual DbSet<PhieuDieuTra> PhieuDieuTras { get; set; }

    public virtual DbSet<PhieuDieuTraCt> PhieuDieuTraCts { get; set; }

    public virtual DbSet<PhieuDieuTraTraiTuyen> PhieuDieuTraTraiTuyens { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    public virtual DbSet<PhongGd> PhongGds { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<SoGd> SoGds { get; set; }

    public virtual DbSet<ThongBaoDieuHanh> ThongBaoDieuHanhs { get; set; }

    public virtual DbSet<ThongBaoDoiTuong> ThongBaoDoiTuongs { get; set; }

    public virtual DbSet<Truong> Truongs { get; set; }

    public virtual DbSet<XemThongBao> XemThongBaos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=42.112.27.32,21433;initial catalog=PHO_CAP_GD;user id=sa;password=QIG@104;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BcMn01Te>(entity =>
        {
            entity.ToTable("BC_MN_01_TE");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.T0)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_0");
            entity.Property(e => e.T1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_1");
            entity.Property(e => e.T2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_2");
            entity.Property(e => e.T3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_3");
            entity.Property(e => e.T4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_4");
            entity.Property(e => e.T5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_5");
            entity.Property(e => e.T6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_6");
            entity.Property(e => e.Tong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG");
        });

        modelBuilder.Entity<BcMn01TeTh>(entity =>
        {
            entity.ToTable("BC_MN_01_TE_TH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SL");
            entity.Property(e => e.Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL");
        });

        modelBuilder.Entity<BcMn02Dn>(entity =>
        {
            entity.ToTable("BC_MN_02_DN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruong }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CbgvnvCbqlPht)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_CBQL_PHT");
            entity.Property(e => e.CbgvnvCbqlTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_CBQL_TS");
            entity.Property(e => e.CbgvnvGvDtts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_GV_DTTS");
            entity.Property(e => e.CbgvnvGvTlgvl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_GV_TLGVL");
            entity.Property(e => e.CbgvnvGvTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_GV_TS");
            entity.Property(e => e.CbgvnvHdDhqd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_HD_DHQD");
            entity.Property(e => e.CbgvnvHdTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_HD_TS");
            entity.Property(e => e.CbgvnvNv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CBGVNV_NV");
            entity.Property(e => e.Gvmn5tGcnn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_GCNN");
            entity.Property(e => e.Gvmn5tHdldDhqd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_HDLD_DHQD");
            entity.Property(e => e.Gvmn5tHdldTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_HDLD_TS");
            entity.Property(e => e.Gvmn5tHdlv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_HDLV");
            entity.Property(e => e.Gvmn5tTddtDc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_TDDT_DC");
            entity.Property(e => e.Gvmn5tTddtTc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_TDDT_TC");
            entity.Property(e => e.Gvmn5tTlgvl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_TLGVL");
            entity.Property(e => e.Gvmn5tTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GVMN5T_TS");
            entity.Property(e => e.HdLv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_LV");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
        });

        modelBuilder.Entity<BcMn03Tcphcsvc>(entity =>
        {
            entity.ToTable("BC_MN_03_TCPHCSVC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruong }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BepAn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BEP_AN");
            entity.Property(e => e.CtNuocSach)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_NUOC_SACH");
            entity.Property(e => e.DiemTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIEM_TRUONG");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Lop5t2bngay)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP_5T_2BNGAY");
            entity.Property(e => e.Lop5tLg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP_5T_LG");
            entity.Property(e => e.Lop5tTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP_5T_TS");
            entity.Property(e => e.LopDuoi5t)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP_DUOI_5T");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Phong5tBkcShc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_BKC_SHC");
            entity.Property(e => e.Phong5tBkcTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_BKC_TS");
            entity.Property(e => e.Phong5tDutb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_DUTB");
            entity.Property(e => e.Phong5tKcShc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_KC_SHC");
            entity.Property(e => e.Phong5tKcTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_KC_TS");
            entity.Property(e => e.Phong5tTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_TL");
            entity.Property(e => e.Phong5tTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_TS");
            entity.Property(e => e.Phong5tTtShc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_TT_SHC");
            entity.Property(e => e.Phong5tTtTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_5T_TT_TS");
            entity.Property(e => e.PhongVs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_VS");
            entity.Property(e => e.SanChoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SAN_CHOI");
            entity.Property(e => e.SanChoiDc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SAN_CHOI_DC");
            entity.Property(e => e.TongSoPhongHoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO_PHONG_HOC");
        });

        modelBuilder.Entity<BcMn04Bctc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BC_MN_05_BCTC");

            entity.ToTable("BC_MN_04_BCTC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.N1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("N_1");
            entity.Property(e => e.N2)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("N_2");
            entity.Property(e => e.N3)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("N_3");
            entity.Property(e => e.N4)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("N_4");
            entity.Property(e => e.N5)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("N_5");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("TONG_SO");
        });

        modelBuilder.Entity<BcMn05Dtkt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BC_MN_06_DTKT");

            entity.ToTable("BC_MN_05_DTKT");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.NamSinh, e.DoTuoi, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CtHt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_HT");
            entity.Property(e => e.CtKhac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_KHAC");
            entity.Property(e => e.CtNgheNoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_NGHE_NOI");
            entity.Property(e => e.CtNhin)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_NHIN");
            entity.Property(e => e.CtRlptk)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_RLPTK");
            entity.Property(e => e.CtTktt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_TKTT");
            entity.Property(e => e.CtTt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CT_TT");
            entity.Property(e => e.DoTuoi).HasColumnName("DO_TUOI");
            entity.Property(e => e.HsktTcGdTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HSKT_TC_GD_TL");
            entity.Property(e => e.HsktTcGdTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HSKT_TC_GD_TS");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NamSinh).HasColumnName("NAM_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
            entity.Property(e => e.VanDong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAN_DONG");
        });

        modelBuilder.Entity<BcTh01Te>(entity =>
        {
            entity.ToTable("BC_TH_01_TE");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.T10)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_10");
            entity.Property(e => e.T11)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_11");
            entity.Property(e => e.T12)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_12");
            entity.Property(e => e.T13)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_13");
            entity.Property(e => e.T14)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_14");
            entity.Property(e => e.T6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_6");
            entity.Property(e => e.T7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_7");
            entity.Property(e => e.T8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_8");
            entity.Property(e => e.T9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_9");
            entity.Property(e => e.Tong1114)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_11_14");
            entity.Property(e => e.Tong610)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_6_10");
        });

        modelBuilder.Entity<BcTh01TeTh>(entity =>
        {
            entity.ToTable("BC_TH_01_TE_TH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SL");
            entity.Property(e => e.Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL");
        });

        modelBuilder.Entity<BcTh02Dn>(entity =>
        {
            entity.ToTable("BC_TH_02_DN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruong }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GvBc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_BC");
            entity.Property(e => e.GvCcnnKem)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CCNN_KEM");
            entity.Property(e => e.GvCcnnKha)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CCNN_KHA");
            entity.Property(e => e.GvCcnnTb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CCNN_TB");
            entity.Property(e => e.GvCcnnXx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CCNN_XX");
            entity.Property(e => e.GvDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_DT");
            entity.Property(e => e.GvHd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_HD");
            entity.Property(e => e.GvLhAn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_LH_AN");
            entity.Property(e => e.GvLhKhac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_LH_KHAC");
            entity.Property(e => e.GvLhMt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_LH_MT");
            entity.Property(e => e.GvLhNn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_LH_NN");
            entity.Property(e => e.GvLhTd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_LH_TD");
            entity.Property(e => e.GvLhTh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_LH_TH");
            entity.Property(e => e.GvLhTinHoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_LH_TIN_HOC");
            entity.Property(e => e.GvNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_NU");
            entity.Property(e => e.GvTdCd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_CD");
            entity.Property(e => e.GvTdDh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_DH");
            entity.Property(e => e.GvTdDuoiThsp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_DUOI_THSP");
            entity.Property(e => e.GvTdThsp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_THSP");
            entity.Property(e => e.GvTdTrenDh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_TREN_DH");
            entity.Property(e => e.GvTlgvl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TLGVL");
            entity.Property(e => e.GvTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TS");
            entity.Property(e => e.HangTruong).HasColumnName("HANG_TRUONG");
            entity.Property(e => e.HieuTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HIEU_TRUONG");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.Ngay2Buoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NGAY_2_BUOI");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.NvTvTbdh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NV_TV_TBDH");
            entity.Property(e => e.NvVp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NV_VP");
            entity.Property(e => e.PhoHieuTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHO_HIEU_TRUONG");
            entity.Property(e => e.TptDoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPT_DOI");
        });

        modelBuilder.Entity<BcTh02DnTh>(entity =>
        {
            entity.ToTable("BC_TH_02_DN_TH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SL");
            entity.Property(e => e.Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL");
        });

        modelBuilder.Entity<BcTh03Tcphcsvc>(entity =>
        {
            entity.ToTable("BC_TH_03_TCPHCSVC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruong }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BtDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BT_DT");
            entity.Property(e => e.BtSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BT_SL");
            entity.Property(e => e.CtvsGvDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_GV_DT");
            entity.Property(e => e.CtvsGvSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_GV_SL");
            entity.Property(e => e.CtvsHsDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_HS_DT");
            entity.Property(e => e.CtvsHsSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_HS_SL");
            entity.Property(e => e.DiemTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIEM_TRUONG");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.LopGhep)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP_GHEP");
            entity.Property(e => e.LopTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LOP_TS");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.PhongBanKc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_BAN_KC");
            entity.Property(e => e.PhongCnHt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_CN_HT");
            entity.Property(e => e.PhongCnPht)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_CN_PHT");
            entity.Property(e => e.PhongCnTthdDoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_CN_TTHD_DOI");
            entity.Property(e => e.PhongCnVp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_CN_VP");
            entity.Property(e => e.PhongCnYt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_CN_YT");
            entity.Property(e => e.PhongHopDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_HOP_DT");
            entity.Property(e => e.PhongHopSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_HOP_SL");
            entity.Property(e => e.PhongKc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_KC");
            entity.Property(e => e.PhongTam)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_TAM");
            entity.Property(e => e.PhongTbDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_TB_DT");
            entity.Property(e => e.PhongTbSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_TB_SL");
            entity.Property(e => e.PhongThueMuon)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_THUE_MUON");
            entity.Property(e => e.PhongTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_TL");
            entity.Property(e => e.PhongTvDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_TV_DT");
            entity.Property(e => e.PhongTvSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHONG_TV_SL");
            entity.Property(e => e.ScDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SC_DT");
            entity.Property(e => e.ScSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SC_SL");
        });

        modelBuilder.Entity<BcTh04Dtkt>(entity =>
        {
            entity.ToTable("BC_TH_04_DTKT");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.NamSinh, e.DoTuoi, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoTuoi).HasColumnName("DO_TUOI");
            entity.Property(e => e.HocTap)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HOC_TAP");
            entity.Property(e => e.HsktTcGdTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HSKT_TC_GD_TL");
            entity.Property(e => e.HsktTcGdTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HSKT_TC_GD_TS");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Khac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KHAC");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NamSinh).HasColumnName("NAM_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NgheNoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NGHE_NOI");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Nhin)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NHIN");
            entity.Property(e => e.Rlptk)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RLPTK");
            entity.Property(e => e.Tktt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TKTT");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
            entity.Property(e => e.TriTue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TRI_TUE");
            entity.Property(e => e.VanDong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAN_DONG");
        });

        modelBuilder.Entity<BcTh05Tktdvh>(entity =>
        {
            entity.ToTable("BC_TH_05_TKTDVH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.NamSinh, e.DoTuoi, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CdhbhlChuaDh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_CHUA_DH");
            entity.Property(e => e.CdhbhlL1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L1");
            entity.Property(e => e.CdhbhlL2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L2");
            entity.Property(e => e.CdhbhlL3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L3");
            entity.Property(e => e.CdhbhlL4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L4");
            entity.Property(e => e.CdhbhlL5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L5");
            entity.Property(e => e.CdhbhlL6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L6");
            entity.Property(e => e.CdhbhlL7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L7");
            entity.Property(e => e.CdhbhlL8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L8");
            entity.Property(e => e.CdhbhlL9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_L9");
            entity.Property(e => e.CdhbhlTnthTroLen)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_TNTH_TRO_LEN");
            entity.Property(e => e.CdhbhlTnthcsTroLen)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_TNTHCS_TRO_LEN");
            entity.Property(e => e.CdhbhlTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CDHBHL_TS");
            entity.Property(e => e.DanToc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DAN_TOC");
            entity.Property(e => e.DoTuoi).HasColumnName("DO_TUOI");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.KhuyetTat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KHUYET_TAT");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NamSinh).HasColumnName("NAM_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NU");
            entity.Property(e => e.TdvhdhL1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L1");
            entity.Property(e => e.TdvhdhL2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L2");
            entity.Property(e => e.TdvhdhL3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L3");
            entity.Property(e => e.TdvhdhL4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L4");
            entity.Property(e => e.TdvhdhL5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L5");
            entity.Property(e => e.TdvhdhL6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L6");
            entity.Property(e => e.TdvhdhL7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L7");
            entity.Property(e => e.TdvhdhL8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L8");
            entity.Property(e => e.TdvhdhL9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_L9");
            entity.Property(e => e.TdvhdhMg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_MG");
            entity.Property(e => e.TdvhdhTnthTroLen)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_TNTH_TRO_LEN");
            entity.Property(e => e.TdvhdhTnthcsTroLen)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_TNTHCS_TRO_LEN");
            entity.Property(e => e.TdvhdhTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TDVHDH_TS");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
        });

        modelBuilder.Entity<BcTh06HsTraiTuyenTaiTruong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BC_TH_05_");

            entity.ToTable("BC_TH_06_HS_TRAI_TUYEN_TAI_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTinhDiaChi, e.IdHuyenDiaChi, e.MaHuyenDiaChi, e.IdXaDiaChi, e.MaXaDiaChi, e.MaTruong }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdHuyenDiaChi)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN_DIA_CHI");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.IdXaDiaChi)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA_DIA_CHI");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaHuyenDiaChi)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN_DIA_CHI");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTinhDiaChi)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH_DIA_CHI");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.MaXaDiaChi)
                .HasMaxLength(50)
                .HasColumnName("MA_XA_DIA_CHI");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Tong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG");
            entity.Property(e => e.Tuoi10L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L1");
            entity.Property(e => e.Tuoi10L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L2");
            entity.Property(e => e.Tuoi10L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L3");
            entity.Property(e => e.Tuoi10L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L4");
            entity.Property(e => e.Tuoi10L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L5");
            entity.Property(e => e.Tuoi11L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L1");
            entity.Property(e => e.Tuoi11L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L2");
            entity.Property(e => e.Tuoi11L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L3");
            entity.Property(e => e.Tuoi11L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L4");
            entity.Property(e => e.Tuoi11L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L5");
            entity.Property(e => e.Tuoi12L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L1");
            entity.Property(e => e.Tuoi12L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L2");
            entity.Property(e => e.Tuoi12L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L3");
            entity.Property(e => e.Tuoi12L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L4");
            entity.Property(e => e.Tuoi12L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L5");
            entity.Property(e => e.Tuoi13L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L1");
            entity.Property(e => e.Tuoi13L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L2");
            entity.Property(e => e.Tuoi13L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L3");
            entity.Property(e => e.Tuoi13L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L4");
            entity.Property(e => e.Tuoi13L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L5");
            entity.Property(e => e.Tuoi14L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L1");
            entity.Property(e => e.Tuoi14L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L2");
            entity.Property(e => e.Tuoi14L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L3");
            entity.Property(e => e.Tuoi14L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L4");
            entity.Property(e => e.Tuoi14L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L5");
            entity.Property(e => e.Tuoi6L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L1");
            entity.Property(e => e.Tuoi6L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L2");
            entity.Property(e => e.Tuoi6L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L3");
            entity.Property(e => e.Tuoi6L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L4");
            entity.Property(e => e.Tuoi6L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L5");
            entity.Property(e => e.Tuoi7L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L1");
            entity.Property(e => e.Tuoi7L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L2");
            entity.Property(e => e.Tuoi7L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L3");
            entity.Property(e => e.Tuoi7L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L4");
            entity.Property(e => e.Tuoi7L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L5");
            entity.Property(e => e.Tuoi8L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L1");
            entity.Property(e => e.Tuoi8L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L2");
            entity.Property(e => e.Tuoi8L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L3");
            entity.Property(e => e.Tuoi8L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L4");
            entity.Property(e => e.Tuoi8L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L5");
            entity.Property(e => e.Tuoi9L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L1");
            entity.Property(e => e.Tuoi9L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L2");
            entity.Property(e => e.Tuoi9L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L3");
            entity.Property(e => e.Tuoi9L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L4");
            entity.Property(e => e.Tuoi9L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L5");
        });

        modelBuilder.Entity<BcTh07HsHocTaiTruongTraiTuyen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BC_TH_06_HS_HOC_TAI_TRUONG_TRAI_TUYEN");

            entity.ToTable("BC_TH_07_HS_HOC_TAI_TRUONG_TRAI_TUYEN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruongHocTap }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruongHocTap)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG_HOC_TAP");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Tong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG");
            entity.Property(e => e.Tuoi10L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L1");
            entity.Property(e => e.Tuoi10L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L2");
            entity.Property(e => e.Tuoi10L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L3");
            entity.Property(e => e.Tuoi10L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L4");
            entity.Property(e => e.Tuoi10L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L5");
            entity.Property(e => e.Tuoi11L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L1");
            entity.Property(e => e.Tuoi11L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L2");
            entity.Property(e => e.Tuoi11L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L3");
            entity.Property(e => e.Tuoi11L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L4");
            entity.Property(e => e.Tuoi11L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L5");
            entity.Property(e => e.Tuoi12L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L1");
            entity.Property(e => e.Tuoi12L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L2");
            entity.Property(e => e.Tuoi12L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L3");
            entity.Property(e => e.Tuoi12L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L4");
            entity.Property(e => e.Tuoi12L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L5");
            entity.Property(e => e.Tuoi13L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L1");
            entity.Property(e => e.Tuoi13L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L2");
            entity.Property(e => e.Tuoi13L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L3");
            entity.Property(e => e.Tuoi13L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L4");
            entity.Property(e => e.Tuoi13L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L5");
            entity.Property(e => e.Tuoi14L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L1");
            entity.Property(e => e.Tuoi14L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L2");
            entity.Property(e => e.Tuoi14L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L3");
            entity.Property(e => e.Tuoi14L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L4");
            entity.Property(e => e.Tuoi14L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L5");
            entity.Property(e => e.Tuoi6L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L1");
            entity.Property(e => e.Tuoi6L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L2");
            entity.Property(e => e.Tuoi6L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L3");
            entity.Property(e => e.Tuoi6L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L4");
            entity.Property(e => e.Tuoi6L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_6_L5");
            entity.Property(e => e.Tuoi7L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L1");
            entity.Property(e => e.Tuoi7L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L2");
            entity.Property(e => e.Tuoi7L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L3");
            entity.Property(e => e.Tuoi7L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L4");
            entity.Property(e => e.Tuoi7L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_7_L5");
            entity.Property(e => e.Tuoi8L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L1");
            entity.Property(e => e.Tuoi8L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L2");
            entity.Property(e => e.Tuoi8L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L3");
            entity.Property(e => e.Tuoi8L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L4");
            entity.Property(e => e.Tuoi8L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_8_L5");
            entity.Property(e => e.Tuoi9L1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L1");
            entity.Property(e => e.Tuoi9L2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L2");
            entity.Property(e => e.Tuoi9L3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L3");
            entity.Property(e => e.Tuoi9L4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L4");
            entity.Property(e => e.Tuoi9L5)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_9_L5");
        });

        modelBuilder.Entity<BcThcs01Tn>(entity =>
        {
            entity.ToTable("BC_THCS_01_TN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.T11)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_11");
            entity.Property(e => e.T11Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_11_PT");
            entity.Property(e => e.T11Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_11_TX");
            entity.Property(e => e.T12)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_12");
            entity.Property(e => e.T12Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_12_PT");
            entity.Property(e => e.T12Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_12_TX");
            entity.Property(e => e.T13)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_13");
            entity.Property(e => e.T13Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_13_PT");
            entity.Property(e => e.T13Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_13_TX");
            entity.Property(e => e.T14)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_14");
            entity.Property(e => e.T14Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_14_PT");
            entity.Property(e => e.T14Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_14_TX");
            entity.Property(e => e.T15)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_15");
            entity.Property(e => e.T15Gdnn)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_15_GDNN");
            entity.Property(e => e.T15Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_15_PT");
            entity.Property(e => e.T15Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_15_TX");
            entity.Property(e => e.T16)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_16");
            entity.Property(e => e.T16Gdnn)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_16_GDNN");
            entity.Property(e => e.T16Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_16_PT");
            entity.Property(e => e.T16Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_16_TX");
            entity.Property(e => e.T17)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_17");
            entity.Property(e => e.T17Gdnn)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_17_GDNN");
            entity.Property(e => e.T17Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_17_PT");
            entity.Property(e => e.T17Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_17_TX");
            entity.Property(e => e.T18)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("T_18");
            entity.Property(e => e.T18Gdnn)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_18_GDNN");
            entity.Property(e => e.T18Pt)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_18_PT");
            entity.Property(e => e.T18Tx)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_18_TX");
            entity.Property(e => e.Tong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG");
        });

        modelBuilder.Entity<BcThcs01TnTh>(entity =>
        {
            entity.ToTable("BC_THCS_01_TN_TH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SL");
            entity.Property(e => e.Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL");
        });

        modelBuilder.Entity<BcThcs02Tcpcgdthc>(entity =>
        {
            entity.ToTable("BC_THCS_02_TCPCGDTHCS");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DgPcgdThcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DG_PCGD_THCS");
            entity.Property(e => e.HdHstnTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_HSTN_TS");
            entity.Property(e => e.HdHstnVhl6Cong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_HSTN_VHL6_CONG");
            entity.Property(e => e.HdHstnVhl6Gdtx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_HSTN_VHL6_GDTX");
            entity.Property(e => e.HdHstnVhl6Pt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_HSTN_VHL6_PT");
            entity.Property(e => e.HdHstnVhl6Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_HSTN_VHL6_TL");
            entity.Property(e => e.HdTre6tL1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_TRE6T_L1");
            entity.Property(e => e.HdTre6tTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_TRE6T_TL");
            entity.Property(e => e.HdTre6tTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HD_TRE6T_TS");
            entity.Property(e => e.HqDt1518TnCong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_DT1518_TN_CONG");
            entity.Property(e => e.HqDt1518TnGdtx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_DT1518_TN_GDTX");
            entity.Property(e => e.HqDt1518TnPt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_DT1518_TN_PT");
            entity.Property(e => e.HqDt1518TnTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_DT1518_TN_TL");
            entity.Property(e => e.HqDt1518Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_DT1518_TS");
            entity.Property(e => e.HqHsl9Thcsgdtx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_HSL9_THCSGDTX");
            entity.Property(e => e.HqHsl9Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_HSL9_TL");
            entity.Property(e => e.HqHsl9Tnthcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_HSL9_TNTHCS");
            entity.Property(e => e.HqHsl9Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_HSL9_TS");
            entity.Property(e => e.HqT1114Htctth)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_T1114_HTCTTH");
            entity.Property(e => e.HqT1114Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_T1114_TL");
            entity.Property(e => e.HqT1114Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HQ_T1114_TS");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<BcThcs02TcpcgdthcsTk>(entity =>
        {
            entity.ToTable("BC_THCS_02_TCPCGDTHCS_TK");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.KhongThuocKkDbkk)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KHONG_THUOC_KK_DBKK");
            entity.Property(e => e.KqDgPcgdThcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KQ_DG_PCGD_THCS");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.ThuocKkDbkk)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THUOC_KK_DBKK");
            entity.Property(e => e.TsMau)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TS_MAU");
            entity.Property(e => e.TsTu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TS_TU");
        });

        modelBuilder.Entity<BcThcs03Dn>(entity =>
        {
            entity.ToTable("BC_THCS_03_DN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruong }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GvBc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_BC");
            entity.Property(e => e.GvCnCongNghe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_CONG_NGHE");
            entity.Property(e => e.GvCnGdcd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_GDCD");
            entity.Property(e => e.GvCnHdgdMt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_HDGD_MT");
            entity.Property(e => e.GvCnHdgdNhac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_HDGD_NHAC");
            entity.Property(e => e.GvCnHdgdTd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_HDGD_TD");
            entity.Property(e => e.GvCnKhtnHoa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_KHTN_HOA");
            entity.Property(e => e.GvCnKhtnLy)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_KHTN_LY");
            entity.Property(e => e.GvCnKhtnSinh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_KHTN_SINH");
            entity.Property(e => e.GvCnKhxhDia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_KHXH_DIA");
            entity.Property(e => e.GvCnKhxhSu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_KHXH_SU");
            entity.Property(e => e.GvCnNguVan)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_NGU_VAN");
            entity.Property(e => e.GvCnNnAnh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_NN_ANH");
            entity.Property(e => e.GvCnNnKhac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_NN_KHAC");
            entity.Property(e => e.GvCnNnNga)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_NN_NGA");
            entity.Property(e => e.GvCnNnPhap)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_NN_PHAP");
            entity.Property(e => e.GvCnTinHoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_TIN_HOC");
            entity.Property(e => e.GvCnToan)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CN_TOAN");
            entity.Property(e => e.GvCnnKem)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CNN_KEM");
            entity.Property(e => e.GvCnnKha)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CNN_KHA");
            entity.Property(e => e.GvCnnTb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CNN_TB");
            entity.Property(e => e.GvCnnXx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_CNN_XX");
            entity.Property(e => e.GvDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_DT");
            entity.Property(e => e.GvHd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_HD");
            entity.Property(e => e.GvNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_NU");
            entity.Property(e => e.GvTdCd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_CD");
            entity.Property(e => e.GvTdDh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_DH");
            entity.Property(e => e.GvTdThsp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_THSP");
            entity.Property(e => e.GvTdTrenDh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TD_TREN_DH");
            entity.Property(e => e.GvTllop)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TLLOP");
            entity.Property(e => e.GvTptd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TPTD");
            entity.Property(e => e.GvTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("GV_TS");
            entity.Property(e => e.HangTruong).HasColumnName("HANG_TRUONG");
            entity.Property(e => e.HieuTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HIEU_TRUONG");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.NvTb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NV_TB");
            entity.Property(e => e.NvTv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NV_TV");
            entity.Property(e => e.NvVp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NV_VP");
            entity.Property(e => e.NvYt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NV_YT");
            entity.Property(e => e.PhoHieuTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PHO_HIEU_TRUONG");
        });

        modelBuilder.Entity<BcThcs03DnTh>(entity =>
        {
            entity.ToTable("BC_THCS_03_DN_TH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SL");
            entity.Property(e => e.Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL");
        });

        modelBuilder.Entity<BcThcs04Tcphcsvc>(entity =>
        {
            entity.ToTable("BC_THCS_04_TCPHCSVC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruong }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BtDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BT_DT");
            entity.Property(e => e.BtSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BT_SL");
            entity.Property(e => e.CnHieuTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_HIEU_TRUONG");
            entity.Property(e => e.CnPh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_PH");
            entity.Property(e => e.CnPhoHieuTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_PHO_HIEU_TRUONG");
            entity.Property(e => e.CnTnDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_TN_DT");
            entity.Property(e => e.CnTnSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_TN_SL");
            entity.Property(e => e.CnTv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_TV");
            entity.Property(e => e.CnVp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_VP");
            entity.Property(e => e.CnYt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CN_YT");
            entity.Property(e => e.CtvsGvDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_GV_DT");
            entity.Property(e => e.CtvsGvSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_GV_SL");
            entity.Property(e => e.CtvsHsDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_HS_DT");
            entity.Property(e => e.CtvsHsSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CTVS_HS_SL");
            entity.Property(e => e.DiemTruong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIEM_TRUONG");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.PhBanKc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PH_BAN_KC");
            entity.Property(e => e.PhKc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PH_KC");
            entity.Property(e => e.PhTam)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PH_TAM");
            entity.Property(e => e.ScDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SC_DT");
            entity.Property(e => e.ScSl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SC_SL");
            entity.Property(e => e.TlPhLop)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL_PH_LOP");
            entity.Property(e => e.TsLop)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TS_LOP");
        });

        modelBuilder.Entity<BcThcs05Kqpcgdth>(entity =>
        {
            entity.ToTable("BC_THCS_05_KQPCGDTH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon, e.NamSinh, e.DoTuoi }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BhTh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BH_TH");
            entity.Property(e => e.BhThcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BH_THCS");
            entity.Property(e => e.BhThpt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BH_THPT");
            entity.Property(e => e.ChuaDiHoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CHUA_DI_HOC");
            entity.Property(e => e.ChuyenDen)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CHUYEN_DEN");
            entity.Property(e => e.ChuyenDiChet)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CHUYEN_DI_CHET");
            entity.Property(e => e.DhThThcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DH_TH_THCS");
            entity.Property(e => e.DhhxGdtxL10TnthcsNamKhac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_GDTX_L10_TNTHCS_NAM_KHAC");
            entity.Property(e => e.DhhxGdtxL10TnthcsNamQua)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_GDTX_L10_TNTHCS_NAM_QUA");
            entity.Property(e => e.DhhxGdtxL11)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_GDTX_L11");
            entity.Property(e => e.DhhxGdtxL12)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_GDTX_L12");
            entity.Property(e => e.DhhxGdtxTnNamQua)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_GDTX_TN_NAM_QUA");
            entity.Property(e => e.DhhxGdtxTnNamTruoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_GDTX_TN_NAM_TRUOC");
            entity.Property(e => e.DhhxThcnTdnDtnNamQua)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THCN_TDN_DTN_NAM_QUA");
            entity.Property(e => e.DhhxThcnTdnDtnNamTruoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THCN_TDN_DTN_NAM_TRUOC");
            entity.Property(e => e.DhhxThcnTdnN1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THCN_TDN_N1");
            entity.Property(e => e.DhhxThcnTdnN2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THCN_TDN_N2");
            entity.Property(e => e.DhhxThcnTdnN3)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THCN_TDN_N3");
            entity.Property(e => e.DhhxThcnTdnN35)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THCN_TDN_N35");
            entity.Property(e => e.DhhxThcnTdnN4)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THCN_TDN_N4");
            entity.Property(e => e.DhhxThptL10TnthcsNamKhac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THPT_L10_TNTHCS_NAM_KHAC");
            entity.Property(e => e.DhhxThptL10TnthcsNamQua)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THPT_L10_TNTHCS_NAM_QUA");
            entity.Property(e => e.DhhxThptL11)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THPT_L11");
            entity.Property(e => e.DhhxThptL12)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THPT_L12");
            entity.Property(e => e.DhhxThptTnNamQua)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THPT_TN_NAM_QUA");
            entity.Property(e => e.DhhxThptTnNamTruoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHHX_THPT_TN_NAM_TRUOC");
            entity.Property(e => e.Dhx1011)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHX_1011");
            entity.Property(e => e.Dhx1234)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHX_1234");
            entity.Property(e => e.Dhx678)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DHX_678");
            entity.Property(e => e.DoTuoi).HasColumnName("DO_TUOI");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.KhuyetTat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KHUYET_TAT");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NamSinh).HasColumnName("NAM_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NU");
            entity.Property(e => e.TnThcsNamKhac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THCS_NAM_KHAC");
            entity.Property(e => e.TnThcsNamQua)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THCS_NAM_QUA");
            entity.Property(e => e.TruotTnTh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TRUOT_TN_TH");
            entity.Property(e => e.TruotTnThcs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TRUOT_TN_THCS");
            entity.Property(e => e.TruotTnThptNamQua)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TRUOT_TN_THPT_NAM_QUA");
            entity.Property(e => e.TruotTnThptNamTruoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TRUOT_TN_THPT_NAM_TRUOC");
            entity.Property(e => e.TsDtPhaiPcTh)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TS_DT_PHAI_PC_TH");
            entity.Property(e => e.TsDtTrongDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TS_DT_TRONG_DT");
        });

        modelBuilder.Entity<BcThcs05KqpcgdthTh>(entity =>
        {
            entity.ToTable("BC_THCS_05_KQPCGDTH_TH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon, e.Ma }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL");
            entity.Property(e => e.Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TS");
        });

        modelBuilder.Entity<BcThcs06Dtkt>(entity =>
        {
            entity.ToTable("BC_THCS_06_DTKT");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.NamSinh, e.DoTuoi, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoTuoi).HasColumnName("DO_TUOI");
            entity.Property(e => e.HocTap)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HOC_TAP");
            entity.Property(e => e.HsktTcGdTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HSKT_TC_GD_TL");
            entity.Property(e => e.HsktTcGdTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HSKT_TC_GD_TS");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Khac)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("KHAC");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NamSinh).HasColumnName("NAM_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NgheNoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NGHE_NOI");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Nhin)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NHIN");
            entity.Property(e => e.Rlptk)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("RLPTK");
            entity.Property(e => e.Tktt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TKTT");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
            entity.Property(e => e.TriTue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TRI_TUE");
            entity.Property(e => e.VanDong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("VAN_DONG");
        });

        modelBuilder.Entity<BcThcs07HsTraiTuyenTaiTruong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BC_THCS_07_");

            entity.ToTable("BC_THCS_07_HS_TRAI_TUYEN_TAI_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruong, e.MaTinhDiaChi, e.MaHuyenDiaChi, e.MaXaDiaChi, e.IdHuyen, e.IdXa, e.IdHuyenDiaChi, e.IdXaDiaChi }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdHuyenDiaChi)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN_DIA_CHI");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.IdXaDiaChi)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA_DIA_CHI");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaHuyenDiaChi)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN_DIA_CHI");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTinhDiaChi)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH_DIA_CHI");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.MaXaDiaChi)
                .HasMaxLength(50)
                .HasColumnName("MA_XA_DIA_CHI");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Tong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG");
            entity.Property(e => e.Tuoi10L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L6");
            entity.Property(e => e.Tuoi10L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L7");
            entity.Property(e => e.Tuoi10L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L8");
            entity.Property(e => e.Tuoi10L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L9");
            entity.Property(e => e.Tuoi11L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L6");
            entity.Property(e => e.Tuoi11L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L7");
            entity.Property(e => e.Tuoi11L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L8");
            entity.Property(e => e.Tuoi11L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L9");
            entity.Property(e => e.Tuoi12L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L6");
            entity.Property(e => e.Tuoi12L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L7");
            entity.Property(e => e.Tuoi12L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L8");
            entity.Property(e => e.Tuoi12L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L9");
            entity.Property(e => e.Tuoi13L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L6");
            entity.Property(e => e.Tuoi13L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L7");
            entity.Property(e => e.Tuoi13L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L8");
            entity.Property(e => e.Tuoi13L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L9");
            entity.Property(e => e.Tuoi14L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L6");
            entity.Property(e => e.Tuoi14L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L7");
            entity.Property(e => e.Tuoi14L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L8");
            entity.Property(e => e.Tuoi14L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L9");
            entity.Property(e => e.Tuoi15L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L6");
            entity.Property(e => e.Tuoi15L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L7");
            entity.Property(e => e.Tuoi15L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L8");
            entity.Property(e => e.Tuoi15L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L9");
            entity.Property(e => e.Tuoi16L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L6");
            entity.Property(e => e.Tuoi16L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L7");
            entity.Property(e => e.Tuoi16L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L8");
            entity.Property(e => e.Tuoi16L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L9");
            entity.Property(e => e.Tuoi17L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L6");
            entity.Property(e => e.Tuoi17L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L7");
            entity.Property(e => e.Tuoi17L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L8");
            entity.Property(e => e.Tuoi17L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L9");
            entity.Property(e => e.Tuoi18L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L6");
            entity.Property(e => e.Tuoi18L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L7");
            entity.Property(e => e.Tuoi18L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L8");
            entity.Property(e => e.Tuoi18L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L9");
        });

        modelBuilder.Entity<BcThcs08HsHocTaiTruongTraiTuyen>(entity =>
        {
            entity.ToTable("BC_THCS_08_HS_HOC_TAI_TRUONG_TRAI_TUYEN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.MaTruongHocTap }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTruongHocTap)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG_HOC_TAP");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Tong)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG");
            entity.Property(e => e.Tuoi10L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L6");
            entity.Property(e => e.Tuoi10L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L7");
            entity.Property(e => e.Tuoi10L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L8");
            entity.Property(e => e.Tuoi10L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_10_L9");
            entity.Property(e => e.Tuoi11L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L6");
            entity.Property(e => e.Tuoi11L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L7");
            entity.Property(e => e.Tuoi11L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L8");
            entity.Property(e => e.Tuoi11L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_11_L9");
            entity.Property(e => e.Tuoi12L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L6");
            entity.Property(e => e.Tuoi12L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L7");
            entity.Property(e => e.Tuoi12L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L8");
            entity.Property(e => e.Tuoi12L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_12_L9");
            entity.Property(e => e.Tuoi13L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L6");
            entity.Property(e => e.Tuoi13L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L7");
            entity.Property(e => e.Tuoi13L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L8");
            entity.Property(e => e.Tuoi13L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_13_L9");
            entity.Property(e => e.Tuoi14L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L6");
            entity.Property(e => e.Tuoi14L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L7");
            entity.Property(e => e.Tuoi14L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L8");
            entity.Property(e => e.Tuoi14L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_14_L9");
            entity.Property(e => e.Tuoi15L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L6");
            entity.Property(e => e.Tuoi15L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L7");
            entity.Property(e => e.Tuoi15L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L8");
            entity.Property(e => e.Tuoi15L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_15_L9");
            entity.Property(e => e.Tuoi16L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L6");
            entity.Property(e => e.Tuoi16L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L7");
            entity.Property(e => e.Tuoi16L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L8");
            entity.Property(e => e.Tuoi16L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_16_L9");
            entity.Property(e => e.Tuoi17L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L6");
            entity.Property(e => e.Tuoi17L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L7");
            entity.Property(e => e.Tuoi17L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L8");
            entity.Property(e => e.Tuoi17L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_17_L9");
            entity.Property(e => e.Tuoi18L6)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L6");
            entity.Property(e => e.Tuoi18L7)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L7");
            entity.Property(e => e.Tuoi18L8)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L8");
            entity.Property(e => e.Tuoi18L9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TUOI_18_L9");
        });

        modelBuilder.Entity<BcThpt01Hdpc>(entity =>
        {
            entity.ToTable("BC_THPT_01_HDPC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DanhGia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DANH_GIA");
            entity.Property(e => e.Dt1518TnThcsBoHoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518_TN_THCS_BO_HOC");
            entity.Property(e => e.Dt1518TnThcsConHoc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518_TN_THCS_CON_HOC");
            entity.Property(e => e.Dt1518TnThcsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518_TN_THCS_TL");
            entity.Property(e => e.Dt1518TnThcsTspc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518_TN_THCS_TSPC");
            entity.Property(e => e.Dt1518TnThcsTstn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518_TN_THCS_TSTN");
            entity.Property(e => e.Dt1518dnDn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518DN_DN");
            entity.Property(e => e.Dt1518dnGdtx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518DN_GDTX");
            entity.Property(e => e.Dt1518dnTccn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518DN_TCCN");
            entity.Property(e => e.Dt1518dnThpt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518DN_THPT");
            entity.Property(e => e.Dt1518dnTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518DN_TL");
            entity.Property(e => e.Dt1518dnTlVaoTdn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518DN_TL_VAO_TDN");
            entity.Property(e => e.Dt1518dnTlVaoThcn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1518DN_TL_VAO_THCN");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TnThcsVuaQuaL9)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THCS_VUA_QUA_L9");
            entity.Property(e => e.TnThcsVuaQuaTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THCS_VUA_QUA_TL");
            entity.Property(e => e.TnThcsVuaQuaTn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THCS_VUA_QUA_TN");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
        });

        modelBuilder.Entity<BcThpt02Hqpc>(entity =>
        {
            entity.ToTable("BC_THPT_02_HQPC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DanhGia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DANH_GIA");
            entity.Property(e => e.Dt1821CoBangTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_CO_BANG_TL");
            entity.Property(e => e.Dt1821CoBangTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_CO_BANG_TS");
            entity.Property(e => e.Dt1821CoBangTsHoc3n)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_CO_BANG_TS_HOC_3N");
            entity.Property(e => e.Dt1821TnTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_TN_TL");
            entity.Property(e => e.Dt1821TnTspc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_TN_TSPC");
            entity.Property(e => e.Dt1821TnTstnBt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_TN_TSTN_BT");
            entity.Property(e => e.Dt1821TnTstnThcn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_TN_TSTN_THCN");
            entity.Property(e => e.Dt1821TnTstnThpt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT1821_TN_TSTN_THPT");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TnThptVuaQuaL12)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THPT_VUA_QUA_L12");
            entity.Property(e => e.TnThptVuaQuaL12Gdtx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THPT_VUA_QUA_L12_GDTX");
            entity.Property(e => e.TnThptVuaQuaTlGdtx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THPT_VUA_QUA_TL_GDTX");
            entity.Property(e => e.TnThptVuaQuaTlThpt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THPT_VUA_QUA_TL_THPT");
            entity.Property(e => e.TnThptVuaQuaTn)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THPT_VUA_QUA_TN");
            entity.Property(e => e.TnThptVuaQuaTnGdtx)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TN_THPT_VUA_QUA_TN_GDTX");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
        });

        modelBuilder.Entity<BcThpt03TtCsdn>(entity =>
        {
            entity.ToTable("BC_THPT_03_TT_CSDN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.ThDcqg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TH_DCQG");
            entity.Property(e => e.ThTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TH_TL");
            entity.Property(e => e.ThTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TH_TS");
            entity.Property(e => e.ThcsNcDcqg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THCS_NC_DCQG");
            entity.Property(e => e.ThcsNcTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THCS_NC_TL");
            entity.Property(e => e.ThcsNcTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THCS_NC_TS");
            entity.Property(e => e.ThcsThcsDcqg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THCS_THCS_DCQG");
            entity.Property(e => e.ThcsThcsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THCS_THCS_TL");
            entity.Property(e => e.ThcsThcsTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THCS_THCS_TS");
            entity.Property(e => e.ThcsTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THCS_TS");
            entity.Property(e => e.ThptNcDcqg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THPT_NC_DCQG");
            entity.Property(e => e.ThptNcTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THPT_NC_TL");
            entity.Property(e => e.ThptNcTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THPT_NC_TS");
            entity.Property(e => e.ThptThptDcqg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THPT_THPT_DCQG");
            entity.Property(e => e.ThptThptTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THPT_THPT_TL");
            entity.Property(e => e.ThptThptTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THPT_THPT_TS");
            entity.Property(e => e.ThptTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("THPT_TS");
            entity.Property(e => e.TtgdtxTtktth)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TTGDTX_TTKTTH");
        });

        modelBuilder.Entity<BcXmc01Thxmc>(entity =>
        {
            entity.ToTable("BC_XMC_01_THXMC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ds1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_DT");
            entity.Property(e => e.Ds1525Mc1Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_DT");
            entity.Property(e => e.Ds1525Mc1DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_DT_TL");
            entity.Property(e => e.Ds1525Mc1Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_NU");
            entity.Property(e => e.Ds1525Mc1NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_NU_DT");
            entity.Property(e => e.Ds1525Mc1NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_NU_DT_TL");
            entity.Property(e => e.Ds1525Mc1NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_NU_TL");
            entity.Property(e => e.Ds1525Mc1Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_TL");
            entity.Property(e => e.Ds1525Mc1Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC1_TS");
            entity.Property(e => e.Ds1525Mc2Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_DT");
            entity.Property(e => e.Ds1525Mc2DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_DT_TL");
            entity.Property(e => e.Ds1525Mc2Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_NU");
            entity.Property(e => e.Ds1525Mc2NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_NU_DT");
            entity.Property(e => e.Ds1525Mc2NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_NU_DT_TL");
            entity.Property(e => e.Ds1525Mc2NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_NU_TL");
            entity.Property(e => e.Ds1525Mc2Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_TL");
            entity.Property(e => e.Ds1525Mc2Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_MC2_TS");
            entity.Property(e => e.Ds1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_NU");
            entity.Property(e => e.Ds1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_NU_DT");
            entity.Property(e => e.Ds1525TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1525_TONG_SO");
            entity.Property(e => e.Ds1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_DT");
            entity.Property(e => e.Ds1535Mc1Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_DT");
            entity.Property(e => e.Ds1535Mc1DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_DT_TL");
            entity.Property(e => e.Ds1535Mc1Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_NU");
            entity.Property(e => e.Ds1535Mc1NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_NU_DT");
            entity.Property(e => e.Ds1535Mc1NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_NU_DT_TL");
            entity.Property(e => e.Ds1535Mc1NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_NU_TL");
            entity.Property(e => e.Ds1535Mc1Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_TL");
            entity.Property(e => e.Ds1535Mc1Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC1_TS");
            entity.Property(e => e.Ds1535Mc2Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_DT");
            entity.Property(e => e.Ds1535Mc2DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_DT_TL");
            entity.Property(e => e.Ds1535Mc2Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_NU");
            entity.Property(e => e.Ds1535Mc2NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_NU_DT");
            entity.Property(e => e.Ds1535Mc2NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_NU_DT_TL");
            entity.Property(e => e.Ds1535Mc2NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_NU_TL");
            entity.Property(e => e.Ds1535Mc2Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_TL");
            entity.Property(e => e.Ds1535Mc2Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_MC2_TS");
            entity.Property(e => e.Ds1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_NU");
            entity.Property(e => e.Ds1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_NU_DT");
            entity.Property(e => e.Ds1535TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1535_TONG_SO");
            entity.Property(e => e.Ds1565Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_DT");
            entity.Property(e => e.Ds1565Mc1Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_DT");
            entity.Property(e => e.Ds1565Mc1DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_DT_TL");
            entity.Property(e => e.Ds1565Mc1Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_NU");
            entity.Property(e => e.Ds1565Mc1NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_NU_DT");
            entity.Property(e => e.Ds1565Mc1NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_NU_DT_TL");
            entity.Property(e => e.Ds1565Mc1NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_NU_TL");
            entity.Property(e => e.Ds1565Mc1Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_TL");
            entity.Property(e => e.Ds1565Mc1Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC1_TS");
            entity.Property(e => e.Ds1565Mc2Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_DT");
            entity.Property(e => e.Ds1565Mc2DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_DT_TL");
            entity.Property(e => e.Ds1565Mc2Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_NU");
            entity.Property(e => e.Ds1565Mc2NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_NU_DT");
            entity.Property(e => e.Ds1565Mc2NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_NU_DT_TL");
            entity.Property(e => e.Ds1565Mc2NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_NU_TL");
            entity.Property(e => e.Ds1565Mc2Tl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_TL");
            entity.Property(e => e.Ds1565Mc2Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_MC2_TS");
            entity.Property(e => e.Ds1565Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_NU");
            entity.Property(e => e.Ds1565NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_NU_DT");
            entity.Property(e => e.Ds1565TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_1565_TONG_SO");
            entity.Property(e => e.Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NU");
            entity.Property(e => e.NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NU_DT");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
        });

        modelBuilder.Entity<BcXmc02Thkqxmc>(entity =>
        {
            entity.ToTable("BC_XMC_02_THKQXMC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon, e.DoTuoi, e.NamSinh }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BcDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BC_DT");
            entity.Property(e => e.BcDtNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BC_DT_NU");
            entity.Property(e => e.BcNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BC_NU");
            entity.Property(e => e.BcTongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BC_TONG_SO");
            entity.Property(e => e.DoTuoi).HasColumnName("DO_TUOI");
            entity.Property(e => e.Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT");
            entity.Property(e => e.DtNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DT_NU");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.Mc1Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC1_DT");
            entity.Property(e => e.Mc1DtNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC1_DT_NU");
            entity.Property(e => e.Mc1Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC1_NU");
            entity.Property(e => e.Mc1TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC1_TONG_SO");
            entity.Property(e => e.Mc2Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC2_DT");
            entity.Property(e => e.Mc2DtNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC2_DT_NU");
            entity.Property(e => e.Mc2Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC2_NU");
            entity.Property(e => e.Mc2TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC2_TONG_SO");
            entity.Property(e => e.NamSinh).HasColumnName("NAM_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NU");
            entity.Property(e => e.Tlbc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TLBC");
            entity.Property(e => e.TongSo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TONG_SO");
        });

        modelBuilder.Entity<BcXmc03Tknmcdt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BC_XMC_03_TKKQXMC");

            entity.ToTable("BC_XMC_03_TKNMCDT");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon, e.NhomTuoi }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DsDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_DT");
            entity.Property(e => e.DsNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_NU");
            entity.Property(e => e.DsTg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_TG");
            entity.Property(e => e.DsTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS_TS");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.McMuc1Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC1_DT");
            entity.Property(e => e.McMuc1Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC1_NU");
            entity.Property(e => e.McMuc1Tg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC1_TG");
            entity.Property(e => e.McMuc1Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC1_TS");
            entity.Property(e => e.McMuc2Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC2_DT");
            entity.Property(e => e.McMuc2Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC2_NU");
            entity.Property(e => e.McMuc2Tg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC2_TG");
            entity.Property(e => e.McMuc2Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MC_MUC2_TS");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.NhomTuoi)
                .HasMaxLength(20)
                .HasColumnName("NHOM_TUOI");
            entity.Property(e => e.TlMc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TL_MC");
            entity.Property(e => e.TmcDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TMC_DT");
            entity.Property(e => e.TmcNu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TMC_NU");
            entity.Property(e => e.TmcTg)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TMC_TG");
            entity.Property(e => e.TmcTs)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TMC_TS");
        });

        modelBuilder.Entity<BcXmc04TkhtMuc1>(entity =>
        {
            entity.ToTable("BC_XMC_04_TKHT_MUC1");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ds1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_DT");
            entity.Property(e => e.Ds1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_NU");
            entity.Property(e => e.Ds1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_NU_DT");
            entity.Property(e => e.Ds1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_TS");
            entity.Property(e => e.Ds1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_DT");
            entity.Property(e => e.Ds1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_NU");
            entity.Property(e => e.Ds1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_NU_DT");
            entity.Property(e => e.Ds1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_TS");
            entity.Property(e => e.Ds1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_DT");
            entity.Property(e => e.Ds1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_NU");
            entity.Property(e => e.Ds1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_NU_DT");
            entity.Property(e => e.Ds1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_TS");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.N1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_DT");
            entity.Property(e => e.N1525DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_DT_TL");
            entity.Property(e => e.N1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU");
            entity.Property(e => e.N1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU_DT");
            entity.Property(e => e.N1525NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU_DT_TL");
            entity.Property(e => e.N1525NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU_TL");
            entity.Property(e => e.N1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_TS");
            entity.Property(e => e.N1525TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_TS_TL");
            entity.Property(e => e.N1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_DT");
            entity.Property(e => e.N1535DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_DT_TL");
            entity.Property(e => e.N1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU");
            entity.Property(e => e.N1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU_DT");
            entity.Property(e => e.N1535NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU_DT_TL");
            entity.Property(e => e.N1535NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU_TL");
            entity.Property(e => e.N1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_TS");
            entity.Property(e => e.N1535TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_TS_TL");
            entity.Property(e => e.N1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_DT");
            entity.Property(e => e.N1560DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_DT_TL");
            entity.Property(e => e.N1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU");
            entity.Property(e => e.N1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU_DT");
            entity.Property(e => e.N1560NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU_DT_TL");
            entity.Property(e => e.N1560NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU_TL");
            entity.Property(e => e.N1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_TS");
            entity.Property(e => e.N1560TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_TS_TL");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<BcXmc05TkhtMuc2>(entity =>
        {
            entity.ToTable("BC_XMC_05_TKHT_MUC2");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ds1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_DT");
            entity.Property(e => e.Ds1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_NU");
            entity.Property(e => e.Ds1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_NU_DT");
            entity.Property(e => e.Ds1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1525_TS");
            entity.Property(e => e.Ds1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_DT");
            entity.Property(e => e.Ds1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_NU");
            entity.Property(e => e.Ds1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_NU_DT");
            entity.Property(e => e.Ds1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1535_TS");
            entity.Property(e => e.Ds1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_DT");
            entity.Property(e => e.Ds1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_NU");
            entity.Property(e => e.Ds1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_NU_DT");
            entity.Property(e => e.Ds1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DS1560_TS");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.N1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_DT");
            entity.Property(e => e.N1525DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_DT_TL");
            entity.Property(e => e.N1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU");
            entity.Property(e => e.N1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU_DT");
            entity.Property(e => e.N1525NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU_DT_TL");
            entity.Property(e => e.N1525NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_NU_TL");
            entity.Property(e => e.N1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_TS");
            entity.Property(e => e.N1525TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1525_TS_TL");
            entity.Property(e => e.N1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_DT");
            entity.Property(e => e.N1535DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_DT_TL");
            entity.Property(e => e.N1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU");
            entity.Property(e => e.N1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU_DT");
            entity.Property(e => e.N1535NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU_DT_TL");
            entity.Property(e => e.N1535NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_NU_TL");
            entity.Property(e => e.N1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_TS");
            entity.Property(e => e.N1535TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1535_TS_TL");
            entity.Property(e => e.N1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_DT");
            entity.Property(e => e.N1560DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_DT_TL");
            entity.Property(e => e.N1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU");
            entity.Property(e => e.N1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU_DT");
            entity.Property(e => e.N1560NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU_DT_TL");
            entity.Property(e => e.N1560NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_NU_TL");
            entity.Property(e => e.N1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_TS");
            entity.Property(e => e.N1560TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("N1560_TS_TL");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<BcXmc06TkkqHmcMuc1>(entity =>
        {
            entity.ToTable("BC_XMC_06_TKKQ_HMC_MUC1");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hv1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_DT");
            entity.Property(e => e.Hv1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_NU");
            entity.Property(e => e.Hv1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_NU_DT");
            entity.Property(e => e.Hv1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_TS");
            entity.Property(e => e.Hv1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_DT");
            entity.Property(e => e.Hv1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_NU");
            entity.Property(e => e.Hv1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_NU_DT");
            entity.Property(e => e.Hv1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_TS");
            entity.Property(e => e.Hv1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_DT");
            entity.Property(e => e.Hv1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_NU");
            entity.Property(e => e.Hv1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_NU_DT");
            entity.Property(e => e.Hv1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_TS");
            entity.Property(e => e.HvCnBc1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_DT");
            entity.Property(e => e.HvCnBc1525DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_DT_TL");
            entity.Property(e => e.HvCnBc1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU");
            entity.Property(e => e.HvCnBc1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU_DT");
            entity.Property(e => e.HvCnBc1525NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU_DT_TL");
            entity.Property(e => e.HvCnBc1525NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU_TL");
            entity.Property(e => e.HvCnBc1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_TS");
            entity.Property(e => e.HvCnBc1525TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_TS_TL");
            entity.Property(e => e.HvCnBc1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_DT");
            entity.Property(e => e.HvCnBc1535DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_DT_TL");
            entity.Property(e => e.HvCnBc1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU");
            entity.Property(e => e.HvCnBc1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU_DT");
            entity.Property(e => e.HvCnBc1535NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU_DT_TL");
            entity.Property(e => e.HvCnBc1535NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU_TL");
            entity.Property(e => e.HvCnBc1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_TS");
            entity.Property(e => e.HvCnBc1535TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_TS_TL");
            entity.Property(e => e.HvCnBc1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_DT");
            entity.Property(e => e.HvCnBc1560DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_DT_TL");
            entity.Property(e => e.HvCnBc1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU");
            entity.Property(e => e.HvCnBc1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU_DT");
            entity.Property(e => e.HvCnBc1560NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU_DT_TL");
            entity.Property(e => e.HvCnBc1560NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU_TL");
            entity.Property(e => e.HvCnBc1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_TS");
            entity.Property(e => e.HvCnBc1560TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_TS_TL");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<BcXmc07TkkqHmcMuc2>(entity =>
        {
            entity.ToTable("BC_XMC_07_TKKQ_HMC_MUC2");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hv1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_DT");
            entity.Property(e => e.Hv1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_NU");
            entity.Property(e => e.Hv1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_NU_DT");
            entity.Property(e => e.Hv1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1525_TS");
            entity.Property(e => e.Hv1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_DT");
            entity.Property(e => e.Hv1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_NU");
            entity.Property(e => e.Hv1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_NU_DT");
            entity.Property(e => e.Hv1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1535_TS");
            entity.Property(e => e.Hv1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_DT");
            entity.Property(e => e.Hv1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_NU");
            entity.Property(e => e.Hv1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_NU_DT");
            entity.Property(e => e.Hv1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_1560_TS");
            entity.Property(e => e.HvCnBc1525Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_DT");
            entity.Property(e => e.HvCnBc1525DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_DT_TL");
            entity.Property(e => e.HvCnBc1525Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU");
            entity.Property(e => e.HvCnBc1525NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU_DT");
            entity.Property(e => e.HvCnBc1525NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU_DT_TL");
            entity.Property(e => e.HvCnBc1525NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_NU_TL");
            entity.Property(e => e.HvCnBc1525Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_TS");
            entity.Property(e => e.HvCnBc1525TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1525_TS_TL");
            entity.Property(e => e.HvCnBc1535Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_DT");
            entity.Property(e => e.HvCnBc1535DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_DT_TL");
            entity.Property(e => e.HvCnBc1535Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU");
            entity.Property(e => e.HvCnBc1535NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU_DT");
            entity.Property(e => e.HvCnBc1535NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU_DT_TL");
            entity.Property(e => e.HvCnBc1535NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_NU_TL");
            entity.Property(e => e.HvCnBc1535Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_TS");
            entity.Property(e => e.HvCnBc1535TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1535_TS_TL");
            entity.Property(e => e.HvCnBc1560Dt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_DT");
            entity.Property(e => e.HvCnBc1560DtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_DT_TL");
            entity.Property(e => e.HvCnBc1560Nu)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU");
            entity.Property(e => e.HvCnBc1560NuDt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU_DT");
            entity.Property(e => e.HvCnBc1560NuDtTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU_DT_TL");
            entity.Property(e => e.HvCnBc1560NuTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_NU_TL");
            entity.Property(e => e.HvCnBc1560Ts)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_TS");
            entity.Property(e => e.HvCnBc1560TsTl)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("HV_CN_BC_1560_TS_TL");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<BcXmc08Tkkqxmc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BC_XMC_08_TKKQ");

            entity.ToTable("BC_XMC_08_TKKQXMC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa, e.Ma, e.IdToThon }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc)
                .HasMaxLength(20)
                .HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.T1525)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_15_25");
            entity.Property(e => e.T1535)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_15_35");
            entity.Property(e => e.T1560)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("T_15_60");
        });

        modelBuilder.Entity<BieuMauBaoCao>(entity =>
        {
            entity.ToTable("BIEU_MAU_BAO_CAO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LoaiBaoCao)
                .HasMaxLength(50)
                .HasColumnName("LOAI_BAO_CAO");
            entity.Property(e => e.MaBieuMau)
                .HasMaxLength(50)
                .HasColumnName("MA_BIEU_MAU");
            entity.Property(e => e.TenBieuMau)
                .HasMaxLength(250)
                .HasColumnName("TEN_BIEU_MAU");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<CauHinhApiCsdl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAU_HINH__3214EC273E0020FF");

            entity.ToTable("CAU_HINH_API_CSDL");

            entity.HasIndex(e => new { e.MaSoGd, e.MaNamHoc }, "MA_SO_GD_MA_NAM_HOC").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<ChiTieuBaoCao>(entity =>
        {
            entity.ToTable("CHI_TIEU_BAO_CAO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ColMerge).HasColumnName("COL_MERGE");
            entity.Property(e => e.DonVi)
                .HasMaxLength(50)
                .HasColumnName("DON_VI");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaBieuMau)
                .HasMaxLength(50)
                .HasColumnName("MA_BIEU_MAU");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.NoiDung)
                .HasMaxLength(250)
                .HasColumnName("NOI_DUNG");
            entity.Property(e => e.NoiDungCha)
                .HasMaxLength(250)
                .HasColumnName("NOI_DUNG_CHA");
            entity.Property(e => e.NoiDungCha1)
                .HasMaxLength(250)
                .HasColumnName("NOI_DUNG_CHA_1");
            entity.Property(e => e.NoiDungCha2)
                .HasMaxLength(250)
                .HasColumnName("NOI_DUNG_CHA_2");
            entity.Property(e => e.RowMerge).HasColumnName("ROW_MERGE");
            entity.Property(e => e.ThuTu)
                .HasMaxLength(10)
                .HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmBacTotNghiepNghe>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_BAC_TOT_NGHIEP_NGHE");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmBacTotNghiepPhoThong>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_BAC_TOT_NGHIEP_PHO_THONG");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmBoHocLop>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_BO_HOC_LOP");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmCapDonVi>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_CAP_DON_VI");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmCapDonViHc>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_CAP_DON_VI_HC");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmCapHoc>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_CAP_HOC_1");

            entity.ToTable("DM_CAP_HOC");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmDanToc>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_DAN_TOC_1");

            entity.ToTable("DM_DAN_TOC");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.TenGoiKhac)
                .HasMaxLength(250)
                .HasColumnName("TEN_GOI_KHAC");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmDienChinhSach>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_DIEN_CHINH_SACH");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.IsC1).HasColumnName("IS_C1");
            entity.Property(e => e.IsC2).HasColumnName("IS_C2");
            entity.Property(e => e.IsC3).HasColumnName("IS_C3");
            entity.Property(e => e.IsGdtx).HasColumnName("IS_GDTX");
            entity.Property(e => e.IsMn).HasColumnName("IS_MN");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(100)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmDienCuTru>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_DIEN_CU_TRU");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmGioiTinh>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_GIOI_TINH_1");

            entity.ToTable("DM_GIOI_TINH");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmHoanCanhDacBiet>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_HOAN_CANH_DAC_BIET");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmHoanThanhXoaMuChuLop>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_HOAN_THANH_MU_CHU_LOP");

            entity.ToTable("DM_HOAN_THANH_XOA_MU_CHU_LOP");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmHocXoaMuChuLop>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_HOC_XOA_MU_CHU_LOP");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmHocXongLop>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_HOC_XONG_LOP");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmHuyen>(entity =>
        {
            entity.ToTable("DM_HUYEN");

            entity.HasIndex(e => new { e.Ma, e.MaNamHoc }, "IX_KEY").IsUnique();

            entity.HasIndex(e => e.MaNamHoc, "IX_NAM_HOC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh }, "IX_TINH_NAM_HOC");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Cap)
                .HasMaxLength(50)
                .HasColumnName("CAP");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");

            entity.HasOne(d => d.MaTinhNavigation).WithMany(p => p.DmHuyens)
                .HasForeignKey(d => d.MaTinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_HUYEN_DM_TINH");
        });

        modelBuilder.Entity<DmKhoi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_KHOI");

            entity.ToTable("DM_KHOI");

            entity.HasIndex(e => e.MaCapHoc, "IX_CAP_HOC");

            entity.HasIndex(e => new { e.Ma, e.MaCapHoc }, "IX_CAP_HOC_MA").IsUnique();

            entity.HasIndex(e => e.Ma, "IX_DM_KHOI").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaLoaiLop)
                .HasMaxLength(20)
                .HasColumnName("MA_LOAI_LOP");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DmKhois)
                .HasForeignKey(d => d.MaCapHoc)
                .HasConstraintName("FK_DM_KHOI_DM_CAP_HOC");
        });

        modelBuilder.Entity<DmKhuVuc>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_KHU_VUC_1");

            entity.ToTable("DM_KHU_VUC");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmKieuLop>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_KIEU_LOP");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmLoaiCanBo>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_LOAI_CAN_BO");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.IsBo).HasColumnName("IS_BO");
            entity.Property(e => e.IsC1).HasColumnName("IS_C1");
            entity.Property(e => e.IsC2).HasColumnName("IS_C2");
            entity.Property(e => e.IsC3).HasColumnName("IS_C3");
            entity.Property(e => e.IsGdtx).HasColumnName("IS_GDTX");
            entity.Property(e => e.IsMn).HasColumnName("IS_MN");
            entity.Property(e => e.IsPhong).HasColumnName("IS_PHONG");
            entity.Property(e => e.IsSo).HasColumnName("IS_SO");
            entity.Property(e => e.MaNhomCanBo)
                .HasMaxLength(20)
                .HasColumnName("MA_NHOM_CAN_BO");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmLoaiHinh>(entity =>
        {
            entity.ToTable("DM_LOAI_HINH");

            entity.HasIndex(e => new { e.Ma, e.MaNamHoc }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IsC1).HasColumnName("IS_C1");
            entity.Property(e => e.IsC2).HasColumnName("IS_C2");
            entity.Property(e => e.IsC3).HasColumnName("IS_C3");
            entity.Property(e => e.IsGdtx).HasColumnName("IS_GDTX");
            entity.Property(e => e.IsMn).HasColumnName("IS_MN");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmLoaiKhuyetTat>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_LOAI_KHUYET_TAT");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmLoaiTruong>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_LOAI_TRUONG_1");

            entity.ToTable("DM_LOAI_TRUONG");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.IsC1).HasColumnName("IS_C1");
            entity.Property(e => e.IsC2).HasColumnName("IS_C2");
            entity.Property(e => e.IsC3).HasColumnName("IS_C3");
            entity.Property(e => e.IsGdtx).HasColumnName("IS_GDTX");
            entity.Property(e => e.IsMamNon).HasColumnName("IS_MAM_NON");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmMucDatChuanQgClgd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DM_MUC_DAT_CHUAN_QG_CLGD_1");

            entity.ToTable("DM_MUC_DAT_CHUAN_QG_CLGD");

            entity.HasIndex(e => e.Ma, "IX_DM_MUC_DAT_CHUAN_QG_CLGD_MA");

            entity.HasIndex(e => e.MaNamHoc, "IX_DM_MUC_DAT_CHUAN_QG_CLGD_MA_NAM_HOC");

            entity.HasIndex(e => new { e.Ma, e.MaNamHoc }, "IX_DM_MUC_DAT_CHUAN_QG_CLGD_UNIQUE").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IsC1).HasColumnName("IS_C1");
            entity.Property(e => e.IsC2).HasColumnName("IS_C2");
            entity.Property(e => e.IsC3).HasColumnName("IS_C3");
            entity.Property(e => e.IsGdtx).HasColumnName("IS_GDTX");
            entity.Property(e => e.IsMn).HasColumnName("IS_MN");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmMucTaiMuChu>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_MUC_TAI_MU_CHU");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmNhomCanBo>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_NHOM_CAN_BO");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.IsBo).HasColumnName("IS_BO");
            entity.Property(e => e.IsC1).HasColumnName("IS_C1");
            entity.Property(e => e.IsC2).HasColumnName("IS_C2");
            entity.Property(e => e.IsC3).HasColumnName("IS_C3");
            entity.Property(e => e.IsGdtx).HasColumnName("IS_GDTX");
            entity.Property(e => e.IsMn).HasColumnName("IS_MN");
            entity.Property(e => e.IsPhong).HasColumnName("IS_PHONG");
            entity.Property(e => e.IsSo).HasColumnName("IS_SO");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmNhomTuoiMn>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_NHOM_TUOI_MN");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaNhomTre)
                .HasMaxLength(20)
                .HasColumnName("MA_NHOM_TRE");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua).HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao).HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
        });

        modelBuilder.Entity<DmNuoc>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_NUOC");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmPhanBan>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_PHAN_BAN");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmSoBuoiHocTrenTuan>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_SO_BUOI_HOC_TREN_TUAN");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmSucKhoeNuoiDuong>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_SUC_KHOE_NUOI_DUONG");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmTinh>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_TINH_1");

            entity.ToTable("DM_TINH");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.Cap)
                .HasMaxLength(50)
                .HasColumnName("CAP");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmTinhTrangCuTru>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_TINH_TRANG_CU_TRU");

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmToThon>(entity =>
        {
            entity.ToTable("DM_TO_THON");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(20)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

            entity.HasOne(d => d.IdHuyenNavigation).WithMany(p => p.DmToThons)
                .HasForeignKey(d => d.IdHuyen)
                .HasConstraintName("FK_DM_TO_THON_DM_HUYEN");

            entity.HasOne(d => d.MaTinhNavigation).WithMany(p => p.DmToThons)
                .HasForeignKey(d => d.MaTinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_TO_THON_DM_TINH");
        });

        modelBuilder.Entity<DmTonGiao>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_DM_TON_GIAO_1");

            entity.ToTable("DM_TON_GIAO");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmTrangThaiHocSinh>(entity =>
        {
            entity.HasKey(e => e.Ma);

            entity.ToTable("DM_TRANG_THAI_HOC_SINH");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaChuyenDenChuyenDi)
                .HasMaxLength(20)
                .HasColumnName("MA_CHUYEN_DEN_CHUYEN_DI");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<DmXa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DM_XA_1");

            entity.ToTable("DM_XA");

            entity.HasIndex(e => e.Ma, "IX_DM_XA");

            entity.HasIndex(e => e.MaTinh, "IX_DM_XA_2");

            entity.HasIndex(e => e.MaHuyen, "IX_DM_XA_3");

            entity.HasIndex(e => new { e.Ma, e.MaNamHoc }, "IX_KEY").IsUnique();

            entity.HasIndex(e => e.MaNamHoc, "IX_NAM_HOC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh }, "IX_NAM_HOC_TINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.IdHuyen }, "IX_NAM_HOC_TINH_HUYEN");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.Cap)
                .HasMaxLength(20)
                .HasColumnName("CAP");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IsVungKhoKhan).HasColumnName("IS_VUNG_KHO_KHAN");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXaSapNhap)
                .HasMaxLength(20)
                .HasColumnName("MA_XA_SAP_NHAP");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");

            entity.HasOne(d => d.IdHuyenNavigation).WithMany(p => p.DmXas)
                .HasForeignKey(d => d.IdHuyen)
                .HasConstraintName("FK_DM_XA_DM_HUYEN");

            entity.HasOne(d => d.MaTinhNavigation).WithMany(p => p.DmXas)
                .HasForeignKey(d => d.MaTinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_XA_DM_TINH");
        });

        modelBuilder.Entity<GroupUser>(entity =>
        {
            entity.ToTable("GroupUser");

            entity.HasIndex(e => new { e.GroupUserCode, e.TinhMa, e.XaMa }, "IX_KEY").IsUnique();

            entity.Property(e => e.GroupUserId).HasColumnName("GroupUserID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.GroupUserCode).HasMaxLength(50);
            entity.Property(e => e.GroupUserName).HasMaxLength(120);
            entity.Property(e => e.Isroot).HasColumnName("ISRoot");
            entity.Property(e => e.TinhMa)
                .HasMaxLength(50)
                .HasColumnName("TinhMA");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);
            entity.Property(e => e.XaMa)
                .HasMaxLength(50)
                .HasColumnName("XaMA");
        });

        modelBuilder.Entity<GroupUserMenu>(entity =>
        {
            entity.ToTable("GroupUserMenu");

            entity.HasIndex(e => new { e.MenuId, e.GroupUserId }, "IX_KEY").IsUnique();

            entity.Property(e => e.GroupUserMenuId)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GroupUserMenuID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.GroupUserId).HasColumnName("GroupUserID");
            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);

            entity.HasOne(d => d.GroupUser).WithMany(p => p.GroupUserMenus)
                .HasForeignKey(d => d.GroupUserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupUserMenu_GroupUser");

            entity.HasOne(d => d.Menu).WithMany(p => p.GroupUserMenus)
                .HasForeignKey(d => d.MenuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupUserMenu_Menu");
        });

        modelBuilder.Entity<HocSinh>(entity =>
        {
            entity.ToTable("HOC_SINH");

            entity.HasIndex(e => e.KeySystem, "IDX_HOC_SINH_KEY_SYSTEM");

            entity.HasIndex(e => e.MaSoDinhDanhCaNhan, "IDX_HOC_SINH_MA_SO_DINH_DANH_CA_NHAN");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaNamHoc }, "IDX_MA_SO_NAM_HOC_MA_TRUONG");

            entity.HasIndex(e => e.Ma, "IX_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaNamHoc, e.MaCapHoc, e.Ma }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaNamHoc, e.MaCapHoc }, "IX_SO_NAM_CAP_ID_TRUONG");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ApiMaBo)
                .HasMaxLength(50)
                .HasColumnName("API_MA_BO");
            entity.Property(e => e.ApiMaHcm)
                .HasMaxLength(50)
                .HasColumnName("API_MA_HCM");
            entity.Property(e => e.ChoOHienNay)
                .HasMaxLength(500)
                .HasColumnName("CHO_O_HIEN_NAY");
            entity.Property(e => e.DanTocTheoGiayKhaiSinh)
                .HasMaxLength(500)
                .HasColumnName("DAN_TOC_THEO_GIAY_KHAI_SINH");
            entity.Property(e => e.DienThoaiCha)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_CHA");
            entity.Property(e => e.DienThoaiLienHe)
                .HasMaxLength(50)
                .HasColumnName("DIEN_THOAI_LIEN_HE");
            entity.Property(e => e.DienThoaiMe)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_ME");
            entity.Property(e => e.DienThoaiNguoiDd)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_NGUOI_DD");
            entity.Property(e => e.HoTen)
                .HasMaxLength(150)
                .HasColumnName("HO_TEN");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdPhongGd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_PHONG_GD");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.IsCapGao).HasColumnName("IS_CAP_GAO");
            entity.Property(e => e.IsCapTienHangThang).HasColumnName("IS_CAP_TIEN_HANG_THANG");
            entity.Property(e => e.IsChaDt).HasColumnName("IS_CHA_DT");
            entity.Property(e => e.IsCoChipCccd).HasColumnName("IS_CO_CHIP_CCCD");
            entity.Property(e => e.IsDangHocK1).HasColumnName("IS_DANG_HOC_K1");
            entity.Property(e => e.IsDangHocK2).HasColumnName("IS_DANG_HOC_K2");
            entity.Property(e => e.IsGiamHocPhi).HasColumnName("IS_GIAM_HOC_PHI");
            entity.Property(e => e.IsHoNgheo).HasColumnName("IS_HO_NGHEO");
            entity.Property(e => e.IsHoTroAnTrua).HasColumnName("IS_HO_TRO_AN_TRUA");
            entity.Property(e => e.IsHoTroChiPhiHocTap).HasColumnName("IS_HO_TRO_CHI_PHI_HOC_TAP");
            entity.Property(e => e.IsHoTroNhaO).HasColumnName("IS_HO_TRO_NHA_O");
            entity.Property(e => e.IsHocCtgdCuaBo).HasColumnName("IS_HOC_CTGD_CUA_BO");
            entity.Property(e => e.IsHocLopMg5t).HasColumnName("IS_HOC_LOP_MG_5T");
            entity.Property(e => e.IsKhuyetTatKhongDanhGia).HasColumnName("IS_KHUYET_TAT_KHONG_DANH_GIA");
            entity.Property(e => e.IsMeDt).HasColumnName("IS_ME_DT");
            entity.Property(e => e.IsMienHocPhi).HasColumnName("IS_MIEN_HOC_PHI");
            entity.Property(e => e.IsTuyenMoiMn).HasColumnName("IS_TUYEN_MOI_MN");
            entity.Property(e => e.IsVungKk).HasColumnName("IS_VUNG_KK");
            entity.Property(e => e.KeySystem)
                .HasMaxLength(400)
                .HasColumnName("KEY_SYSTEM");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaCongDan)
                .HasMaxLength(20)
                .HasColumnName("MA_CONG_DAN");
            entity.Property(e => e.MaDanToc)
                .HasMaxLength(20)
                .HasColumnName("MA_DAN_TOC");
            entity.Property(e => e.MaDiaPhuong)
                .HasMaxLength(20)
                .HasColumnName("MA_DIA_PHUONG");
            entity.Property(e => e.MaDienChinhSach)
                .HasMaxLength(20)
                .HasColumnName("MA_DIEN_CHINH_SACH");
            entity.Property(e => e.MaGioiTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_GIOI_TINH");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(20)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaKhuVuc)
                .HasMaxLength(20)
                .HasColumnName("MA_KHU_VUC");
            entity.Property(e => e.MaLoaiBoThuongBinh)
                .HasMaxLength(20)
                .HasColumnName("MA_LOAI_BO_THUONG_BINH");
            entity.Property(e => e.MaLoaiKhuyetTat)
                .HasMaxLength(20)
                .HasColumnName("MA_LOAI_KHUYET_TAT");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaQuocTich)
                .HasMaxLength(20)
                .HasColumnName("MA_QUOC_TICH");
            entity.Property(e => e.MaSoDinhDanhCaNhan)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_DINH_DANH_CA_NHAN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTonGiao)
                .HasMaxLength(20)
                .HasColumnName("MA_TON_GIAO");
            entity.Property(e => e.MaTrangThaiHienTai)
                .HasMaxLength(20)
                .HasColumnName("MA_TRANG_THAI_HIEN_TAI");
            entity.Property(e => e.MaTrangThaiK1)
                .HasMaxLength(20)
                .HasColumnName("MA_TRANG_THAI_K1");
            entity.Property(e => e.MaTrangThaiK2)
                .HasMaxLength(20)
                .HasColumnName("MA_TRANG_THAI_K2");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(20)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(20)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NamSinhCha).HasColumnName("NAM_SINH_CHA");
            entity.Property(e => e.NamSinhMe).HasColumnName("NAM_SINH_ME");
            entity.Property(e => e.NamSinhNguoiDoDau).HasColumnName("NAM_SINH_NGUOI_DO_DAU");
            entity.Property(e => e.NgaySinh).HasColumnName("NGAY_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NgayTrangThai).HasColumnName("NGAY_TRANG_THAI");
            entity.Property(e => e.NgheNghiepCha)
                .HasMaxLength(250)
                .HasColumnName("NGHE_NGHIEP_CHA");
            entity.Property(e => e.NgheNghiepMe)
                .HasMaxLength(250)
                .HasColumnName("NGHE_NGHIEP_ME");
            entity.Property(e => e.NgheNghiepNguoiDd)
                .HasMaxLength(250)
                .HasColumnName("NGHE_NGHIEP_NGUOI_DD");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.NoiSinh)
                .HasMaxLength(500)
                .HasColumnName("NOI_SINH");
            entity.Property(e => e.QueQuan)
                .HasMaxLength(500)
                .HasColumnName("QUE_QUAN");
            entity.Property(e => e.TenCha)
                .HasMaxLength(500)
                .HasColumnName("TEN_CHA");
            entity.Property(e => e.TenMe)
                .HasMaxLength(150)
                .HasColumnName("TEN_ME");
            entity.Property(e => e.TenNguoiDd)
                .HasMaxLength(150)
                .HasColumnName("TEN_NGUOI_DD");
            entity.Property(e => e.ThonXom)
                .HasMaxLength(500)
                .HasColumnName("THON_XOM");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.UrlAnhDaiDien)
                .HasMaxLength(300)
                .HasColumnName("URL_ANH_DAI_DIEN");
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LOP_1");

            entity.ToTable("LOP");

            entity.HasIndex(e => new { e.Ma, e.MaNamHoc, e.MaSoGd, e.MaTruong, e.MaCapHoc, e.Ten }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ApiMaHcm)
                .HasMaxLength(50)
                .HasColumnName("API_MA_HCM");
            entity.Property(e => e.IdGiaoVienChuNhiem)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_GIAO_VIEN_CHU_NHIEM");
            entity.Property(e => e.IdGiaoVienChuNhiemKy2)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_GIAO_VIEN_CHU_NHIEM_KY2");
            entity.Property(e => e.IdPhongGd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_PHONG_GD");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaGiaoVienChuNhiem)
                .HasMaxLength(20)
                .HasColumnName("MA_GIAO_VIEN_CHU_NHIEM");
            entity.Property(e => e.MaGuid).HasColumnName("MA_GUID");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(20)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaKieuLop)
                .HasMaxLength(20)
                .HasColumnName("MA_KIEU_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(20)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaPhanBan)
                .HasMaxLength(20)
                .HasColumnName("MA_PHAN_BAN");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(20)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(50)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
            entity.Property(e => e.TrangThaiKy2).HasColumnName("TRANG_THAI_KY2");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.ToTable("Menu");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.DesHelp).HasMaxLength(250);
            entity.Property(e => e.Icon).HasMaxLength(150);
            entity.Property(e => e.Link).HasMaxLength(150);
            entity.Property(e => e.LinkYoutube).HasMaxLength(150);
            entity.Property(e => e.MenuCode).HasMaxLength(100);
            entity.Property(e => e.MenuName).HasMaxLength(120);
            entity.Property(e => e.MenuNameEg)
                .HasMaxLength(120)
                .HasColumnName("MenuNameEG");
            entity.Property(e => e.Order).HasMaxLength(20);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);
        });

        modelBuilder.Entity<NamHoc>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_NAM_HOC_1");

            entity.ToTable("NAM_HOC");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .ValueGeneratedNever()
                .HasColumnName("MA");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.ToTable("NGUOI_DUNG");

            entity.HasIndex(e => new { e.TenDangNhap, e.MaCapDonViHc, e.MaTinh, e.MaHuyen, e.MaXa }, "IX_KEY").IsUnique();

            entity.HasIndex(e => e.MaCapDonViHc, "IX_NGUOI_DUNG_10");

            entity.HasIndex(e => e.MaTinh, "IX_NGUOI_DUNG_2");

            entity.HasIndex(e => e.MaHuyen, "IX_NGUOI_DUNG_3");

            entity.HasIndex(e => e.MaXa, "IX_NGUOI_DUNG_4");

            entity.HasIndex(e => e.TenDangNhap, "IX_NGUOI_DUNG_5");

            entity.HasIndex(e => e.MatKhau, "IX_NGUOI_DUNG_6");

            entity.HasIndex(e => e.TrangThai, "IX_NGUOI_DUNG_7");

            entity.HasIndex(e => e.IsRoot, "IX_NGUOI_DUNG_8");

            entity.HasIndex(e => e.IsRootSys, "IX_NGUOI_DUNG_9");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.DienThoaiDiDong)
                .HasMaxLength(250)
                .HasColumnName("DIEN_THOAI_DI_DONG");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.GroupUserId).HasColumnName("GroupUserID");
            entity.Property(e => e.HoTen)
                .HasMaxLength(150)
                .HasColumnName("HO_TEN");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .HasColumnName("IP");
            entity.Property(e => e.IsRoot).HasColumnName("IS_ROOT");
            entity.Property(e => e.IsRootSys).HasColumnName("IS_ROOT_SYS");
            entity.Property(e => e.IsUpdate).HasColumnName("IS_UPDATE");
            entity.Property(e => e.MaCapDonViHc)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_DON_VI_HC");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaKhoiPhucMatKhau)
                .HasMaxLength(100)
                .HasColumnName("MA_KHOI_PHUC_MAT_KHAU");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(20)
                .HasColumnName("MA_XA");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(250)
                .HasColumnName("MAT_KHAU");
            entity.Property(e => e.MatKhauBackup)
                .HasMaxLength(250)
                .HasColumnName("MAT_KHAU_BACKUP");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TenDangNhap)
                .HasMaxLength(50)
                .HasColumnName("TEN_DANG_NHAP");
            entity.Property(e => e.TenHienThi)
                .HasMaxLength(250)
                .HasColumnName("TEN_HIEN_THI");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<NguoiDungToThon>(entity =>
        {
            entity.ToTable("NGUOI_DUNG_TO_THON");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdNguoiDung)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_NGUOI_DUNG");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");

            entity.HasOne(d => d.IdToThonNavigation).WithMany(p => p.NguoiDungToThons)
                .HasForeignKey(d => d.IdToThon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_NGUOI_DUNG_TO_THON_DM_TO_THON");
        });

        modelBuilder.Entity<NhanSu>(entity =>
        {
            entity.ToTable("NHAN_SU");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ApiMaBo)
                .HasMaxLength(50)
                .HasColumnName("API_MA_BO");
            entity.Property(e => e.DiDong)
                .HasMaxLength(50)
                .HasColumnName("DI_DONG");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("EMAIL");
            entity.Property(e => e.HoTen)
                .HasMaxLength(150)
                .HasColumnName("HO_TEN");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdPhongGd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_PHONG_GD");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.IsC1).HasColumnName("IS_C1");
            entity.Property(e => e.IsC2).HasColumnName("IS_C2");
            entity.Property(e => e.IsC3).HasColumnName("IS_C3");
            entity.Property(e => e.IsCoChipCccd).HasColumnName("IS_CO_CHIP_CCCD");
            entity.Property(e => e.IsGdtx).HasColumnName("IS_GDTX");
            entity.Property(e => e.IsMn).HasColumnName("IS_MN");
            entity.Property(e => e.IsTrangThaiKy1).HasColumnName("IS_TRANG_THAI_KY_1");
            entity.Property(e => e.IsTrangThaiKy2).HasColumnName("IS_TRANG_THAI_KY_2");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaCapDonVi)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_DON_VI");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaCapHocChinh)
                .HasMaxLength(10)
                .HasColumnName("MA_CAP_HOC_CHINH");
            entity.Property(e => e.MaDanToc)
                .HasMaxLength(20)
                .HasColumnName("MA_DAN_TOC");
            entity.Property(e => e.MaGioiTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_GIOI_TINH");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaLoaiCanBo)
                .HasMaxLength(20)
                .HasColumnName("MA_LOAI_CAN_BO");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomCanBo)
                .HasMaxLength(20)
                .HasColumnName("MA_NHOM_CAN_BO");
            entity.Property(e => e.MaNuoc)
                .HasMaxLength(20)
                .HasColumnName("MA_NUOC");
            entity.Property(e => e.MaPhongBan)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_BAN");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoDinhDanhCaNhan)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_DINH_DANH_CA_NHAN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTonGiao)
                .HasMaxLength(20)
                .HasColumnName("MA_TON_GIAO");
            entity.Property(e => e.MaTrangThaiCanBo)
                .HasMaxLength(20)
                .HasColumnName("MA_TRANG_THAI_CAN_BO");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(20)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(20)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgayCap).HasColumnName("NGAY_CAP");
            entity.Property(e => e.NgaySinh).HasColumnName("NGAY_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.NoiCap)
                .HasMaxLength(500)
                .HasColumnName("NOI_CAP");
            entity.Property(e => e.NoiSinh)
                .HasMaxLength(500)
                .HasColumnName("NOI_SINH");
            entity.Property(e => e.SoCmtnd)
                .HasMaxLength(200)
                .HasColumnName("SO_CMTND");
            entity.Property(e => e.Ten)
                .HasMaxLength(200)
                .HasColumnName("TEN");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
            entity.Property(e => e.UrlAnhDaiDien)
                .HasMaxLength(300)
                .HasColumnName("URL_ANH_DAI_DIEN");
        });

        modelBuilder.Entity<NhanSuLopChuNhiem>(entity =>
        {
            entity.ToTable("NHAN_SU_LOP_CHU_NHIEM");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => e.IdNhanSu, "IX_NHAN_SU_LOP_CHU_NHIEM_ID_NHAN_SU");

            entity.HasIndex(e => e.IdTruong, "IX_NHAN_SU_LOP_CHU_NHIEM_ID_TRUONG");

            entity.HasIndex(e => e.MaNamHoc, "IX_NHAN_SU_LOP_CHU_NHIEM_MA_NAM_HOC");

            entity.HasIndex(e => e.MaSoGd, "IX_NHAN_SU_LOP_CHU_NHIEM_MA_SOGD");

            entity.HasIndex(e => e.MaTruong, "IX_NHAN_SU_LOP_CHU_NHIEM_MA_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdPhongGd, e.MaPhongGd, e.IdTruong, e.MaTruong, e.IdLop, e.IdNhanSu, e.HocKy }, "NHAN_SU_LOP_CHU_NHIEM_MA_NAM_HOC_MA_SO_GD_ID_PHONG_GD_MA_PHONG_GD_ID_TRUONG_MA_TRUONG_ID_LOP_ID_NHAN_SU").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdNhanSu)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_NHAN_SU");
            entity.Property(e => e.IdPhongGd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_PHONG_GD");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(20)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<PhieuDieuTra>(entity =>
        {
            entity.ToTable("PHIEU_DIEU_TRA");

            entity.HasIndex(e => new { e.MaTinh, e.MaHuyen, e.MaXa, e.MaNamHoc, e.SoPhieu }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(1000)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.HoChuHo)
                .HasMaxLength(150)
                .HasColumnName("HO_CHU_HO");
            entity.Property(e => e.HoTenChuHo)
                .HasMaxLength(150)
                .HasColumnName("HO_TEN_CHU_HO");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.MaDienCuTru)
                .HasMaxLength(50)
                .HasColumnName("MA_DIEN_CU_TRU");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(50)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(50)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTinhTrangCuTru)
                .HasMaxLength(50)
                .HasColumnName("MA_TINH_TRANG_CU_TRU");
            entity.Property(e => e.MaToThon)
                .HasMaxLength(50)
                .HasColumnName("MA_TO_THON");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgayDieuTra)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_DIEU_TRA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(50)
                .HasColumnName("SO_DIEN_THOAI");
            entity.Property(e => e.SoPhieu)
                .HasMaxLength(150)
                .HasColumnName("SO_PHIEU");
            entity.Property(e => e.TenChuHo)
                .HasMaxLength(150)
                .HasColumnName("TEN_CHU_HO");

            entity.HasOne(d => d.IdToThonNavigation).WithMany(p => p.PhieuDieuTras)
                .HasForeignKey(d => d.IdToThon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_DIEU_TRA_DM_TO_THON");
        });

        modelBuilder.Entity<PhieuDieuTraCt>(entity =>
        {
            entity.ToTable("PHIEU_DIEU_TRA_CT");

            entity.HasIndex(e => new { e.MaTinh, e.MaHuyen, e.MaXa, e.MaNamHoc, e.SoPhieu, e.CanCuocCongDan }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CanCuocCongDan)
                .HasMaxLength(50)
                .HasColumnName("CAN_CUOC_CONG_DAN");
            entity.Property(e => e.ChiTietHoanCanhDacBiet)
                .HasMaxLength(500)
                .HasColumnName("CHI_TIET_HOAN_CANH_DAC_BIET");
            entity.Property(e => e.DienUuTien)
                .HasMaxLength(200)
                .HasColumnName("DIEN_UU_TIEN");
            entity.Property(e => e.DsMaSucKhoeNuoiDuong)
                .HasMaxLength(50)
                .HasColumnName("DS_MA_SUC_KHOE_NUOI_DUONG");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.Ho)
                .HasMaxLength(150)
                .HasColumnName("HO");
            entity.Property(e => e.HoTen)
                .HasMaxLength(150)
                .HasColumnName("HO_TEN");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdHuyenHocTap)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN_HOC_TAP");
            entity.Property(e => e.IdPhieuDieuTra).HasColumnName("ID_PHIEU_DIEU_TRA");
            entity.Property(e => e.IdToThon)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TO_THON");
            entity.Property(e => e.IdTruongHocTap)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG_HOC_TAP");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.IsAnBanTru).HasColumnName("IS_AN_BAN_TRU");
            entity.Property(e => e.IsChuyenCan).HasColumnName("IS_CHUYEN_CAN");
            entity.Property(e => e.IsCoChungNhanKhuyetTat).HasColumnName("IS_CO_CHUNG_NHAN_KHUYET_TAT");
            entity.Property(e => e.IsCoKhaNangHocTap).HasColumnName("IS_CO_KHA_NANG_HOC_TAP");
            entity.Property(e => e.IsHocDayDuTheoQuyDinh).HasColumnName("IS_HOC_DAY_DU_THEO_QUY_DINH");
            entity.Property(e => e.IsHocHeBoTuc).HasColumnName("IS_HOC_HE_BO_TUC");
            entity.Property(e => e.IsLuuBanNamTruoc).HasColumnName("IS_LUU_BAN_NAM_TRUOC");
            entity.Property(e => e.IsTotNghiepHeBoTuc).HasColumnName("IS_TOT_NGHIEP_HE_BO_TUC");
            entity.Property(e => e.IsTotNghiepThcsHeBoTuc).HasColumnName("IS_TOT_NGHIEP_THCS_HE_BO_TUC");
            entity.Property(e => e.IsTreDanTocDuocChuanBiTiengViet).HasColumnName("IS_TRE_DAN_TOC_DUOC_CHUAN_BI_TIENG_VIET");
            entity.Property(e => e.IsTrongDiaBanHocTap).HasColumnName("IS_TRONG_DIA_BAN_HOC_TAP");
            entity.Property(e => e.MaBacTotNghiepNghe)
                .HasMaxLength(50)
                .HasColumnName("MA_BAC_TOT_NGHIEP_NGHE");
            entity.Property(e => e.MaBacTotNghiepPhoThong)
                .HasMaxLength(50)
                .HasColumnName("MA_BAC_TOT_NGHIEP_PHO_THONG");
            entity.Property(e => e.MaBoHocLop)
                .HasMaxLength(50)
                .HasColumnName("MA_BO_HOC_LOP");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaDanToc)
                .HasMaxLength(50)
                .HasColumnName("MA_DAN_TOC");
            entity.Property(e => e.MaDienCuTru)
                .HasMaxLength(50)
                .HasColumnName("MA_DIEN_CU_TRU");
            entity.Property(e => e.MaGioiTinh)
                .HasMaxLength(50)
                .HasColumnName("MA_GIOI_TINH");
            entity.Property(e => e.MaHoanCanhDacBiet)
                .HasMaxLength(50)
                .HasColumnName("MA_HOAN_CANH_DAC_BIET");
            entity.Property(e => e.MaHoanThanhXoaMuChuLop)
                .HasMaxLength(50)
                .HasColumnName("MA_HOAN_THANH_XOA_MU_CHU_LOP");
            entity.Property(e => e.MaHocXoaMuChuLop)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_XOA_MU_CHU_LOP");
            entity.Property(e => e.MaHocXongLop)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_XONG_LOP");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(50)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaHuyenHocTap)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN_HOC_TAP");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLoaiKhuyetTat)
                .HasMaxLength(50)
                .HasColumnName("MA_LOAI_KHUYET_TAT");
            entity.Property(e => e.MaMucTaiMuChu)
                .HasMaxLength(50)
                .HasColumnName("MA_MUC_TAI_MU_CHU");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoBuoiHocTrenTuan)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_BUOI_HOC_TREN_TUAN");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(50)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTinhHocTap)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH_HOC_TAP");
            entity.Property(e => e.MaTinhTrangCuTru)
                .HasMaxLength(50)
                .HasColumnName("MA_TINH_TRANG_CU_TRU");
            entity.Property(e => e.MaToThon)
                .HasMaxLength(50)
                .HasColumnName("MA_TO_THON");
            entity.Property(e => e.MaTonGiao)
                .HasMaxLength(50)
                .HasColumnName("MA_TON_GIAO");
            entity.Property(e => e.MaTruongHocTap)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG_HOC_TAP");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NamBoHocLop)
                .HasMaxLength(50)
                .HasColumnName("NAM_BO_HOC_LOP");
            entity.Property(e => e.NamHocXongLop)
                .HasMaxLength(50)
                .HasColumnName("NAM_HOC_XONG_LOP");
            entity.Property(e => e.NamTotNghiepNghe)
                .HasMaxLength(50)
                .HasColumnName("NAM_TOT_NGHIEP_NGHE");
            entity.Property(e => e.NamTotNghiepPhoThong)
                .HasMaxLength(50)
                .HasColumnName("NAM_TOT_NGHIEP_PHO_THONG");
            entity.Property(e => e.NgaySinh).HasColumnName("NGAY_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NgayTrangThai).HasColumnName("NGAY_TRANG_THAI");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.QuanHeKhac)
                .HasMaxLength(200)
                .HasColumnName("QUAN_HE_KHAC");
            entity.Property(e => e.QuanHeVoiChuHo)
                .HasMaxLength(200)
                .HasColumnName("QUAN_HE_VOI_CHU_HO");
            entity.Property(e => e.SoBangTotNghiep)
                .HasMaxLength(50)
                .HasColumnName("SO_BANG_TOT_NGHIEP");
            entity.Property(e => e.SoPhieu)
                .HasMaxLength(50)
                .HasColumnName("SO_PHIEU");
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
            entity.Property(e => e.TenCha)
                .HasMaxLength(150)
                .HasColumnName("TEN_CHA");
            entity.Property(e => e.TenLop)
                .HasMaxLength(50)
                .HasColumnName("TEN_LOP");
            entity.Property(e => e.TenMe)
                .HasMaxLength(150)
                .HasColumnName("TEN_ME");
            entity.Property(e => e.TenNguoiDd)
                .HasMaxLength(150)
                .HasColumnName("TEN_NGUOI_DD");
        });

        modelBuilder.Entity<PhieuDieuTraTraiTuyen>(entity =>
        {
            entity.ToTable("PHIEU_DIEU_TRA_TRAI_TUYEN");

            entity.HasIndex(e => new { e.MaTinh, e.MaHuyen, e.MaXa, e.MaNamHoc, e.CanCuocCongDan }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CanCuocCongDan)
                .HasMaxLength(50)
                .HasColumnName("CAN_CUOC_CONG_DAN");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(1000)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DsMaSucKhoeNuoiDuong)
                .HasMaxLength(50)
                .HasColumnName("DS_MA_SUC_KHOE_NUOI_DUONG");
            entity.Property(e => e.Ho)
                .HasMaxLength(150)
                .HasColumnName("HO");
            entity.Property(e => e.HoTen)
                .HasMaxLength(150)
                .HasColumnName("HO_TEN");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdHuyenDiaChi)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN_DIA_CHI");
            entity.Property(e => e.IdTruongHocTap)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG_HOC_TAP");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.IdXaDiaChi)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA_DIA_CHI");
            entity.Property(e => e.IsAnBanTru).HasColumnName("IS_AN_BAN_TRU");
            entity.Property(e => e.IsChuyenCan).HasColumnName("IS_CHUYEN_CAN");
            entity.Property(e => e.IsCoChungNhanKhuyetTat).HasColumnName("IS_CO_CHUNG_NHAN_KHUYET_TAT");
            entity.Property(e => e.IsCoKhaNangHocTap).HasColumnName("IS_CO_KHA_NANG_HOC_TAP");
            entity.Property(e => e.IsHocDayDuTheoQuyDinh).HasColumnName("IS_HOC_DAY_DU_THEO_QUY_DINH");
            entity.Property(e => e.IsLuuBanNamTruoc).HasColumnName("IS_LUU_BAN_NAM_TRUOC");
            entity.Property(e => e.IsTotNghiepHeBoTuc).HasColumnName("IS_TOT_NGHIEP_HE_BO_TUC");
            entity.Property(e => e.IsTotNghiepThcsHeBoTuc).HasColumnName("IS_TOT_NGHIEP_THCS_HE_BO_TUC");
            entity.Property(e => e.IsTreDanTocDuocChuanBiTiengViet).HasColumnName("IS_TRE_DAN_TOC_DUOC_CHUAN_BI_TIENG_VIET");
            entity.Property(e => e.MaBacTotNghiepPhoThong)
                .HasMaxLength(50)
                .HasColumnName("MA_BAC_TOT_NGHIEP_PHO_THONG");
            entity.Property(e => e.MaBoHocLop)
                .HasMaxLength(50)
                .HasColumnName("MA_BO_HOC_LOP");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaDanToc)
                .HasMaxLength(50)
                .HasColumnName("MA_DAN_TOC");
            entity.Property(e => e.MaGioiTinh)
                .HasMaxLength(50)
                .HasColumnName("MA_GIOI_TINH");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(50)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaHuyenDiaChi)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN_DIA_CHI");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLoaiKhuyetTat)
                .HasMaxLength(50)
                .HasColumnName("MA_LOAI_KHUYET_TAT");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoBuoiHocTrenTuan)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_BUOI_HOC_TREN_TUAN");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(50)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTinhDiaChi)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH_DIA_CHI");
            entity.Property(e => e.MaTonGiao)
                .HasMaxLength(50)
                .HasColumnName("MA_TON_GIAO");
            entity.Property(e => e.MaTruongHocTap)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG_HOC_TAP");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.MaXaDiaChi)
                .HasMaxLength(20)
                .HasColumnName("MA_XA_DIA_CHI");
            entity.Property(e => e.NamBoHocLop)
                .HasMaxLength(50)
                .HasColumnName("NAM_BO_HOC_LOP");
            entity.Property(e => e.NamTotNghiepPhoThong)
                .HasMaxLength(50)
                .HasColumnName("NAM_TOT_NGHIEP_PHO_THONG");
            entity.Property(e => e.NgaySinh).HasColumnName("NGAY_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.SoBangTotNghiep)
                .HasMaxLength(50)
                .HasColumnName("SO_BANG_TOT_NGHIEP");
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
            entity.Property(e => e.TenLop)
                .HasMaxLength(50)
                .HasColumnName("TEN_LOP");
        });

        modelBuilder.Entity<PhongBan>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_PHONG_BAN_1");

            entity.ToTable("PHONG_BAN");

            entity.HasIndex(e => new { e.MaDonVi, e.MaCapDonVi }, "IX_CAP_DON_VI_DON_VI");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaDonVi, e.MaCapDonVi, e.Ten }, "IX_KEY_2").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(250)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(250)
                .HasColumnName("FAX");
            entity.Property(e => e.MaBaoCao)
                .HasMaxLength(20)
                .HasColumnName("MA_BAO_CAO");
            entity.Property(e => e.MaCapDonVi)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_DON_VI");
            entity.Property(e => e.MaDonVi)
                .HasMaxLength(20)
                .HasColumnName("MA_DON_VI");
            entity.Property(e => e.MaNhomQuyen)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_QUYEN");
            entity.Property(e => e.MaParent)
                .HasMaxLength(20)
                .HasColumnName("MA_PARENT");
            entity.Property(e => e.MaPhanCap)
                .HasMaxLength(500)
                .HasColumnName("MA_PHAN_CAP");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu)
                .HasMaxLength(50)
                .HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
            entity.Property(e => e.TruongDonVi)
                .HasMaxLength(50)
                .HasColumnName("TRUONG_DON_VI");
            entity.Property(e => e.Website)
                .HasMaxLength(250)
                .HasColumnName("WEBSITE");

            entity.HasOne(d => d.MaCapDonViNavigation).WithMany(p => p.PhongBans)
                .HasForeignKey(d => d.MaCapDonVi)
                .HasConstraintName("FK_PHONG_BAN_DM_CAP_DON_VI");
        });

        modelBuilder.Entity<PhongGd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PHONG_GD_1");

            entity.ToTable("PHONG_GD");

            entity.HasIndex(e => new { e.Ma, e.MaNamHoc }, "IX_KEY").IsUnique();

            entity.HasIndex(e => e.MaNamHoc, "IX_NAM_HOC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd }, "IX_SO_NAM_HOC");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.CanBoPhuTrach)
                .HasMaxLength(250)
                .HasColumnName("CAN_BO_PHU_TRACH");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(250)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI");
            entity.Property(e => e.DienThoaiCanBoPhuTrach)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_CAN_BO_PHU_TRACH");
            entity.Property(e => e.DienThoaiTruongPhong)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_TRUONG_PHONG");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailCanBoPhuTrach)
                .HasMaxLength(250)
                .HasColumnName("EMAIL_CAN_BO_PHU_TRACH");
            entity.Property(e => e.EmailTruongPhong)
                .HasMaxLength(250)
                .HasColumnName("EMAIL_TRUONG_PHONG");
            entity.Property(e => e.Fax)
                .HasMaxLength(250)
                .HasColumnName("FAX");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
            entity.Property(e => e.TruongPhong)
                .HasMaxLength(250)
                .HasColumnName("TRUONG_PHONG");
            entity.Property(e => e.Website)
                .HasMaxLength(250)
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.ToTable("RefreshToken");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ExpDate).HasColumnType("datetime");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(50)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(50)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(50)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NguoiDungId).HasColumnType("numeric(18, 0)");

            entity.HasOne(d => d.NguoiDung).WithMany(p => p.RefreshTokens)
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RefreshToken_NGUOI_DUNG");
        });

        modelBuilder.Entity<SoGd>(entity =>
        {
            entity.HasKey(e => e.Ma).HasName("PK_SO_GD_1");

            entity.ToTable("SO_GD");

            entity.HasIndex(e => e.Ma, "IX_KEY").IsUnique();

            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.ChanhVanPhong)
                .HasMaxLength(250)
                .HasColumnName("CHANH_VAN_PHONG");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(250)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI");
            entity.Property(e => e.DienThoaiChanhVanPhong)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_CHANH_VAN_PHONG");
            entity.Property(e => e.DienThoaiGiamDoc)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_GIAM_DOC");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailChanhVanPhong)
                .HasMaxLength(250)
                .HasColumnName("EMAIL_CHANH_VAN_PHONG");
            entity.Property(e => e.EmailGiamDoc)
                .HasMaxLength(250)
                .HasColumnName("EMAIL_GIAM_DOC");
            entity.Property(e => e.Fax)
                .HasMaxLength(250)
                .HasColumnName("FAX");
            entity.Property(e => e.GiamDoc)
                .HasMaxLength(250)
                .HasColumnName("GIAM_DOC");
            entity.Property(e => e.MaSource)
                .HasMaxLength(20)
                .HasColumnName("MA_SOURCE");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.TenDiaPhuong)
                .HasMaxLength(200)
                .HasColumnName("TEN_DIA_PHUONG");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
            entity.Property(e => e.Website)
                .HasMaxLength(250)
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<ThongBaoDieuHanh>(entity =>
        {
            entity.ToTable("THONG_BAO_DIEU_HANH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CapThongBao).HasColumnName("CAP_THONG_BAO");
            entity.Property(e => e.IsGuiEmail).HasColumnName("IS_GUI_EMAIL");
            entity.Property(e => e.LoaiThongBao).HasColumnName("LOAI_THONG_BAO");
            entity.Property(e => e.LuotXem).HasColumnName("LUOT_XEM");
            entity.Property(e => e.MoTa)
                .HasMaxLength(500)
                .HasColumnName("MO_TA");
            entity.Property(e => e.NgayBatDau)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_BAT_DAU");
            entity.Property(e => e.NgayKetThuc)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_KET_THUC");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(250)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(250)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.NoiDung).HasColumnName("NOI_DUNG");
            entity.Property(e => e.TieuDe)
                .HasMaxLength(250)
                .HasColumnName("TIEU_DE");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
            entity.Property(e => e.UrlAnh)
                .HasMaxLength(250)
                .HasColumnName("URL_ANH");
        });

        modelBuilder.Entity<ThongBaoDoiTuong>(entity =>
        {
            entity.ToTable("THONG_BAO_DOI_TUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdThongBaoDieuHanh).HasColumnName("ID_THONG_BAO_DIEU_HANH");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(250)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(250)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(250)
                .HasColumnName("MA_XA");
        });

        modelBuilder.Entity<Truong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TRUONG_1");

            entity.ToTable("TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.Ma }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd }, "IX_NAM_SO");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh }, "IX_NAM_TINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen }, "IX_NAM_TINH_HUYEN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaTinh, e.MaHuyen, e.MaXa }, "IX_NAM_TINH_HUYEN_XA");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(1000)
                .HasColumnName("DIA_CHI");
            entity.Property(e => e.DienThoai)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI");
            entity.Property(e => e.DienThoaiHieuTruong)
                .HasMaxLength(20)
                .HasColumnName("DIEN_THOAI_HIEU_TRUONG");
            entity.Property(e => e.DsCapHoc)
                .HasMaxLength(20)
                .HasColumnName("DS_CAP_HOC");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailHieuTruong)
                .HasMaxLength(250)
                .HasColumnName("EMAIL_HIEU_TRUONG");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .HasColumnName("FAX");
            entity.Property(e => e.HieuTruong)
                .HasMaxLength(250)
                .HasColumnName("HIEU_TRUONG");
            entity.Property(e => e.IdHuyen)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HUYEN");
            entity.Property(e => e.IdPhongGd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_PHONG_GD");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IdXa)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_XA");
            entity.Property(e => e.IsCapGdtx).HasColumnName("IS_CAP_GDTX");
            entity.Property(e => e.IsCapMn).HasColumnName("IS_CAP_MN");
            entity.Property(e => e.IsCapTh).HasColumnName("IS_CAP_TH");
            entity.Property(e => e.IsCapThcs).HasColumnName("IS_CAP_THCS");
            entity.Property(e => e.IsCapThpt).HasColumnName("IS_CAP_THPT");
            entity.Property(e => e.IsCoChiBoDang).HasColumnName("IS_CO_CHI_BO_DANG");
            entity.Property(e => e.IsCoLopNho).HasColumnName("IS_CO_LOP_NHO");
            entity.Property(e => e.IsDatChuanQg).HasColumnName("IS_DAT_CHUAN_QG");
            entity.Property(e => e.IsNhoDuoi).HasColumnName("IS_NHO_DUOI");
            entity.Property(e => e.IsNhoTren).HasColumnName("IS_NHO_TREN");
            entity.Property(e => e.IsTruongQuocTe).HasColumnName("IS_TRUONG_QUOC_TE");
            entity.Property(e => e.KinhTuyen)
                .HasMaxLength(50)
                .HasColumnName("KINH_TUYEN");
            entity.Property(e => e.LopCapGdtx).HasColumnName("LOP_CAP_GDTX");
            entity.Property(e => e.LopCapMn).HasColumnName("LOP_CAP_MN");
            entity.Property(e => e.LopCapMn5t).HasColumnName("LOP_CAP_MN_5T");
            entity.Property(e => e.LopCapTh).HasColumnName("LOP_CAP_TH");
            entity.Property(e => e.LopCapThcs).HasColumnName("LOP_CAP_THCS");
            entity.Property(e => e.LopCapThpt).HasColumnName("LOP_CAP_THPT");
            entity.Property(e => e.Ma)
                .HasMaxLength(20)
                .HasColumnName("MA");
            entity.Property(e => e.MaDatChuanDanhGiaClgd)
                .HasMaxLength(20)
                .HasColumnName("MA_DAT_CHUAN_DANH_GIA_CLGD");
            entity.Property(e => e.MaDuAn)
                .HasMaxLength(20)
                .HasColumnName("MA_DU_AN");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(20)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaKhuVuc)
                .HasMaxLength(20)
                .HasColumnName("MA_KHU_VUC");
            entity.Property(e => e.MaLoaiHinhTruong)
                .HasMaxLength(20)
                .HasColumnName("MA_LOAI_HINH_TRUONG");
            entity.Property(e => e.MaLoaiTruong)
                .HasMaxLength(20)
                .HasColumnName("MA_LOAI_TRUONG");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomCapHoc)
                .HasMaxLength(20)
                .HasColumnName("MA_NHOM_CAP_HOC");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(20)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaTrucThuoc)
                .HasMaxLength(20)
                .HasColumnName("MA_TRUC_THUOC");
            entity.Property(e => e.MaVung)
                .HasMaxLength(20)
                .HasColumnName("MA_VUNG");
            entity.Property(e => e.MaXa)
                .HasMaxLength(20)
                .HasColumnName("MA_XA");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.SoDiemTruong).HasColumnName("SO_DIEM_TRUONG");
            entity.Property(e => e.Ten)
                .HasMaxLength(200)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
            entity.Property(e => e.ViTriBanDo)
                .HasMaxLength(50)
                .HasColumnName("VI_TRI_BAN_DO");
            entity.Property(e => e.ViTuyen)
                .HasMaxLength(50)
                .HasColumnName("VI_TUYEN");
            entity.Property(e => e.Website)
                .HasMaxLength(250)
                .HasColumnName("WEBSITE");
        });

        modelBuilder.Entity<XemThongBao>(entity =>
        {
            entity.ToTable("XEM_THONG_BAO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdNguoiDung)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_NGUOI_DUNG");
            entity.Property(e => e.IdThongBaoDieuHanh).HasColumnName("ID_THONG_BAO_DIEU_HANH");
            entity.Property(e => e.MaHuyen)
                .HasMaxLength(250)
                .HasColumnName("MA_HUYEN");
            entity.Property(e => e.MaTinh)
                .HasMaxLength(250)
                .HasColumnName("MA_TINH");
            entity.Property(e => e.MaXa)
                .HasMaxLength(250)
                .HasColumnName("MA_XA");
            entity.Property(e => e.ThoiGianXem)
                .HasColumnType("datetime")
                .HasColumnName("THOI_GIAN_XEM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
