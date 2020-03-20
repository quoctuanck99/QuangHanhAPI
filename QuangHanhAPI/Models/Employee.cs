using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuangHanhAPI.Models
{
    public class Employee
    {
        public string MaNV { get; set; }
        public string Ten { get; set; }
        public string Tenkhac { get; set; }
        public bool GioiTinh { get; set; }
        public string CapUyHienTai { get; set; }
        public string CapUyKiem { get; set; }
        public Nullable<double> PhuCapChucVu { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string DanToc { get; set; }
        public string QueQuan { get; set; }
        public string TonGiao { get; set; }
        public string NoiOHienTai { get; set; }
        public string SoDienThoai { get; set; }
        public string TPGiaDinhXuatThan { get; set; }
        public Nullable<System.DateTime> NgayThamGiaCachMang { get; set; }
        public Nullable<System.DateTime> NgayVaoDangCSVN { get; set; }
        public Nullable<System.DateTime> NgayChinhThuc { get; set; }
        public Nullable<System.DateTime> NgayVaoToChucCTXH { get; set; }
        public string ToChuc { get; set; }
        public Nullable<System.DateTime> NgayNhapNgu { get; set; }
        public Nullable<System.DateTime> NgayXuatNgu { get; set; }
        public string QuanHamChucVuCaoNhat { get; set; }
        public string HocHamHocViCaoNhat { get; set; }
        public string LyLuanChinhTri { get; set; }
        public string NgoaiNgu { get; set; }
        public string CongTacChinhDangLam { get; set; }
        public string NgachCongChuc { get; set; }
        public Nullable<double> MaNgach { get; set; }
        public string DanhHieuDuocPhong { get; set; }
        public string SoTruongCongTac { get; set; }
        public string CongViecDaLamLauNhat { get; set; }
        public string KhenThuong { get; set; }
        public string KyLuat { get; set; }
        public string TinhTrangSucKhoe { get; set; }
        public string ChiTietSucKhoe { get; set; }
        public Nullable<double> ChieuCao { get; set; }
        public Nullable<double> CanNang { get; set; }
        public string NhomMau { get; set; }
        public string HangThuongBinh { get; set; }
        public string GiaDinhChinhSach { get; set; }
        public string SoCMND { get; set; }
        public Nullable<System.DateTime> NgayCapCMND { get; set; }
        public string NoiCapCMND { get; set; }
        public Nullable<System.DateTime> NgayDiLam { get; set; }
        public Nullable<int> MaUyQuyen { get; set; }
        public string SoBHXH { get; set; }
        public Nullable<System.DateTime> NgayTraBHXH { get; set; }
        public Nullable<int> MaCongViec { get; set; }
        public Nullable<double> MucLuong { get; set; }
        public Nullable<int> MaTrinhDo { get; set; }
        public Nullable<int> MaTruong { get; set; }
        public string BacLuong { get; set; }
        public string NgheTruoc { get; set; }
        public Nullable<System.DateTime> NgayTuyenDungTruoc { get; set; }
        public string CoQuanTruoc { get; set; }
        public Nullable<double> HeSo { get; set; }
        public Nullable<int> TuThang { get; set; }
        public int MaTrangThai { get; set; }
        public string MaChuyenNganh { get; set; }
        public string MaPhongBan { get; set; }
        public Nullable<int> MaBacLuong_ThangLuong_MucLuong { get; set; }
    }
}