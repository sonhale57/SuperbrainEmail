using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace SuperbrainEmail.Models
{
    public partial class ModelDbContext : DbContext
    {
        public ModelDbContext()
            : base("name=ModelDbContext")
        {
        }

        public virtual DbSet<Bangdiem> Bangdiems { get; set; }
        public virtual DbSet<ChiNhanh> ChiNhanhs { get; set; }
        public virtual DbSet<Chuongtrinh> Chuongtrinhs { get; set; }
        public virtual DbSet<Config> Configs { get; set; }
        public virtual DbSet<Config_data_text> Config_data_text { get; set; }
        public virtual DbSet<Congno> Congnoes { get; set; }
        public virtual DbSet<Dangky> Dangkies { get; set; }
        public virtual DbSet<Dangky_group> Dangky_group { get; set; }
        public virtual DbSet<Dangky_kho_default> Dangky_kho_default { get; set; }
        public virtual DbSet<dangky_thukhac> dangky_thukhac { get; set; }
        public virtual DbSet<Danhgia_taphuan> Danhgia_taphuan { get; set; }
        public virtual DbSet<DiemDanh> DiemDanhs { get; set; }
        public virtual DbSet<Diemdanh_style1> Diemdanh_style1 { get; set; }
        public virtual DbSet<Diemdanh_style2> Diemdanh_style2 { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Donhang_cat> Donhang_cat { get; set; }
        public virtual DbSet<Donhang_setting> Donhang_setting { get; set; }
        public virtual DbSet<Email_Cat> Email_Cat { get; set; }
        public virtual DbSet<Email_send> Email_send { get; set; }
        public virtual DbSet<FAQ> FAQs { get; set; }
        public virtual DbSet<Feed_news> Feed_news { get; set; }
        public virtual DbSet<Feed_news_users> Feed_news_users { get; set; }
        public virtual DbSet<Folder> Folders { get; set; }
        public virtual DbSet<Folder_FIles> Folder_FIles { get; set; }
        public virtual DbSet<Folder_users> Folder_users { get; set; }
        public virtual DbSet<Giao_vien> Giao_vien { get; set; }
        public virtual DbSet<Giaovien_Taphuan> Giaovien_Taphuan { get; set; }
        public virtual DbSet<Hocphi> Hocphis { get; set; }
        public virtual DbSet<Hocsinh> Hocsinhs { get; set; }
        public virtual DbSet<Hocsinh_CNKK> Hocsinh_CNKK { get; set; }
        public virtual DbSet<Hocsinh_CNKK_cat> Hocsinh_CNKK_cat { get; set; }
        public virtual DbSet<Hocsinh_log> Hocsinh_log { get; set; }
        public virtual DbSet<Hocsinh_voucher> Hocsinh_voucher { get; set; }
        public virtual DbSet<Ketqua_style1> Ketqua_style1 { get; set; }
        public virtual DbSet<Ketqua_style2> Ketqua_style2 { get; set; }
        public virtual DbSet<Ketquan_style2_tb1> Ketquan_style2_tb1 { get; set; }
        public virtual DbSet<Kho> Khoes { get; set; }
        public virtual DbSet<KHO_Chitietphieu> KHO_Chitietphieu { get; set; }
        public virtual DbSet<Kho_Head> Kho_Head { get; set; }
        public virtual DbSet<KHO_Phieunhapxuat> KHO_Phieunhapxuat { get; set; }
        public virtual DbSet<KHO_Vattu> KHO_Vattu { get; set; }
        public virtual DbSet<KHOADAOTAO_Thanhtoanphi> KHOADAOTAO_Thanhtoanphi { get; set; }
        public virtual DbSet<Khoahoc> Khoahocs { get; set; }
        public virtual DbSet<KhoaHoc_ChiNhanh> KhoaHoc_ChiNhanh { get; set; }
        public virtual DbSet<Khoahoc_kho> Khoahoc_kho { get; set; }
        public virtual DbSet<KhoaTapHuan> KhoaTapHuans { get; set; }
        public virtual DbSet<KHOVATTU_Chitietphieu> KHOVATTU_Chitietphieu { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Logs_print> Logs_print { get; set; }
        public virtual DbSet<Lop_TKB> Lop_TKB { get; set; }
        public virtual DbSet<Lophoc> Lophocs { get; set; }
        public virtual DbSet<Lophoc_diemdanh> Lophoc_diemdanh { get; set; }
        public virtual DbSet<Lophoc_join> Lophoc_join { get; set; }
        public virtual DbSet<lophoc_log> lophoc_log { get; set; }
        public virtual DbSet<NCC> NCCs { get; set; }
        public virtual DbSet<Nhan_su> Nhan_su { get; set; }
        public virtual DbSet<Nhan_su_lop> Nhan_su_lop { get; set; }
        public virtual DbSet<Nhansu_ChamCong> Nhansu_ChamCong { get; set; }
        public virtual DbSet<Nhansu_ghichu> Nhansu_ghichu { get; set; }
        public virtual DbSet<Nhansu_Log> Nhansu_Log { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderStatu> OrderStatus { get; set; }
        public virtual DbSet<Permission_join> Permission_join { get; set; }
        public virtual DbSet<Permission_mod> Permission_mod { get; set; }
        public virtual DbSet<Permission_mod_cat> Permission_mod_cat { get; set; }
        public virtual DbSet<Permission_Template> Permission_Template { get; set; }
        public virtual DbSet<PhieuNhap_xuat> PhieuNhap_xuat { get; set; }
        public virtual DbSet<PhongHoc> PhongHocs { get; set; }
        public virtual DbSet<Style_format> Style_format { get; set; }
        public virtual DbSet<taisan> taisans { get; set; }
        public virtual DbSet<taisan_cat> taisan_cat { get; set; }
        public virtual DbSet<Taisan_Nhap_Xuat> Taisan_Nhap_Xuat { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Test_auto> Test_auto { get; set; }
        public virtual DbSet<Thanhtoan_taphuan> Thanhtoan_taphuan { get; set; }
        public virtual DbSet<Thanhtoan_ThiTQ> Thanhtoan_ThiTQ { get; set; }
        public virtual DbSet<Thanhtoan_User> Thanhtoan_User { get; set; }
        public virtual DbSet<Thongke_Head> Thongke_Head { get; set; }
        public virtual DbSet<Thu_Chi> Thu_Chi { get; set; }
        public virtual DbSet<ThuChi> ThuChis { get; set; }
        public virtual DbSet<TKB_log> TKB_log { get; set; }
        public virtual DbSet<TKB_Risk> TKB_Risk { get; set; }
        public virtual DbSet<Trangthai_donhang> Trangthai_donhang { get; set; }
        public virtual DbSet<User_permision> User_permision { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Users_module> Users_module { get; set; }
        public virtual DbSet<ThiTQ> ThiTQs { get; set; }
        public virtual DbSet<ThiTQ_Rank> ThiTQ_Rank { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bangdiem>()
                .Property(e => e.idhocsinh)
                .IsFixedLength();

            modelBuilder.Entity<Bangdiem>()
                .Property(e => e.idlop)
                .IsFixedLength();

            modelBuilder.Entity<Bangdiem>()
                .Property(e => e.diem)
                .IsFixedLength();

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.thongtin_block1)
                .IsFixedLength();

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.caidat_block)
                .IsFixedLength();

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.soluonglop)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.testdauvao)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.chiphi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ChiNhanh>()
                .Property(e => e.dienthoaiThiTQ)
                .IsUnicode(false);

            modelBuilder.Entity<ChiNhanh>()
                .HasMany(e => e.Notifications)
                .WithOptional(e => e.ChiNhanh)
                .HasForeignKey(e => e.toChiNhanh);

            modelBuilder.Entity<ChiNhanh>()
                .HasMany(e => e.Thongke_Head)
                .WithOptional(e => e.ChiNhanh)
                .HasForeignKey(e => e.idChiNhanh);

            modelBuilder.Entity<ChiNhanh>()
                .HasMany(e => e.Email_Cat)
                .WithMany(e => e.ChiNhanhs)
                .Map(m => m.ToTable("Emai_ChiNhanh").MapLeftKey("idChiNhanh").MapRightKey("idEmail"));

            modelBuilder.Entity<Config>()
                .Property(e => e.Phithuonghieu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Config>()
                .Property(e => e.Phitaikhoan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Congno>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Congno>()
                .Property(e => e.thanhtoan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.MADK)
                .IsUnicode(false);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.Hocphi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.Phitailieu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Dangky>()
                .Property(e => e.Tonghocphi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Dangky_group>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<dangky_thukhac>()
                .Property(e => e.soluong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<dangky_thukhac>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<dangky_thukhac>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<dangky_thukhac>()
                .Property(e => e.CK)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Diemdanh_style1>()
                .Property(e => e.nhanxet_block)
                .IsFixedLength();

            modelBuilder.Entity<Donhang>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang>()
                .Property(e => e.soluong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang>()
                .Property(e => e.thanhtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_cat>()
                .HasMany(e => e.Trangthai_donhang)
                .WithRequired(e => e.Donhang_cat)
                .HasForeignKey(e => e.iddonhang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.dongia1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.soluong1)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.dongia2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.soluong2)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.dongia3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.soluong3)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.tonkho)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.dinhmuc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .Property(e => e.dongiacoso)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Donhang_setting>()
                .HasMany(e => e.Kho_Head)
                .WithRequired(e => e.Donhang_setting)
                .HasForeignKey(e => e.idsanpham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FAQ>()
                .Property(e => e.Mota)
                .IsUnicode(false);

            modelBuilder.Entity<FAQ>()
                .Property(e => e.hinhanh)
                .IsUnicode(false);

            modelBuilder.Entity<Feed_news>()
                .HasMany(e => e.Feed_news_users)
                .WithOptional(e => e.Feed_news)
                .HasForeignKey(e => e.idfeed)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Folder>()
                .HasMany(e => e.Folder_FIles)
                .WithOptional(e => e.Folder)
                .HasForeignKey(e => e.idfolder)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Giao_vien>()
                .HasMany(e => e.Nhansu_ChamCong)
                .WithOptional(e => e.Giao_vien)
                .HasForeignKey(e => e.idnhansu);

            modelBuilder.Entity<Giao_vien>()
                .HasMany(e => e.Nhansu_ghichu)
                .WithOptional(e => e.Giao_vien)
                .HasForeignKey(e => e.idnhansu);

            modelBuilder.Entity<Hocphi>()
                .Property(e => e.thucthu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Hocphi>()
                .Property(e => e.thanhtoan)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Hocsinh_voucher>()
                .Property(e => e.voucher)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Kho>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Kho>()
                .Property(e => e.tonkho)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Kho>()
                .Property(e => e.dinhmuc)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHO_Chitietphieu>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHO_Chitietphieu>()
                .Property(e => e.thanhtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Kho_Head>()
                .Property(e => e.Soluong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHO_Phieunhapxuat>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<KHO_Phieunhapxuat>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHO_Phieunhapxuat>()
                .Property(e => e.debit)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHO_Vattu>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHOADAOTAO_Thanhtoanphi>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Khoahoc>()
                .Property(e => e.HP_full)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Khoahoc>()
                .Property(e => e.thoiluong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Khoahoc>()
                .Property(e => e.diemquakhoa)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhoaHoc_ChiNhanh>()
                .Property(e => e.HP_full)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhoaHoc_ChiNhanh>()
                .Property(e => e.tkonline)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhoaHoc_ChiNhanh>()
                .Property(e => e.tktestdauvao)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhoaTapHuan>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHOVATTU_Chitietphieu>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KHOVATTU_Chitietphieu>()
                .Property(e => e.thanhtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.giatri)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Lophoc>()
                .Property(e => e.buoihoc)
                .HasPrecision(18, 1);

            modelBuilder.Entity<NCC>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NCC>()
                .Property(e => e.MST)
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_su>()
                .Property(e => e.cmnd)
                .IsUnicode(false);

            modelBuilder.Entity<Nhan_su_lop>()
                .Property(e => e.idlop)
                .IsFixedLength();

            modelBuilder.Entity<Nhansu_ChamCong>()
                .Property(e => e.Diem)
                .HasPrecision(2, 1);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderDetail>()
                .Property(e => e.thanhtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<taisan>()
                .Property(e => e.id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<taisan>()
                .Property(e => e.gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<taisan>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Taisan_Nhap_Xuat>()
                .Property(e => e.soluong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Taisan_Nhap_Xuat>()
                .Property(e => e.dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Taisan_Nhap_Xuat>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Taisan_Nhap_Xuat>()
                .Property(e => e.CK)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Test_auto>()
                .Property(e => e.radiobox)
                .IsFixedLength();

            modelBuilder.Entity<Test_auto>()
                .Property(e => e.file1)
                .IsFixedLength();

            modelBuilder.Entity<Thanhtoan_taphuan>()
                .Property(e => e.phi)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Thanhtoan_User>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Thanhtoan_User>()
                .Property(e => e.uudai)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Thongke_Head>()
                .Property(e => e.tonkho)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Thongke_Head>()
                .Property(e => e.soluong)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Thu_Chi>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ThuChi>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<ThuChi>()
                .Property(e => e.loai)
                .IsUnicode(false);

            modelBuilder.Entity<ThuChi>()
                .Property(e => e.tongtien)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ThuChi>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<ThuChi>()
                .Property(e => e.chietkhau)
                .HasPrecision(18, 0);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Users1)
                .WithRequired(e => e.User1);

            modelBuilder.Entity<Users_module>()
                .HasMany(e => e.User_permision)
                .WithOptional(e => e.Users_module)
                .HasForeignKey(e => e.idmodule);
        }
    }
}
