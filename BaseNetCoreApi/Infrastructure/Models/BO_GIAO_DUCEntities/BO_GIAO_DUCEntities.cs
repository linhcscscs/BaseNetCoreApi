using System;
using System.Collections.Generic;
using BaseNetCoreApi.Models.BO_GIAO_DUCEntities;
using Microsoft.EntityFrameworkCore;

namespace BaseNetCoreApi.Infrastructure.Models.BO_GIAO_DUCEntities;

public partial class BO_GIAO_DUCEntities : DbContext
{
    public BO_GIAO_DUCEntities()
    {
    }

    public BO_GIAO_DUCEntities(DbContextOptions<BO_GIAO_DUCEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<Api> Apis { get; set; }

    public virtual DbSet<ApiToken> ApiTokens { get; set; }

    public virtual DbSet<CapMaBienLai> CapMaBienLais { get; set; }

    public virtual DbSet<CapMaHocSinh> CapMaHocSinhs { get; set; }

    public virtual DbSet<CapMaPhieuThu> CapMaPhieuThus { get; set; }

    public virtual DbSet<CauHinhApiCsdl> CauHinhApiCsdls { get; set; }

    public virtual DbSet<CauHinhPhieuThu> CauHinhPhieuThus { get; set; }

    public virtual DbSet<CauHinhTenMien> CauHinhTenMiens { get; set; }

    public virtual DbSet<CauHinhTruong> CauHinhTruongs { get; set; }

    public virtual DbSet<ChH> ChHs { get; set; }

    public virtual DbSet<DiemDanhHsNhom> DiemDanhHsNhoms { get; set; }

    public virtual DbSet<DiemDanhKhoanThu> DiemDanhKhoanThus { get; set; }

    public virtual DbSet<DiemDanhKhoanThuKy> DiemDanhKhoanThuKies { get; set; }

    public virtual DbSet<DiemDanhKhoanThuNam> DiemDanhKhoanThuNams { get; set; }

    public virtual DbSet<DkKhoanThuSlDg> DkKhoanThuSlDgs { get; set; }

    public virtual DbSet<DkKhoanThuTn> DkKhoanThuTns { get; set; }

    public virtual DbSet<DmCapDonVi> DmCapDonVis { get; set; }

    public virtual DbSet<DmCapHoc> DmCapHocs { get; set; }

    public virtual DbSet<DmDanToc> DmDanTocs { get; set; }

    public virtual DbSet<DmDienChinhSach> DmDienChinhSaches { get; set; }

    public virtual DbSet<DmGioiTinh> DmGioiTinhs { get; set; }

    public virtual DbSet<DmHinhThucThanhToan> DmHinhThucThanhToans { get; set; }

    public virtual DbSet<DmHuyen> DmHuyens { get; set; }

    public virtual DbSet<DmKhoanThu> DmKhoanThus { get; set; }

    public virtual DbSet<DmKhoi> DmKhois { get; set; }

    public virtual DbSet<DmKhuVuc> DmKhuVucs { get; set; }

    public virtual DbSet<DmKieuLop> DmKieuLops { get; set; }

    public virtual DbSet<DmLoaiCanBo> DmLoaiCanBos { get; set; }

    public virtual DbSet<DmLoaiHinh> DmLoaiHinhs { get; set; }

    public virtual DbSet<DmLoaiKhuyetTat> DmLoaiKhuyetTats { get; set; }

    public virtual DbSet<DmLoaiTruong> DmLoaiTruongs { get; set; }

    public virtual DbSet<DmMienGiam> DmMienGiams { get; set; }

    public virtual DbSet<DmMienGiamSo> DmMienGiamSos { get; set; }

    public virtual DbSet<DmMucDatChuanQgClgd> DmMucDatChuanQgClgds { get; set; }

    public virtual DbSet<DmNhomCanBo> DmNhomCanBos { get; set; }

    public virtual DbSet<DmNhomKhoanThu> DmNhomKhoanThus { get; set; }

    public virtual DbSet<DmNhomTuoiMn> DmNhomTuoiMns { get; set; }

    public virtual DbSet<DmNuoc> DmNuocs { get; set; }

    public virtual DbSet<DmPhanBan> DmPhanBans { get; set; }

    public virtual DbSet<DmTinh> DmTinhs { get; set; }

    public virtual DbSet<DmTonGiao> DmTonGiaos { get; set; }

    public virtual DbSet<DmTrangThaiHocSinh> DmTrangThaiHocSinhs { get; set; }

    public virtual DbSet<DmXa> DmXas { get; set; }

    public virtual DbSet<DoiTacThanhToan> DoiTacThanhToans { get; set; }

    public virtual DbSet<DotThu> DotThus { get; set; }

    public virtual DbSet<DotThuDoiTuong> DotThuDoiTuongs { get; set; }

    public virtual DbSet<DotThuKhoanThu> DotThuKhoanThus { get; set; }

    public virtual DbSet<GroupUser> GroupUsers { get; set; }

    public virtual DbSet<GroupUserMenu> GroupUserMenus { get; set; }

    public virtual DbSet<GroupUserPgd> GroupUserPgds { get; set; }

    public virtual DbSet<GroupUserPgdmenuPgd> GroupUserPgdmenuPgds { get; set; }

    public virtual DbSet<GroupUserSgd> GroupUserSgds { get; set; }

    public virtual DbSet<GroupUserSgdmenuSgd> GroupUserSgdmenuSgds { get; set; }

    public virtual DbSet<GuiThongBaoThuTien> GuiThongBaoThuTiens { get; set; }

    public virtual DbSet<HoaDonDienTu> HoaDonDienTus { get; set; }

    public virtual DbSet<HocSinh> HocSinhs { get; set; }

    public virtual DbSet<HocSinhMienGiam> HocSinhMienGiams { get; set; }

    public virtual DbSet<KhoaDiemDanh> KhoaDiemDanhs { get; set; }

    public virtual DbSet<KhoaDiemDanhKy> KhoaDiemDanhKies { get; set; }

    public virtual DbSet<KhoaDiemDanhNam> KhoaDiemDanhNams { get; set; }

    public virtual DbSet<KhoanThu> KhoanThus { get; set; }

    public virtual DbSet<KhoanThuDoiTuong> KhoanThuDoiTuongs { get; set; }

    public virtual DbSet<KhoanThuMienGiam> KhoanThuMienGiams { get; set; }

    public virtual DbSet<LichSuThanhToan> LichSuThanhToans { get; set; }

    public virtual DbSet<LichSuThuTien> LichSuThuTiens { get; set; }

    public virtual DbSet<LichSuThuTienCt> LichSuThuTienCts { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<MapMienGiamH> MapMienGiamHs { get; set; }

    public virtual DbSet<MapMienGiamHsSo> MapMienGiamHsSos { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuPgd> MenuPgds { get; set; }

    public virtual DbSet<MenuSgd> MenuSgds { get; set; }

    public virtual DbSet<NamHoc> NamHocs { get; set; }

    public virtual DbSet<NgayHocThang> NgayHocThangs { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<NhanSu> NhanSus { get; set; }

    public virtual DbSet<NhanSuLopChuNhiem> NhanSuLopChuNhiems { get; set; }

    public virtual DbSet<NhomDiemDanh> NhomDiemDanhs { get; set; }

    public virtual DbSet<PhanQuyenApi> PhanQuyenApis { get; set; }

    public virtual DbSet<PhieuThu> PhieuThus { get; set; }

    public virtual DbSet<PhieuThuCt> PhieuThuCts { get; set; }

    public virtual DbSet<PhongBan> PhongBans { get; set; }

    public virtual DbSet<PhongGd> PhongGds { get; set; }

    public virtual DbSet<QuyenNguoiDung> QuyenNguoiDungs { get; set; }

    public virtual DbSet<RefreshToken> RefreshTokens { get; set; }

    public virtual DbSet<SoGd> SoGds { get; set; }

    public virtual DbSet<TaiKhoanGuiTin> TaiKhoanGuiTins { get; set; }

    public virtual DbSet<ThongBaoDieuHanh> ThongBaoDieuHanhs { get; set; }

    public virtual DbSet<ThongBaoDoiTuong> ThongBaoDoiTuongs { get; set; }

    public virtual DbSet<Truong> Truongs { get; set; }

    public virtual DbSet<TruongDangKySuDung> TruongDangKySuDungs { get; set; }

    public virtual DbSet<TruongDoiTacThanhToan> TruongDoiTacThanhToans { get; set; }

    public virtual DbSet<XemThongBao> XemThongBaos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=42.112.27.32,21433;initial catalog=QUAN_LY_THU_PHI;persist security info=True;user id=sa;password=QIG@104;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Api>(entity =>
        {
            entity.ToTable("API");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .HasColumnName("URL");
        });

        modelBuilder.Entity<ApiToken>(entity =>
        {
            entity.ToTable("API_TOKENS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AuthToken)
                .HasMaxLength(500)
                .HasColumnName("AUTH_TOKEN");
            entity.Property(e => e.ExpiresOn)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("EXPIRES_ON");
            entity.Property(e => e.IdTaiKhoanGuiTin).HasColumnName("ID_TAI_KHOAN_GUI_TIN");
            entity.Property(e => e.IpAddress)
                .HasMaxLength(20)
                .HasColumnName("IP_ADDRESS");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(250)
                .HasColumnName("MAT_KHAU");
            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(50)
                .HasColumnName("TAI_KHOAN");
        });

        modelBuilder.Entity<CapMaBienLai>(entity =>
        {
            entity.ToTable("CAP_MA_BIEN_LAI");

            entity.HasIndex(e => new { e.IdLstt, e.IdHocSinh }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.IdTruong }, "IX_NAM_SO_CAP_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdLstt).HasColumnName("ID_LSTT");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.SoBienLai)
                .HasMaxLength(50)
                .HasColumnName("SO_BIEN_LAI");
            entity.Property(e => e.SttBienLai).HasColumnName("STT_BIEN_LAI");
        });

        modelBuilder.Entity<CapMaHocSinh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAP_MA_H__3214EC27AE7C9040");

            entity.ToTable("CAP_MA_HOC_SINH");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
        });

        modelBuilder.Entity<CapMaPhieuThu>(entity =>
        {
            entity.ToTable("CAP_MA_PHIEU_THU");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaPhieuThu)
                .HasMaxLength(50)
                .HasColumnName("MA_PHIEU_THU");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.SttPhieuThu).HasColumnName("STT_PHIEU_THU");
            entity.Property(e => e.SttPhieuThuTruong).HasColumnName("STT_PHIEU_THU_TRUONG");
            entity.Property(e => e.TienToPhieuThu)
                .HasMaxLength(50)
                .HasColumnName("TIEN_TO_PHIEU_THU");
        });

        modelBuilder.Entity<CauHinhApiCsdl>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAU_HINH__3214EC2724A65661");

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

        modelBuilder.Entity<CauHinhPhieuThu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CAU_HINH__3214EC27C9B9664C");

            entity.ToTable("CAU_HINH_PHIEU_THU");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.Key }, "MA_SO_GD_MA_TRUONG_MA_CAP_HOC_MA_NAM_HOC_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.Key)
                .HasMaxLength(250)
                .HasColumnName("KEY");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .HasColumnName("VALUE");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.CauHinhPhieuThus)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAU_HINH_PHIEU_THU_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.CauHinhPhieuThus)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAU_HINH_PHIEU_THU_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.CauHinhPhieuThus)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CAU_HINH_PHIEU_THU_NAM_HOC");
        });

        modelBuilder.Entity<CauHinhTenMien>(entity =>
        {
            entity.ToTable("CAU_HINH_TEN_MIEN");

            entity.HasIndex(e => e.TenMien, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnhDangNhap1)
                .HasMaxLength(250)
                .HasColumnName("ANH_DANG_NHAP_1");
            entity.Property(e => e.AnhDangNhap2)
                .HasMaxLength(250)
                .HasColumnName("ANH_DANG_NHAP_2");
            entity.Property(e => e.AnhDangNhap3)
                .HasMaxLength(250)
                .HasColumnName("ANH_DANG_NHAP_3");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.HotLine)
                .HasMaxLength(250)
                .HasColumnName("HOT_LINE");
            entity.Property(e => e.Logo)
                .HasMaxLength(250)
                .HasColumnName("LOGO");
            entity.Property(e => e.MaCapDonVi)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_DON_VI");
            entity.Property(e => e.MaDonVi)
                .HasMaxLength(50)
                .HasColumnName("MA_DON_VI");
            entity.Property(e => e.TenDonVi)
                .HasMaxLength(250)
                .HasColumnName("TEN_DON_VI");
            entity.Property(e => e.TenMien)
                .HasMaxLength(250)
                .HasColumnName("TEN_MIEN");
            entity.Property(e => e.TenPhanMem)
                .HasMaxLength(250)
                .HasColumnName("TEN_PHAN_MEM");
        });

        modelBuilder.Entity<CauHinhTruong>(entity =>
        {
            entity.ToTable("CAU_HINH_TRUONG");

            entity.HasIndex(e => e.IdTruong, "IDX_CAU_HINH_TRUONG_ID_TRUONG");

            entity.HasIndex(e => e.MaCapHoc, "IDX_CAU_HINH_TRUONG_MA_CAP_hOC");

            entity.HasIndex(e => e.MaNamHoc, "IDX_CAU_HINH_TRUONG_MA_NAM_HOC");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaCapHoc, e.MaTruong }, "IX_CAU_HINH_TRUONG_UNIQUE").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.IdPhongGd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_PHONG_GD");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsKhoaK1).HasColumnName("IS_KHOA_K1");
            entity.Property(e => e.IsKhoaK2).HasColumnName("IS_KHOA_K2");
            entity.Property(e => e.IsKhongHienHocSinhKhongHoc)
                .HasComment("Không hiện học sinh nghỉ học, chuyển trường, kỷ luật, miễn môn...(mặc định là hiện):\r\n0: Có hiện\r\n1: Không hiện")
                .HasColumnName("IS_KHONG_HIEN_HOC_SINH_KHONG_HOC");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_HOC");
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
            entity.Property(e => e.NamCuoiKyI).HasColumnName("NAM_CUOI_KY_I");
            entity.Property(e => e.NamCuoiKyIi).HasColumnName("NAM_CUOI_KY_II");
            entity.Property(e => e.NamDauKyI).HasColumnName("NAM_DAU_KY_I");
            entity.Property(e => e.NamDauKyIi).HasColumnName("NAM_DAU_KY_II");
            entity.Property(e => e.NgayCuoiKyI).HasColumnName("NGAY_CUOI_KY_I");
            entity.Property(e => e.NgayCuoiKyIi).HasColumnName("NGAY_CUOI_KY_II");
            entity.Property(e => e.NgayDauKyI).HasColumnName("NGAY_DAU_KY_I");
            entity.Property(e => e.NgayDauKyIi).HasColumnName("NGAY_DAU_KY_II");
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
            entity.Property(e => e.ThangCuoiKyI)
                .HasDefaultValueSql("((12))")
                .HasColumnName("THANG_CUOI_KY_I");
            entity.Property(e => e.ThangCuoiKyIi)
                .HasDefaultValueSql("((6))")
                .HasColumnName("THANG_CUOI_KY_II");
            entity.Property(e => e.ThangDauKyI)
                .HasDefaultValueSql("((7))")
                .HasColumnName("THANG_DAU_KY_I");
            entity.Property(e => e.ThangDauKyIi)
                .HasDefaultValueSql("((1))")
                .HasColumnName("THANG_DAU_KY_II");
        });

        modelBuilder.Entity<ChH>(entity =>
        {
            entity.ToTable("CH_HS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GiaTri)
                .HasMaxLength(500)
                .HasColumnName("GIA_TRI");
            entity.Property(e => e.KieuDuLieu)
                .HasMaxLength(50)
                .HasColumnName("KIEU_DU_LIEU");
            entity.Property(e => e.LoaiDuLieu).HasColumnName("LOAI_DU_LIEU");
            entity.Property(e => e.MaxValue)
                .HasMaxLength(50)
                .HasColumnName("MAX_VALUE");
            entity.Property(e => e.MinValue)
                .HasMaxLength(50)
                .HasColumnName("MIN_VALUE");
            entity.Property(e => e.TenCot)
                .HasMaxLength(50)
                .HasColumnName("TEN_COT");
            entity.Property(e => e.TenCotHienThi)
                .HasMaxLength(50)
                .HasColumnName("TEN_COT_HIEN_THI");
        });

        modelBuilder.Entity<DiemDanhHsNhom>(entity =>
        {
            entity.ToTable("DIEM_DANH_HS_NHOM");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaKhoi, e.IdHocSinh, e.IdNhomDiemDanh, e.Thang }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DaChot).HasColumnName("DA_CHOT");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdNhomDiemDanh).HasColumnName("ID_NHOM_DIEM_DANH");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Ngay1).HasColumnName("NGAY_1");
            entity.Property(e => e.Ngay10).HasColumnName("NGAY_10");
            entity.Property(e => e.Ngay11).HasColumnName("NGAY_11");
            entity.Property(e => e.Ngay12).HasColumnName("NGAY_12");
            entity.Property(e => e.Ngay13).HasColumnName("NGAY_13");
            entity.Property(e => e.Ngay14).HasColumnName("NGAY_14");
            entity.Property(e => e.Ngay15).HasColumnName("NGAY_15");
            entity.Property(e => e.Ngay16).HasColumnName("NGAY_16");
            entity.Property(e => e.Ngay17).HasColumnName("NGAY_17");
            entity.Property(e => e.Ngay18).HasColumnName("NGAY_18");
            entity.Property(e => e.Ngay19).HasColumnName("NGAY_19");
            entity.Property(e => e.Ngay2).HasColumnName("NGAY_2");
            entity.Property(e => e.Ngay20).HasColumnName("NGAY_20");
            entity.Property(e => e.Ngay21).HasColumnName("NGAY_21");
            entity.Property(e => e.Ngay22).HasColumnName("NGAY_22");
            entity.Property(e => e.Ngay23).HasColumnName("NGAY_23");
            entity.Property(e => e.Ngay24).HasColumnName("NGAY_24");
            entity.Property(e => e.Ngay25).HasColumnName("NGAY_25");
            entity.Property(e => e.Ngay26).HasColumnName("NGAY_26");
            entity.Property(e => e.Ngay27).HasColumnName("NGAY_27");
            entity.Property(e => e.Ngay28).HasColumnName("NGAY_28");
            entity.Property(e => e.Ngay29).HasColumnName("NGAY_29");
            entity.Property(e => e.Ngay3).HasColumnName("NGAY_3");
            entity.Property(e => e.Ngay30).HasColumnName("NGAY_30");
            entity.Property(e => e.Ngay31).HasColumnName("NGAY_31");
            entity.Property(e => e.Ngay4).HasColumnName("NGAY_4");
            entity.Property(e => e.Ngay5).HasColumnName("NGAY_5");
            entity.Property(e => e.Ngay6).HasColumnName("NGAY_6");
            entity.Property(e => e.Ngay7).HasColumnName("NGAY_7");
            entity.Property(e => e.Ngay8).HasColumnName("NGAY_8");
            entity.Property(e => e.Ngay9).HasColumnName("NGAY_9");
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
            entity.Property(e => e.SoNgayDaThuTien).HasColumnName("SO_NGAY_DA_THU_TIEN");
            entity.Property(e => e.SoNgayThua).HasColumnName("SO_NGAY_THUA");
            entity.Property(e => e.Thang).HasColumnName("THANG");
            entity.Property(e => e.TongThang).HasColumnName("TONG_THANG");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.DiemDanhHsNhoms)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_HS_NHOM_HOC_SINH");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.DiemDanhHsNhoms)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_HS_NHOM_LOP");

            entity.HasOne(d => d.IdNhomDiemDanhNavigation).WithMany(p => p.DiemDanhHsNhoms)
                .HasForeignKey(d => d.IdNhomDiemDanh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_HS_NHOM_NHOM_DIEM_DANH");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DiemDanhHsNhoms)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_HS_NHOM_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DiemDanhHsNhoms)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_HS_NHOM_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DiemDanhHsNhoms)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_HS_NHOM_NAM_HOC");
        });

        modelBuilder.Entity<DiemDanhKhoanThu>(entity =>
        {
            entity.ToTable("DIEM_DANH_KHOAN_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaKhoi, e.IdHocSinh, e.MaHocSinh, e.IdKhoanThu, e.Thang }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DaChot).HasColumnName("DA_CHOT");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsAuto).HasColumnName("IS_AUTO");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Ngay1).HasColumnName("NGAY_1");
            entity.Property(e => e.Ngay10).HasColumnName("NGAY_10");
            entity.Property(e => e.Ngay11).HasColumnName("NGAY_11");
            entity.Property(e => e.Ngay12).HasColumnName("NGAY_12");
            entity.Property(e => e.Ngay13).HasColumnName("NGAY_13");
            entity.Property(e => e.Ngay14).HasColumnName("NGAY_14");
            entity.Property(e => e.Ngay15).HasColumnName("NGAY_15");
            entity.Property(e => e.Ngay16).HasColumnName("NGAY_16");
            entity.Property(e => e.Ngay17).HasColumnName("NGAY_17");
            entity.Property(e => e.Ngay18).HasColumnName("NGAY_18");
            entity.Property(e => e.Ngay19).HasColumnName("NGAY_19");
            entity.Property(e => e.Ngay2).HasColumnName("NGAY_2");
            entity.Property(e => e.Ngay20).HasColumnName("NGAY_20");
            entity.Property(e => e.Ngay21).HasColumnName("NGAY_21");
            entity.Property(e => e.Ngay22).HasColumnName("NGAY_22");
            entity.Property(e => e.Ngay23).HasColumnName("NGAY_23");
            entity.Property(e => e.Ngay24).HasColumnName("NGAY_24");
            entity.Property(e => e.Ngay25).HasColumnName("NGAY_25");
            entity.Property(e => e.Ngay26).HasColumnName("NGAY_26");
            entity.Property(e => e.Ngay27).HasColumnName("NGAY_27");
            entity.Property(e => e.Ngay28).HasColumnName("NGAY_28");
            entity.Property(e => e.Ngay29).HasColumnName("NGAY_29");
            entity.Property(e => e.Ngay3).HasColumnName("NGAY_3");
            entity.Property(e => e.Ngay30).HasColumnName("NGAY_30");
            entity.Property(e => e.Ngay31).HasColumnName("NGAY_31");
            entity.Property(e => e.Ngay4).HasColumnName("NGAY_4");
            entity.Property(e => e.Ngay5).HasColumnName("NGAY_5");
            entity.Property(e => e.Ngay6).HasColumnName("NGAY_6");
            entity.Property(e => e.Ngay7).HasColumnName("NGAY_7");
            entity.Property(e => e.Ngay8).HasColumnName("NGAY_8");
            entity.Property(e => e.Ngay9).HasColumnName("NGAY_9");
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
            entity.Property(e => e.SoNgayDaThuTien).HasColumnName("SO_NGAY_DA_THU_TIEN");
            entity.Property(e => e.SoNgayThua).HasColumnName("SO_NGAY_THUA");
            entity.Property(e => e.Thang).HasColumnName("THANG");
            entity.Property(e => e.TongThang).HasColumnName("TONG_THANG");
            entity.Property(e => e.TongThangTam).HasColumnName("TONG_THANG_TAM");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.DiemDanhKhoanThus)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_HOC_SINH");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.DiemDanhKhoanThus)
                .HasForeignKey(d => d.IdKhoanThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_KHOAN_THU");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.DiemDanhKhoanThus)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DiemDanhKhoanThus)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DiemDanhKhoanThus)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DiemDanhKhoanThus)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_NAM_HOC");
        });

        modelBuilder.Entity<DiemDanhKhoanThuKy>(entity =>
        {
            entity.ToTable("DIEM_DANH_KHOAN_THU_KY");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh, e.IdKhoanThu, e.HocKy }, "IX_DIEM_DANH_KHOAN_THU_KY_UNIQUE").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DaChot).HasColumnName("DA_CHOT");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsAuto).HasColumnName("IS_AUTO");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.SoNgayDaThuTien).HasColumnName("SO_NGAY_DA_THU_TIEN");
            entity.Property(e => e.SoNgayThua).HasColumnName("SO_NGAY_THUA");
            entity.Property(e => e.TongKy).HasColumnName("TONG_KY");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.DiemDanhKhoanThuKies)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_KY_HOC_SINH");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.DiemDanhKhoanThuKies)
                .HasForeignKey(d => d.IdKhoanThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_KY_KHOAN_THU");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.DiemDanhKhoanThuKies)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_KY_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DiemDanhKhoanThuKies)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_KY_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DiemDanhKhoanThuKies)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_KY_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DiemDanhKhoanThuKies)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_KY_NAM_HOC");
        });

        modelBuilder.Entity<DiemDanhKhoanThuNam>(entity =>
        {
            entity.ToTable("DIEM_DANH_KHOAN_THU_NAM");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh, e.IdKhoanThu }, "IX_DIEM_DANH_KHOAN_THU_NAM_UNIQUE").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DaChot).HasColumnName("DA_CHOT");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsAuto).HasColumnName("IS_AUTO");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.SoNgayDaThuTien).HasColumnName("SO_NGAY_DA_THU_TIEN");
            entity.Property(e => e.SoNgayThua).HasColumnName("SO_NGAY_THUA");
            entity.Property(e => e.TongNam).HasColumnName("TONG_NAM");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.DiemDanhKhoanThuNams)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_NAM_HOC_SINH");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.DiemDanhKhoanThuNams)
                .HasForeignKey(d => d.IdKhoanThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_NAM_KHOAN_THU");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.DiemDanhKhoanThuNams)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_NAM_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DiemDanhKhoanThuNams)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_NAM_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DiemDanhKhoanThuNams)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_NAM_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DiemDanhKhoanThuNams)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DIEM_DANH_KHOAN_THU_NAM_NAM_HOC");
        });

        modelBuilder.Entity<DkKhoanThuSlDg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DK_KHOAN__3214EC271F3A3BD7");

            entity.ToTable("DK_KHOAN_THU_SL_DG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.IdKhoanThu, e.IdHocSinh }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DonGia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("DON_GIA");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.SoLuong).HasColumnName("SO_LUONG");
            entity.Property(e => e.Thang).HasColumnName("THANG");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.DkKhoanThuSlDgs)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_SL_DG_HOC_SINH");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.DkKhoanThuSlDgs)
                .HasForeignKey(d => d.IdKhoanThu)
                .HasConstraintName("FK_DK_KHOAN_THU_SL_DG_KHOAN_THU");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.DkKhoanThuSlDgs)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_SL_DG_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DkKhoanThuSlDgs)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_SL_DG_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DkKhoanThuSlDgs)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_SL_DG_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DkKhoanThuSlDgs)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_SL_DG_NAM_HOC");
        });

        modelBuilder.Entity<DkKhoanThuTn>(entity =>
        {
            entity.ToTable("DK_KHOAN_THU_TN");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaKhoi, e.IdHocSinh, e.MaHocSinh, e.IdKhoanThu }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DkK1).HasColumnName("DK_K1");
            entity.Property(e => e.DkK2).HasColumnName("DK_K2");
            entity.Property(e => e.DkNam).HasColumnName("DK_NAM");
            entity.Property(e => e.DkT1).HasColumnName("DK_T1");
            entity.Property(e => e.DkT10).HasColumnName("DK_T10");
            entity.Property(e => e.DkT11).HasColumnName("DK_T11");
            entity.Property(e => e.DkT12).HasColumnName("DK_T12");
            entity.Property(e => e.DkT2).HasColumnName("DK_T2");
            entity.Property(e => e.DkT3).HasColumnName("DK_T3");
            entity.Property(e => e.DkT4).HasColumnName("DK_T4");
            entity.Property(e => e.DkT5).HasColumnName("DK_T5");
            entity.Property(e => e.DkT6).HasColumnName("DK_T6");
            entity.Property(e => e.DkT7).HasColumnName("DK_T7");
            entity.Property(e => e.DkT8).HasColumnName("DK_T8");
            entity.Property(e => e.DkT9).HasColumnName("DK_T9");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.DkKhoanThuTns)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_TN_HOC_SINH");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.DkKhoanThuTns)
                .HasForeignKey(d => d.IdKhoanThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_TN_KHOAN_THU");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.DkKhoanThuTns)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_TN_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DkKhoanThuTns)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_TN_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DkKhoanThuTns)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_TN_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DkKhoanThuTns)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DK_KHOAN_THU_TN_NAM_HOC");
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

        modelBuilder.Entity<DmHinhThucThanhToan>(entity =>
        {
            entity.ToTable("DM_HINH_THUC_THANH_TOAN");

            entity.HasIndex(e => e.Ma, "IX_KEY_DM_HINH_THUC_THANH_TOANUNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.Ma).HasColumnName("MA");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
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

        modelBuilder.Entity<DmKhoanThu>(entity =>
        {
            entity.ToTable("DM_KHOAN_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.MaCapHoc, e.MaNamHoc, e.Ma }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DonViTinh).HasColumnName("DON_VI_TINH");
            entity.Property(e => e.IsBatBuoc).HasColumnName("IS_BAT_BUOC");
            entity.Property(e => e.IsDiemDanh).HasColumnName("IS_DIEM_DANH");
            entity.Property(e => e.IsKhauTru).HasColumnName("IS_KHAU_TRU");
            entity.Property(e => e.IsMienGiam).HasColumnName("IS_MIEN_GIAM");
            entity.Property(e => e.IsThuNoiBo).HasColumnName("IS_THU_NOI_BO");
            entity.Property(e => e.IsXuatCt).HasColumnName("IS_XUAT_CT");
            entity.Property(e => e.IsXuatHd).HasColumnName("IS_XUAT_HD");
            entity.Property(e => e.KyThu).HasColumnName("KY_THU");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.NamBatDau).HasColumnName("NAM_BAT_DAU");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(200)
                .HasColumnName("TEN");
            entity.Property(e => e.ThoiDiemThuCn).HasColumnName("THOI_DIEM_THU_CN");
            entity.Property(e => e.ThoiDiemThuK1).HasColumnName("THOI_DIEM_THU_K1");
            entity.Property(e => e.ThoiDiemThuK2).HasColumnName("THOI_DIEM_THU_K2");
            entity.Property(e => e.ThoiDiemThuQ1).HasColumnName("THOI_DIEM_THU_Q1");
            entity.Property(e => e.ThoiDiemThuQ2).HasColumnName("THOI_DIEM_THU_Q2");
            entity.Property(e => e.ThoiDiemThuQ3).HasColumnName("THOI_DIEM_THU_Q3");
            entity.Property(e => e.ThoiDiemThuQ4).HasColumnName("THOI_DIEM_THU_Q4");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
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

        modelBuilder.Entity<DmMienGiam>(entity =>
        {
            entity.ToTable("DM_MIEN_GIAM");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.Ma, e.MaNamHoc }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdDmMienGiamSo).HasColumnName("ID_DM_MIEN_GIAM_SO");
            entity.Property(e => e.IsCapGdtx).HasColumnName("IS_CAP_GDTX");
            entity.Property(e => e.IsCapMn).HasColumnName("IS_CAP_MN");
            entity.Property(e => e.IsCapTh).HasColumnName("IS_CAP_TH");
            entity.Property(e => e.IsCapThcs).HasColumnName("IS_CAP_THCS");
            entity.Property(e => e.IsCapThpt).HasColumnName("IS_CAP_THPT");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<DmMienGiamSo>(entity =>
        {
            entity.ToTable("DM_MIEN_GIAM_SO");

            entity.HasIndex(e => new { e.MaSoGd, e.MaNamHoc, e.Ma }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IsCapGdtx).HasColumnName("IS_CAP_GDTX");
            entity.Property(e => e.IsCapMn).HasColumnName("IS_CAP_MN");
            entity.Property(e => e.IsCapTh).HasColumnName("IS_CAP_TH");
            entity.Property(e => e.IsCapThcs).HasColumnName("IS_CAP_THCS");
            entity.Property(e => e.IsCapThpt).HasColumnName("IS_CAP_THPT");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
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

        modelBuilder.Entity<DmNhomKhoanThu>(entity =>
        {
            entity.ToTable("DM_NHOM_KHOAN_THU");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.Ma)
                .HasMaxLength(50)
                .HasColumnName("MA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
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
            entity.Property(e => e.NgaySua)
                .HasColumnType("date")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("date")
                .HasColumnName("NGAY_TAO");
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

        modelBuilder.Entity<DoiTacThanhToan>(entity =>
        {
            entity.ToTable("DOI_TAC_THANH_TOAN");

            entity.HasIndex(e => e.Ma, "IX_DOI_TAC_THANH_TOAN_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.Ma).HasColumnName("MA");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<DotThu>(entity =>
        {
            entity.ToTable("DOT_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.Ten }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsKhauTru).HasColumnName("IS_KHAU_TRU");
            entity.Property(e => e.IsTraTungPhan).HasColumnName("IS_TRA_TUNG_PHAN");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
                .HasMaxLength(150)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.Ten)
                .HasMaxLength(250)
                .HasColumnName("TEN");
            entity.Property(e => e.Thang).HasColumnName("THANG");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DotThus)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DotThus)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DotThus)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_NAM_HOC");
        });

        modelBuilder.Entity<DotThuDoiTuong>(entity =>
        {
            entity.ToTable("DOT_THU_DOI_TUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.IdDotThu, e.MaKhoi, e.MaNhomTuoiMn, e.IdLop, e.MaLop, e.IdHocSinh, e.MaHocSinh, e.IdKhoanThu }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.Thang).HasColumnName("THANG");

            entity.HasOne(d => d.IdDotThuNavigation).WithMany(p => p.DotThuDoiTuongs)
                .HasForeignKey(d => d.IdDotThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_DOI_TUONG_DOT_THU");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.DotThuDoiTuongs)
                .HasForeignKey(d => d.IdHocSinh)
                .HasConstraintName("FK_DOT_THU_DOI_TUONG_HOC_SINH");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.DotThuDoiTuongs)
                .HasForeignKey(d => d.IdLop)
                .HasConstraintName("FK_DOT_THU_DOI_TUONG_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DotThuDoiTuongs)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_DOI_TUONG_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DotThuDoiTuongs)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_DOI_TUONG_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DotThuDoiTuongs)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_DOI_TUONG_NAM_HOC");
        });

        modelBuilder.Entity<DotThuKhoanThu>(entity =>
        {
            entity.ToTable("DOT_THU_KHOAN_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.IdDotThu, e.IdKhoanThu }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.SoLuong).HasColumnName("SO_LUONG");
            entity.Property(e => e.Thang).HasColumnName("THANG");

            entity.HasOne(d => d.IdDotThuNavigation).WithMany(p => p.DotThuKhoanThus)
                .HasForeignKey(d => d.IdDotThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_KHOAN_THU_DOT_THU");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.DotThuKhoanThus)
                .HasForeignKey(d => d.IdKhoanThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_KHOAN_THU_KHOAN_THU");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.DotThuKhoanThus)
                .HasForeignKey(d => d.IdTruong)
                .HasConstraintName("FK_DOT_THU_KHOAN_THU_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.DotThuKhoanThus)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_KHOAN_THU_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.DotThuKhoanThus)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DOT_THU_KHOAN_THU_NAM_HOC");
        });

        modelBuilder.Entity<GroupUser>(entity =>
        {
            entity.ToTable("GroupUser");

            entity.HasIndex(e => new { e.GroupUserCode, e.SoGdma, e.TruongMa }, "IX_KEY").IsUnique();

            entity.Property(e => e.GroupUserId).HasColumnName("GroupUserID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.GroupUserCode).HasMaxLength(50);
            entity.Property(e => e.GroupUserName).HasMaxLength(120);
            entity.Property(e => e.IsnotCheckPc).HasColumnName("ISNotCheckPC");
            entity.Property(e => e.Isroot).HasColumnName("ISRoot");
            entity.Property(e => e.SoGdma)
                .HasMaxLength(50)
                .HasColumnName("SoGDMA");
            entity.Property(e => e.TruongMa)
                .HasMaxLength(50)
                .HasColumnName("TruongMA");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);
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

        modelBuilder.Entity<GroupUserPgd>(entity =>
        {
            entity.ToTable("GroupUserPGD");

            entity.HasIndex(e => new { e.GroupUserPgdcode, e.PhongGdma }, "IX_KEY").IsUnique();

            entity.Property(e => e.GroupUserPgdid).HasColumnName("GroupUserPGDID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.GroupUserPgdcode)
                .HasMaxLength(50)
                .HasColumnName("GroupUserPGDCode");
            entity.Property(e => e.GroupUserPgdname)
                .HasMaxLength(120)
                .HasColumnName("GroupUserPGDName");
            entity.Property(e => e.Isroot).HasColumnName("ISRoot");
            entity.Property(e => e.PhongGdma)
                .HasMaxLength(50)
                .HasColumnName("PhongGDMA");
            entity.Property(e => e.SoGdma)
                .HasMaxLength(50)
                .HasColumnName("SoGDMA");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);
        });

        modelBuilder.Entity<GroupUserPgdmenuPgd>(entity =>
        {
            entity.ToTable("GroupUserPGDMenuPGD");

            entity.HasIndex(e => new { e.MenuPgdid, e.GroupUserPgdid }, "IX_KEY").IsUnique();

            entity.Property(e => e.GroupUserPgdmenuPgdid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GroupUserPGDMenuPGDID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.GroupUserPgdid).HasColumnName("GroupUserPGDID");
            entity.Property(e => e.MenuPgdid).HasColumnName("MenuPGDID");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);

            entity.HasOne(d => d.GroupUserPgd).WithMany(p => p.GroupUserPgdmenuPgds)
                .HasForeignKey(d => d.GroupUserPgdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupUserPGDMenuPGD_GroupUserPGD");

            entity.HasOne(d => d.MenuPgd).WithMany(p => p.GroupUserPgdmenuPgds)
                .HasForeignKey(d => d.MenuPgdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupUserPGDMenuPGD_MenuPGD");
        });

        modelBuilder.Entity<GroupUserSgd>(entity =>
        {
            entity.ToTable("GroupUserSGD");

            entity.HasIndex(e => new { e.GroupUserSgdcode, e.SoGdma }, "IX_KEY").IsUnique();

            entity.Property(e => e.GroupUserSgdid).HasColumnName("GroupUserSGDID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.GroupUserSgdcode)
                .HasMaxLength(50)
                .HasColumnName("GroupUserSGDCode");
            entity.Property(e => e.GroupUserSgdname)
                .HasMaxLength(120)
                .HasColumnName("GroupUserSGDName");
            entity.Property(e => e.Isroot).HasColumnName("ISRoot");
            entity.Property(e => e.SoGdma)
                .HasMaxLength(50)
                .HasColumnName("SoGDMA");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);
        });

        modelBuilder.Entity<GroupUserSgdmenuSgd>(entity =>
        {
            entity.ToTable("GroupUserSGDMenuSGD");

            entity.HasIndex(e => new { e.MenuSgdid, e.GroupUserSgdid }, "IX_KEY").IsUnique();

            entity.Property(e => e.GroupUserSgdmenuSgdid)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("GroupUserSGDMenuSGDID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.GroupUserSgdid).HasColumnName("GroupUserSGDID");
            entity.Property(e => e.MenuSgdid).HasColumnName("MenuSGDID");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);

            entity.HasOne(d => d.GroupUserSgd).WithMany(p => p.GroupUserSgdmenuSgds)
                .HasForeignKey(d => d.GroupUserSgdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupUserSGDMenuSGD_GroupUserSGD");

            entity.HasOne(d => d.MenuSgd).WithMany(p => p.GroupUserSgdmenuSgds)
                .HasForeignKey(d => d.MenuSgdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupUserSGDMenuSGD_MenuSGD");
        });

        modelBuilder.Entity<GuiThongBaoThuTien>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GUI_THON_BAO_THU_PHI");

            entity.ToTable("GUI_THONG_BAO_THU_TIEN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.NoiDung)
                .HasMaxLength(500)
                .HasColumnName("NOI_DUNG");
            entity.Property(e => e.SoLanGui).HasColumnName("SO_LAN_GUI");
            entity.Property(e => e.TenHocSinh)
                .HasMaxLength(250)
                .HasColumnName("TEN_HOC_SINH");
            entity.Property(e => e.ThoiGianGui)
                .HasColumnType("datetime")
                .HasColumnName("THOI_GIAN_GUI");
            entity.Property(e => e.TrangThaiGui).HasColumnName("TRANG_THAI_GUI");
        });

        modelBuilder.Entity<HoaDonDienTu>(entity =>
        {
            entity.ToTable("HOA_DON_DIEN_TU");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaNamHoc, e.IdDotThu, e.IdLop, e.IdHocSinh, e.IdPhieuThu, e.MaCapHoc }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdDotThu }, "IX_NAM_SO_CAP_TRUONG_DOT_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHoaDon)
                .HasMaxLength(50)
                .HasColumnName("ID_HOA_DON");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdPhieuThu).HasColumnName("ID_PHIEU_THU");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.KyHieu)
                .HasMaxLength(50)
                .HasColumnName("KY_HIEU");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaDonVi)
                .HasMaxLength(50)
                .HasColumnName("MA_DON_VI");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLoaiHoaDon)
                .HasMaxLength(50)
                .HasColumnName("MA_LOAI_HOA_DON");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MauSo)
                .HasMaxLength(50)
                .HasColumnName("MAU_SO");
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
            entity.Property(e => e.SoBienLai)
                .HasMaxLength(50)
                .HasColumnName("SO_BIEN_LAI");
            entity.Property(e => e.SoHoaDon)
                .HasMaxLength(50)
                .HasColumnName("SO_HOA_DON");
            entity.Property(e => e.ThoiGianHuyHd)
                .HasColumnType("datetime")
                .HasColumnName("THOI_GIAN_HUY_HD");
            entity.Property(e => e.ThoiGianXuatHd)
                .HasColumnType("datetime")
                .HasColumnName("THOI_GIAN_XUAT_HD");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<HocSinh>(entity =>
        {
            entity.ToTable("HOC_SINH");

            entity.HasIndex(e => e.KeySystem, "IDX_HOC_SINH_KEY_SYSTEM");

            entity.HasIndex(e => e.MaSoDinhDanhCaNhan, "IDX_HOC_SINH_MA_SO_DINH_DANH_CA_NHAN");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaNamHoc, e.MaCapHoc, e.MaSoDinhDanhCaNhan }, "IDX_HOC_SINH_MA_SO_DINH_DANH_CA_NHAN_2");

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
            entity.Property(e => e.Cmnd)
                .HasMaxLength(50)
                .HasColumnName("CMND");
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
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
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
            entity.Property(e => e.IsQltp).HasColumnName("IS_QLTP");
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
            entity.Property(e => e.NgayCap)
                .HasColumnType("date")
                .HasColumnName("NGAY_CAP");
            entity.Property(e => e.NgaySinh)
                .HasColumnType("date")
                .HasColumnName("NGAY_SINH");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NgayTrangThai)
                .HasColumnType("date")
                .HasColumnName("NGAY_TRANG_THAI");
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
            entity.Property(e => e.NoiCap)
                .HasMaxLength(150)
                .HasColumnName("NOI_CAP");
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

        modelBuilder.Entity<HocSinhMienGiam>(entity =>
        {
            entity.ToTable("HOC_SINH_MIEN_GIAM");

            entity.HasIndex(e => new { e.IdHocSinh, e.IdDmMienGiam }, "IX_HOC_SINH_MIEN_GIAM_UNIQUE").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasDefaultValueSql("((0))")
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.IdDmMienGiam).HasColumnName("ID_DM_MIEN_GIAM");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsAuto).HasColumnName("IS_AUTO");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
                .HasMaxLength(50)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(50)
                .HasColumnName("NGUOI_TAO");

            entity.HasOne(d => d.IdDmMienGiamNavigation).WithMany(p => p.HocSinhMienGiams)
                .HasForeignKey(d => d.IdDmMienGiam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOC_SINH_MIEN_GIAM_DM_MIEN_GIAM");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.HocSinhMienGiams)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOC_SINH_MIEN_GIAM_HOC_SINH");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.HocSinhMienGiams)
                .HasForeignKey(d => d.IdLop)
                .HasConstraintName("FK_HOC_SINH_MIEN_GIAM_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.HocSinhMienGiams)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOC_SINH_MIEN_GIAM_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.HocSinhMienGiams)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOC_SINH_MIEN_GIAM_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.HocSinhMienGiams)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HOC_SINH_MIEN_GIAM_NAM_HOC");
        });

        modelBuilder.Entity<KhoaDiemDanh>(entity =>
        {
            entity.ToTable("KHOA_DIEM_DANH");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.MaKhoi, e.IdLop, e.MaLop }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsKhoa).HasColumnName("IS_KHOA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.Thang).HasColumnName("THANG");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.KhoaDiemDanhs)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.KhoaDiemDanhs)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.KhoaDiemDanhs)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.KhoaDiemDanhs)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_NAM_HOC");
        });

        modelBuilder.Entity<KhoaDiemDanhKy>(entity =>
        {
            entity.ToTable("KHOA_DIEM_DANH_KY");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Nam, e.MaKhoi, e.IdLop, e.MaLop }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsKhoa).HasColumnName("IS_KHOA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.KhoaDiemDanhKies)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_KY_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.KhoaDiemDanhKies)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_KY_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.KhoaDiemDanhKies)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_KY_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.KhoaDiemDanhKies)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_KY_NAM_HOC");
        });

        modelBuilder.Entity<KhoaDiemDanhNam>(entity =>
        {
            entity.ToTable("KHOA_DIEM_DANH_NAM");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.Nam, e.MaKhoi, e.IdLop, e.MaLop }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsKhoa).HasColumnName("IS_KHOA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.KhoaDiemDanhNams)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_NAM_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.KhoaDiemDanhNams)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_NAM_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.KhoaDiemDanhNams)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_NAM_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.KhoaDiemDanhNams)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOA_DIEM_DANH_NAM_NAM_HOC");
        });

        modelBuilder.Entity<KhoanThu>(entity =>
        {
            entity.ToTable("KHOAN_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.Ten, e.MaNamHoc }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DonViTinh).HasColumnName("DON_VI_TINH");
            entity.Property(e => e.IdDmKhoanThu).HasColumnName("ID_DM_KHOAN_THU");
            entity.Property(e => e.IdDmNhomKhoanThu).HasColumnName("ID_DM_NHOM_KHOAN_THU");
            entity.Property(e => e.IdNhomDiemDanh).HasColumnName("ID_NHOM_DIEM_DANH");
            entity.Property(e => e.IsBatBuoc).HasColumnName("IS_BAT_BUOC");
            entity.Property(e => e.IsDiemDanh).HasColumnName("IS_DIEM_DANH");
            entity.Property(e => e.IsKhauTru).HasColumnName("IS_KHAU_TRU");
            entity.Property(e => e.IsLaySlDgHs).HasColumnName("IS_LAY_SL_DG_HS");
            entity.Property(e => e.IsMienGiam).HasColumnName("IS_MIEN_GIAM");
            entity.Property(e => e.IsThuHoChiHo).HasColumnName("IS_THU_HO_CHI_HO");
            entity.Property(e => e.IsThuLienKet).HasColumnName("IS_THU_LIEN_KET");
            entity.Property(e => e.IsThuNoiBo).HasColumnName("IS_THU_NOI_BO");
            entity.Property(e => e.IsThuThoaThuan).HasColumnName("IS_THU_THOA_THUAN");
            entity.Property(e => e.IsXuatCt).HasColumnName("IS_XUAT_CT");
            entity.Property(e => e.IsXuatHd).HasColumnName("IS_XUAT_HD");
            entity.Property(e => e.KyThu).HasColumnName("KY_THU");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
            entity.Property(e => e.ThoiDiemThuCn).HasColumnName("THOI_DIEM_THU_CN");
            entity.Property(e => e.ThoiDiemThuK1).HasColumnName("THOI_DIEM_THU_K1");
            entity.Property(e => e.ThoiDiemThuK2).HasColumnName("THOI_DIEM_THU_K2");
            entity.Property(e => e.ThoiDiemThuQ1).HasColumnName("THOI_DIEM_THU_Q1");
            entity.Property(e => e.ThoiDiemThuQ2).HasColumnName("THOI_DIEM_THU_Q2");
            entity.Property(e => e.ThoiDiemThuQ3).HasColumnName("THOI_DIEM_THU_Q3");
            entity.Property(e => e.ThoiDiemThuQ4).HasColumnName("THOI_DIEM_THU_Q4");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<KhoanThuDoiTuong>(entity =>
        {
            entity.ToTable("KHOAN_THU_DOI_TUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdKhoanThu, e.MaKhoi, e.MaNhomTuoiMn, e.IdLop, e.MaLop, e.IdHocSinh, e.MaHocSinh }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MucThu)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MUC_THU");
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

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.KhoanThuDoiTuongs)
                .HasForeignKey(d => d.IdHocSinh)
                .HasConstraintName("FK_KHOAN_THU_DOI_TUONG_HOC_SINH");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.KhoanThuDoiTuongs)
                .HasForeignKey(d => d.IdKhoanThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_DOI_TUONG_KHOAN_THU");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.KhoanThuDoiTuongs)
                .HasForeignKey(d => d.IdLop)
                .HasConstraintName("FK_KHOAN_THU_DOI_TUONG_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.KhoanThuDoiTuongs)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_DOI_TUONG_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.KhoanThuDoiTuongs)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_DOI_TUONG_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.KhoanThuDoiTuongs)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_DOI_TUONG_NAM_HOC");
        });

        modelBuilder.Entity<KhoanThuMienGiam>(entity =>
        {
            entity.ToTable("KHOAN_THU_MIEN_GIAM");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdKhoanThu, e.IdDmMienGiam }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdDmMienGiam).HasColumnName("ID_DM_MIEN_GIAM");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.PhanTramGiam)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PHAN_TRAM_GIAM");
            entity.Property(e => e.SoTienGiam)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SO_TIEN_GIAM");
            entity.Property(e => e.SoTienGiamToiDa)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SO_TIEN_GIAM_TOI_DA");

            entity.HasOne(d => d.IdDmMienGiamNavigation).WithMany(p => p.KhoanThuMienGiams)
                .HasForeignKey(d => d.IdDmMienGiam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_MIEN_GIAM_DM_MIEN_GIAM");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.KhoanThuMienGiams)
                .HasForeignKey(d => d.IdKhoanThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_MIEN_GIAM_KHOAN_THU");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.KhoanThuMienGiams)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_MIEN_GIAM_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.KhoanThuMienGiams)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_MIEN_GIAM_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.KhoanThuMienGiams)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_KHOAN_THU_MIEN_GIAM_NAM_HOC");
        });

        modelBuilder.Entity<LichSuThanhToan>(entity =>
        {
            entity.ToTable("LICH_SU_THANH_TOAN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoiTacThanhToan)
                .HasMaxLength(150)
                .HasColumnName("DOI_TAC_THANH_TOAN");
            entity.Property(e => e.DoiTuongThucHien)
                .HasMaxLength(150)
                .HasColumnName("DOI_TUONG_THUC_HIEN");
            entity.Property(e => e.DonGia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("DON_GIA");
            entity.Property(e => e.GhiChuThanhToan)
                .HasMaxLength(150)
                .HasColumnName("GHI_CHU_THANH_TOAN");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdLstt).HasColumnName("ID_LSTT");
            entity.Property(e => e.IdPhieuThu).HasColumnName("ID_PHIEU_THU");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsSuDung).HasColumnName("IS_SU_DUNG");
            entity.Property(e => e.LoaiSuDung).HasColumnName("LOAI_SU_DUNG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.SoNgayThua).HasColumnName("SO_NGAY_THUA");
            entity.Property(e => e.SoTien)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SO_TIEN");
            entity.Property(e => e.TaiKhoanThanhToan)
                .HasMaxLength(150)
                .HasColumnName("TAI_KHOAN_THANH_TOAN");
            entity.Property(e => e.Thang).HasColumnName("THANG");
            entity.Property(e => e.ThoiDiemThanhToan)
                .HasColumnType("datetime")
                .HasColumnName("THOI_DIEM_THANH_TOAN");

            entity.HasOne(d => d.IdDotThuNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.IdDotThu)
                .HasConstraintName("FK_LICH_SU_THANH_TOAN_DOT_THU");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LICH_SU_THANH_TOAN_HOC_SINH");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LICH_SU_THANH_TOAN_LOP");

            entity.HasOne(d => d.IdPhieuThuNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.IdPhieuThu)
                .HasConstraintName("FK_LICH_SU_THANH_TOAN_PHIEU_THU");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LICH_SU_THANH_TOAN_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LICH_SU_THANH_TOAN_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.LichSuThanhToans)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LICH_SU_THANH_TOAN_NAM_HOC");
        });

        modelBuilder.Entity<LichSuThuTien>(entity =>
        {
            entity.ToTable("LICH_SU_THU_TIEN");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.HasIndex(e => e.NgayThu, "IX_NGAY_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaCapHoc, e.MaNamHoc }, "SO_ID_TRUONG_CAP_HOC_NAM_HOC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DoiTacThanhToan)
                .HasMaxLength(150)
                .HasColumnName("DOI_TAC_THANH_TOAN");
            entity.Property(e => e.GhiChuThanhToan)
                .HasMaxLength(150)
                .HasColumnName("GHI_CHU_THANH_TOAN");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.KieuThanhToan).HasColumnName("KIEU_THANH_TOAN");
            entity.Property(e => e.LoaiHoanTra).HasColumnName("LOAI_HOAN_TRA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NgayThu)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_THU");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.NguoiThu)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_THU");
            entity.Property(e => e.SoTien)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SO_TIEN");
            entity.Property(e => e.TaiKhoanThanhToan)
                .HasMaxLength(150)
                .HasColumnName("TAI_KHOAN_THANH_TOAN");
            entity.Property(e => e.ThoiDiemThanhToan)
                .HasColumnType("datetime")
                .HasColumnName("THOI_DIEM_THANH_TOAN");
        });

        modelBuilder.Entity<LichSuThuTienCt>(entity =>
        {
            entity.ToTable("LICH_SU_THU_TIEN_CT");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdDotThu }, "IX_ID_LSTT_ID_PHIEU_THU");

            entity.HasIndex(e => new { e.IdLstt, e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.MaKhoi, e.MaNhomTuoiMn, e.IdLop, e.MaLop, e.IdHocSinh, e.MaHocSinh, e.IdDotThu, e.IdKhoanThu, e.LoaiCt, e.IdPhieuThuCt }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdLstt).HasColumnName("ID_LSTT");
            entity.Property(e => e.IdPhieuThu).HasColumnName("ID_PHIEU_THU");
            entity.Property(e => e.IdPhieuThuCt).HasColumnName("ID_PHIEU_THU_CT");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.LoaiCt).HasColumnName("LOAI_CT");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.NoiDung)
                .HasMaxLength(250)
                .HasColumnName("NOI_DUNG");
            entity.Property(e => e.SoTien)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SO_TIEN");
            entity.Property(e => e.Thang).HasColumnName("THANG");

            entity.HasOne(d => d.IdLsttNavigation).WithMany(p => p.LichSuThuTienCts)
                .HasForeignKey(d => d.IdLstt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LICH_SU_THU_TIEN_CT_LICH_SU_THU_TIEN");
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
            entity.Property(e => e.IsQltp).HasColumnName("IS_QLTP");
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

        modelBuilder.Entity<MapMienGiamH>(entity =>
        {
            entity.ToTable("MAP_MIEN_GIAM_HS");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.IdDmMienGiam, e.IdChHs, e.GiaTriHs }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GiaTriHs)
                .HasMaxLength(50)
                .HasColumnName("GIA_TRI_HS");
            entity.Property(e => e.IdChHs).HasColumnName("ID_CH_HS");
            entity.Property(e => e.IdDmMienGiam).HasColumnName("ID_DM_MIEN_GIAM");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.TenGiaTri)
                .HasMaxLength(250)
                .HasColumnName("TEN_GIA_TRI");

            entity.HasOne(d => d.IdChHsNavigation).WithMany(p => p.MapMienGiamHs)
                .HasForeignKey(d => d.IdChHs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAP_MIEN_GIAM_HS_CH_HS");

            entity.HasOne(d => d.IdDmMienGiamNavigation).WithMany(p => p.MapMienGiamHs)
                .HasForeignKey(d => d.IdDmMienGiam)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAP_MIEN_GIAM_HS_DM_MIEN_GIAM");
        });

        modelBuilder.Entity<MapMienGiamHsSo>(entity =>
        {
            entity.ToTable("MAP_MIEN_GIAM_HS_SO");

            entity.HasIndex(e => new { e.MaSoGd, e.IdDmMienGiamSo, e.IdChHs, e.GiaTriHs }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GiaTriHs)
                .HasMaxLength(50)
                .HasColumnName("GIA_TRI_HS");
            entity.Property(e => e.IdChHs).HasColumnName("ID_CH_HS");
            entity.Property(e => e.IdDmMienGiamSo).HasColumnName("ID_DM_MIEN_GIAM_SO");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.TenGiaTri)
                .HasMaxLength(250)
                .HasColumnName("TEN_GIA_TRI");

            entity.HasOne(d => d.IdChHsNavigation).WithMany(p => p.MapMienGiamHsSos)
                .HasForeignKey(d => d.IdChHs)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAP_MIEN_GIAM_HS_SO_CH_HS");

            entity.HasOne(d => d.IdDmMienGiamSoNavigation).WithMany(p => p.MapMienGiamHsSos)
                .HasForeignKey(d => d.IdDmMienGiamSo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MAP_MIEN_GIAM_HS_SO_DM_MIEN_GIAM_SO");
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

        modelBuilder.Entity<MenuPgd>(entity =>
        {
            entity.ToTable("MenuPGD");

            entity.Property(e => e.MenuPgdid).HasColumnName("MenuPGDID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.DesHelp).HasMaxLength(250);
            entity.Property(e => e.Icon).HasMaxLength(150);
            entity.Property(e => e.Link).HasMaxLength(150);
            entity.Property(e => e.LinkYoutube).HasMaxLength(150);
            entity.Property(e => e.MenuPgdcode)
                .HasMaxLength(100)
                .HasColumnName("MenuPGDCode");
            entity.Property(e => e.MenuPgdname)
                .HasMaxLength(120)
                .HasColumnName("MenuPGDName");
            entity.Property(e => e.MenuPgdnameEg)
                .HasMaxLength(120)
                .HasColumnName("MenuPGDNameEG");
            entity.Property(e => e.Order).HasMaxLength(20);
            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.UpdateAt).HasColumnType("datetime");
            entity.Property(e => e.UpdateBy).HasMaxLength(120);
        });

        modelBuilder.Entity<MenuSgd>(entity =>
        {
            entity.ToTable("MenuSGD");

            entity.Property(e => e.MenuSgdid).HasColumnName("MenuSGDID");
            entity.Property(e => e.AuthAt).HasColumnType("datetime");
            entity.Property(e => e.AuthBy).HasMaxLength(120);
            entity.Property(e => e.CreateAt).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(120);
            entity.Property(e => e.DesHelp).HasMaxLength(250);
            entity.Property(e => e.Icon).HasMaxLength(150);
            entity.Property(e => e.Link).HasMaxLength(150);
            entity.Property(e => e.LinkYoutube).HasMaxLength(150);
            entity.Property(e => e.MenuSgdcode)
                .HasMaxLength(100)
                .HasColumnName("MenuSGDCode");
            entity.Property(e => e.MenuSgdname)
                .HasMaxLength(120)
                .HasColumnName("MenuSGDName");
            entity.Property(e => e.MenuSgdnameEg)
                .HasMaxLength(120)
                .HasColumnName("MenuSGDNameEG");
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

        modelBuilder.Entity<NgayHocThang>(entity =>
        {
            entity.ToTable("NGAY_HOC_THANG");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.ToTable("NGUOI_DUNG");

            entity.HasIndex(e => new { e.TenDangNhap, e.MaCapDonVi, e.MaSoGd, e.MaPhongGd, e.MaTruong }, "IX_KEY").IsUnique();

            entity.HasIndex(e => e.MaNamHoc, "IX_NGUOI_DUNG");

            entity.HasIndex(e => e.MaNhanSu, "IX_NGUOI_DUNG_1");

            entity.HasIndex(e => e.MaCapDonVi, "IX_NGUOI_DUNG_10");

            entity.HasIndex(e => e.MaSoGd, "IX_NGUOI_DUNG_2");

            entity.HasIndex(e => e.MaPhongGd, "IX_NGUOI_DUNG_3");

            entity.HasIndex(e => e.MaTruong, "IX_NGUOI_DUNG_4");

            entity.HasIndex(e => e.TenDangNhap, "IX_NGUOI_DUNG_5");

            entity.HasIndex(e => e.MatKhau, "IX_NGUOI_DUNG_6");

            entity.HasIndex(e => e.TrangThai, "IX_NGUOI_DUNG_7");

            entity.HasIndex(e => e.IsRoot, "IX_NGUOI_DUNG_8");

            entity.HasIndex(e => e.IsRootSys, "IX_NGUOI_DUNG_9");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID");
            entity.Property(e => e.ChucVuPhongBan)
                .HasMaxLength(250)
                .HasColumnName("CHUC_VU_PHONG_BAN");
            entity.Property(e => e.ConnectionId)
                .HasMaxLength(200)
                .HasColumnName("connectionId");
            entity.Property(e => e.DienThoaiDiDong)
                .HasMaxLength(250)
                .HasColumnName("DIEN_THOAI_DI_DONG");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.HoTen)
                .HasMaxLength(150)
                .HasColumnName("HO_TEN");
            entity.Property(e => e.IdSource)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_SOURCE");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .HasColumnName("ip");
            entity.Property(e => e.IsMasterRootSys).HasColumnName("IS_MASTER_ROOT_SYS");
            entity.Property(e => e.IsRoot).HasColumnName("IS_ROOT");
            entity.Property(e => e.IsRootSys).HasColumnName("IS_ROOT_SYS");
            entity.Property(e => e.IsUpdate).HasColumnName("IS_UPDATE");
            entity.Property(e => e.MaCapDonVi)
                .HasMaxLength(20)
                .HasColumnName("MA_CAP_DON_VI");
            entity.Property(e => e.MaKhoiPhucMatKhau)
                .HasMaxLength(100)
                .HasColumnName("MA_KHOI_PHUC_MAT_KHAU");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhanSu)
                .HasMaxLength(20)
                .HasColumnName("MA_NHAN_SU");
            entity.Property(e => e.MaNhomQuyen)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_QUYEN");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(20)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(20)
                .HasColumnName("MA_TRUONG");
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

        modelBuilder.Entity<NhanSu>(entity =>
        {
            entity.ToTable("NHAN_SU");

            entity.HasIndex(e => new { e.Ma, e.IdTruong, e.MaTruong, e.MaNamHoc, e.IdPhongGd, e.MaSoGd }, "IX_IDTRUONG_MAGV").IsUnique();

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
            entity.Property(e => e.NgayCap)
                .HasColumnType("date")
                .HasColumnName("NGAY_CAP");
            entity.Property(e => e.NgaySinh)
                .HasColumnType("date")
                .HasColumnName("NGAY_SINH");
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

        modelBuilder.Entity<NhomDiemDanh>(entity =>
        {
            entity.ToTable("NHOM_DIEM_DANH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.Ten }, "IX_KEY").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
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
            entity.Property(e => e.Ten)
                .HasMaxLength(150)
                .HasColumnName("TEN");
            entity.Property(e => e.ThuTu).HasColumnName("THU_TU");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<PhanQuyenApi>(entity =>
        {
            entity.ToTable("PHAN_QUYEN_API");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdApi).HasColumnName("ID_API");
            entity.Property(e => e.IdTaiKhoanGuiTin).HasColumnName("ID_TAI_KHOAN_GUI_TIN");
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
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
        });

        modelBuilder.Entity<PhieuThu>(entity =>
        {
            entity.ToTable("PHIEU_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.IdDotThu, e.MaKhoi, e.IdHocSinh, e.MaHocSinh }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdDotThu }, "IX_NAM_SO_CAP_TRUONG_DOT_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh, e.IsChot }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH_CHOT");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnhThanhToanDo)
                .HasMaxLength(250)
                .HasColumnName("ANH_THANH_TOAN_DO");
            entity.Property(e => e.AnhThanhToanLocal)
                .HasMaxLength(250)
                .HasColumnName("ANH_THANH_TOAN_LOCAL");
            entity.Property(e => e.ConLai)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("CON_LAI");
            entity.Property(e => e.DoiTacThanhToan)
                .HasMaxLength(150)
                .HasColumnName("DOI_TAC_THANH_TOAN");
            entity.Property(e => e.FileName)
                .HasMaxLength(500)
                .HasColumnName("FILE_NAME");
            entity.Property(e => e.FilePathDo)
                .HasMaxLength(500)
                .HasColumnName("FILE_PATH_DO");
            entity.Property(e => e.FilePathLocal)
                .HasMaxLength(500)
                .HasColumnName("FILE_PATH_LOCAL");
            entity.Property(e => e.GhiChuThanhToan)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU_THANH_TOAN");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsChot).HasColumnName("IS_CHOT");
            entity.Property(e => e.IsDaThanhToan).HasColumnName("IS_DA_THANH_TOAN");
            entity.Property(e => e.IsEdited).HasColumnName("IS_EDITED");
            entity.Property(e => e.IsUploadDo).HasColumnName("IS_UPLOAD_DO");
            entity.Property(e => e.KieuThanhToan).HasColumnName("KIEU_THANH_TOAN");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaPhieuThu)
                .HasMaxLength(50)
                .HasColumnName("MA_PHIEU_THU");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.SttPhieuThu).HasColumnName("STT_PHIEU_THU");
            entity.Property(e => e.SttPhieuThuTruong).HasColumnName("STT_PHIEU_THU_TRUONG");
            entity.Property(e => e.TaiKhoanThanhToan)
                .HasMaxLength(150)
                .HasColumnName("TAI_KHOAN_THANH_TOAN");
            entity.Property(e => e.TenHocSinh)
                .HasMaxLength(250)
                .HasColumnName("TEN_HOC_SINH");
            entity.Property(e => e.Thang).HasColumnName("THANG");
            entity.Property(e => e.ThoiDiemThanhToan)
                .HasColumnType("datetime")
                .HasColumnName("THOI_DIEM_THANH_TOAN");
            entity.Property(e => e.TienDaThu)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TIEN_DA_THU");
            entity.Property(e => e.TienToPhieuThu)
                .HasMaxLength(50)
                .HasColumnName("TIEN_TO_PHIEU_THU");
            entity.Property(e => e.TongTienPhaiThu)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TONG_TIEN_PHAI_THU");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.PhieuThus)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_HOC_SINH");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.PhieuThus)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_LOP");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.PhieuThus)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.PhieuThus)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.PhieuThus)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_NAM_HOC");
        });

        modelBuilder.Entity<PhieuThuCt>(entity =>
        {
            entity.ToTable("PHIEU_THU_CT");

            entity.HasIndex(e => new { e.MaSoGd, e.IdTruong, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.HocKy, e.Thang, e.Nam, e.IdDotThu, e.MaKhoi, e.IdHocSinh, e.MaHocSinh, e.IdPhieuThu, e.LoaiCt, e.IdKhoanThu, e.IdLichSuThanhToan }, "IX_KEY").IsUnique();

            entity.HasIndex(e => e.LoaiCt, "IX_LOAI_CT");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaCapHoc, e.MaTruong }, "IX_NAM_SO_CAP_TRUONG");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdDotThu }, "IX_NAM_SO_CAP_TRUONG_DOT_THU");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.MaHocSinh }, "IX_NAM_SO_CAP_TRUONG_HOC_SINH");

            entity.HasIndex(e => new { e.MaSoGd, e.MaTruong, e.MaCapHoc, e.MaNamHoc, e.IdHocSinh }, "IX_NAM_SO_CAP_TRUONG_ID_HOC_SINH");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConLai)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("CON_LAI");
            entity.Property(e => e.DaThu)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("DA_THU");
            entity.Property(e => e.DonGia)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("DON_GIA");
            entity.Property(e => e.DonViTinh).HasColumnName("DON_VI_TINH");
            entity.Property(e => e.GhiChu)
                .HasMaxLength(250)
                .HasColumnName("GHI_CHU");
            entity.Property(e => e.HoanTra)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("HOAN_TRA");
            entity.Property(e => e.HocKy).HasColumnName("HOC_KY");
            entity.Property(e => e.IdDmMienGiam).HasColumnName("ID_DM_MIEN_GIAM");
            entity.Property(e => e.IdDotThu).HasColumnName("ID_DOT_THU");
            entity.Property(e => e.IdHocSinh)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_HOC_SINH");
            entity.Property(e => e.IdKhoanThu).HasColumnName("ID_KHOAN_THU");
            entity.Property(e => e.IdLichSuThanhToan).HasColumnName("ID_LICH_SU_THANH_TOAN");
            entity.Property(e => e.IdLop)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_LOP");
            entity.Property(e => e.IdPhieuThu).HasColumnName("ID_PHIEU_THU");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsEdited).HasColumnName("IS_EDITED");
            entity.Property(e => e.LoaiCt).HasColumnName("LOAI_CT");
            entity.Property(e => e.LoaiHoanTra).HasColumnName("LOAI_HOAN_TRA");
            entity.Property(e => e.MaCapHoc)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_HOC");
            entity.Property(e => e.MaHocSinh)
                .HasMaxLength(50)
                .HasColumnName("MA_HOC_SINH");
            entity.Property(e => e.MaKhoi)
                .HasMaxLength(50)
                .HasColumnName("MA_KHOI");
            entity.Property(e => e.MaLop)
                .HasMaxLength(50)
                .HasColumnName("MA_LOP");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaNhomTuoiMn)
                .HasMaxLength(50)
                .HasColumnName("MA_NHOM_TUOI_MN");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MienGiam)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MIEN_GIAM");
            entity.Property(e => e.Nam).HasColumnName("NAM");
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
            entity.Property(e => e.NoiDung)
                .HasMaxLength(250)
                .HasColumnName("NOI_DUNG");
            entity.Property(e => e.PcMienGiam)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PC_MIEN_GIAM");
            entity.Property(e => e.SoLuong).HasColumnName("SO_LUONG");
            entity.Property(e => e.SoLuongHt).HasColumnName("SO_LUONG_HT");
            entity.Property(e => e.SoLuongTruoc).HasColumnName("SO_LUONG_TRUOC");
            entity.Property(e => e.StMienGiam)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ST_MIEN_GIAM");
            entity.Property(e => e.Thang).HasColumnName("THANG");
            entity.Property(e => e.ThanhTien)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("THANH_TIEN");

            entity.HasOne(d => d.IdDmMienGiamNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.IdDmMienGiam)
                .HasConstraintName("FK_PHIEU_THU_CT_DM_MIEN_GIAM");

            entity.HasOne(d => d.IdHocSinhNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.IdHocSinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_CT_HOC_SINH");

            entity.HasOne(d => d.IdKhoanThuNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.IdKhoanThu)
                .HasConstraintName("FK_PHIEU_THU_CT_KHOAN_THU");

            entity.HasOne(d => d.IdLopNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.IdLop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_CT_LOP");

            entity.HasOne(d => d.IdPhieuThuNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.IdPhieuThu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_CT_PHIEU_THU");

            entity.HasOne(d => d.IdTruongNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.IdTruong)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_CT_TRUONG");

            entity.HasOne(d => d.MaCapHocNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.MaCapHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_CT_DM_CAP_HOC");

            entity.HasOne(d => d.MaNamHocNavigation).WithMany(p => p.PhieuThuCts)
                .HasForeignKey(d => d.MaNamHoc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PHIEU_THU_CT_NAM_HOC");
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

        modelBuilder.Entity<QuyenNguoiDung>(entity =>
        {
            entity.ToTable("QUYEN_NGUOI_DUNG");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdNguoiDung)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_NGUOI_DUNG");
            entity.Property(e => e.IdNhomQuyen).HasColumnName("ID_NHOM_QUYEN");
            entity.Property(e => e.MaNguoiDung)
                .HasMaxLength(50)
                .HasColumnName("MA_NGUOI_DUNG");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(50)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(50)
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<RefreshToken>(entity =>
        {
            entity.ToTable("RefreshToken");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ExpDate).HasColumnType("datetime");
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

        modelBuilder.Entity<TaiKhoanGuiTin>(entity =>
        {
            entity.ToTable("TAI_KHOAN_GUI_TIN");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IpAccess)
                .HasMaxLength(500)
                .HasColumnName("IP_ACCESS");
            entity.Property(e => e.IsCapGdtx).HasColumnName("IS_CAP_GDTX");
            entity.Property(e => e.IsCapMn).HasColumnName("IS_CAP_MN");
            entity.Property(e => e.IsCapTh).HasColumnName("IS_CAP_TH");
            entity.Property(e => e.IsCapThcs).HasColumnName("IS_CAP_THCS");
            entity.Property(e => e.IsCapThpt).HasColumnName("IS_CAP_THPT");
            entity.Property(e => e.MaCapDonVi)
                .HasMaxLength(50)
                .HasColumnName("MA_CAP_DON_VI");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(50)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(250)
                .HasColumnName("MAT_KHAU");
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
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(150)
                .HasColumnName("NGUOI_TAO");
            entity.Property(e => e.TaiKhoan)
                .HasMaxLength(50)
                .HasColumnName("TAI_KHOAN");
            entity.Property(e => e.TrangThai).HasColumnName("TRANG_THAI");
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
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(250)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(250)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(250)
                .HasColumnName("MA_TRUONG");
        });

        modelBuilder.Entity<Truong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TRUONG_1");

            entity.ToTable("TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.Ma }, "IX_KEY").IsUnique();

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd }, "IX_NAM_SO");

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

        modelBuilder.Entity<TruongDangKySuDung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TRUONG_DANG_KY_THU");

            entity.ToTable("TRUONG_DANG_KY_SU_DUNG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.IdTruong }, "IX_NAM_SO_ID_TRUONG");

            entity.HasIndex(e => new { e.MaNamHoc, e.MaSoGd, e.MaTruong }, "IX_NAM_SO_TRUONG");

            entity.HasIndex(e => new { e.MaTruong, e.MaNamHoc }, "IX_TRUONG_DANG_KY_SU_DUNG_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdPhongGd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_PHONG_GD");
            entity.Property(e => e.IdTruong)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_TRUONG");
            entity.Property(e => e.IsHoaDonDienTu).HasColumnName("IS_HOA_DON_DIEN_TU");
            entity.Property(e => e.IsThuPhi).HasColumnName("IS_THU_PHI");
            entity.Property(e => e.KyHieu)
                .HasMaxLength(50)
                .HasColumnName("KY_HIEU");
            entity.Property(e => e.MaBaoMat)
                .HasMaxLength(50)
                .HasColumnName("MA_BAO_MAT");
            entity.Property(e => e.MaLoaiHoaDon)
                .HasMaxLength(50)
                .HasColumnName("MA_LOAI_HOA_DON");
            entity.Property(e => e.MaMauHoaDon)
                .HasMaxLength(50)
                .HasColumnName("MA_MAU_HOA_DON");
            entity.Property(e => e.MaNamHoc).HasColumnName("MA_NAM_HOC");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(20)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaSoThue)
                .HasMaxLength(50)
                .HasColumnName("MA_SO_THUE");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(50)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(50)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(50)
                .HasColumnName("NGUOI_TAO");
        });

        modelBuilder.Entity<TruongDoiTacThanhToan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TRUONG_DANG_KY_KENH_THANH_TOAN");

            entity.ToTable("TRUONG_DOI_TAC_THANH_TOAN");

            entity.HasIndex(e => new { e.IdDoiTacThanhToan, e.IdTruongDangKySuDung }, "IX_TRUONG_DANG_KY_KENH_THANH_TOAN_UNIQUE").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdDoiTacThanhToan).HasColumnName("ID_DOI_TAC_THANH_TOAN");
            entity.Property(e => e.IdTruongDangKySuDung).HasColumnName("ID_TRUONG_DANG_KY_SU_DUNG");
            entity.Property(e => e.IsDangKy).HasColumnName("IS_DANG_KY");
            entity.Property(e => e.NgaySua)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_SUA");
            entity.Property(e => e.NgayTao)
                .HasColumnType("datetime")
                .HasColumnName("NGAY_TAO");
            entity.Property(e => e.NguoiSua)
                .HasMaxLength(50)
                .HasColumnName("NGUOI_SUA");
            entity.Property(e => e.NguoiTao)
                .HasMaxLength(50)
                .HasColumnName("NGUOI_TAO");

            entity.HasOne(d => d.IdDoiTacThanhToanNavigation).WithMany(p => p.TruongDoiTacThanhToans)
                .HasForeignKey(d => d.IdDoiTacThanhToan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRUONG_DOI_TAC_THANH_TOAN_DOI_TAC_THANH_TOAN");

            entity.HasOne(d => d.IdTruongDangKySuDungNavigation).WithMany(p => p.TruongDoiTacThanhToans)
                .HasForeignKey(d => d.IdTruongDangKySuDung)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TRUONG_DOI_TAC_THANH_TOAN_TRUONG_DANG_KY_SU_DUNG");
        });

        modelBuilder.Entity<XemThongBao>(entity =>
        {
            entity.ToTable("XEM_THONG_BAO");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdNguoiDung)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("ID_NGUOI_DUNG");
            entity.Property(e => e.IdThongBaoDieuHanh).HasColumnName("ID_THONG_BAO_DIEU_HANH");
            entity.Property(e => e.MaPhongGd)
                .HasMaxLength(250)
                .HasColumnName("MA_PHONG_GD");
            entity.Property(e => e.MaSoGd)
                .HasMaxLength(250)
                .HasColumnName("MA_SO_GD");
            entity.Property(e => e.MaTruong)
                .HasMaxLength(250)
                .HasColumnName("MA_TRUONG");
            entity.Property(e => e.ThoiGianXem)
                .HasColumnType("datetime")
                .HasColumnName("THOI_GIAN_XEM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
