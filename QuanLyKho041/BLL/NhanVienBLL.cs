using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class NhanVienBLL
    {
        QLKhoDataContext DB = new QLKhoDataContext();
        public static bool phanquyen;
        

        public NhanVienBLL()
        {

        }

        
        public List<NhanVien> LayTatCa()
        {
            return DB.NhanViens.ToList();
        }

        public NhanVien layTheoMa(int ma)
        {
            return DB.NhanViens.Where(nv => nv.MaNV == ma).FirstOrDefault();
        }
        public NhanVien layTheoTendangnhapVaMatkhau(string tendangnhap, string matkhau)
        {
            return DB.NhanViens.Where(nv => nv.TenDangNhap == tendangnhap && nv.MatKhau == matkhau).FirstOrDefault();
        }

        public NhanVien layquyen(bool _quyen)
        {
            return DB.NhanViens.Where(nv => nv.QuanTriVien == _quyen).FirstOrDefault();
        }


        public void Them(string tenNV, string chucVu, DateTime ngaySinh, int gioiTinh, string soDT, string tenDangNhap, string email, string matKhau, bool quanTriVien,int quyen)
        {
            NhanVien nv = new NhanVien();

            nv.TenNV = tenNV;
            nv.ChucVu = chucVu;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.SoDT = soDT;
            nv.TenDangNhap = tenDangNhap;
            nv.Email = email;
            nv.MatKhau = matKhau;
            nv.QuanTriVien = quanTriVien;
            nv.Quyen = quyen;

            DB.NhanViens.InsertOnSubmit(nv);

            DB.SubmitChanges();
        }
        public void updateNV(string _name,string _chucvu,DateTime _ns,int _gt,string _sdt,string _username,string _mail,string _password,bool _qtv,int _quyen)
        {
            NhanVien nv = new NhanVien();

            nv.TenNV = _name;
            nv.ChucVu = _chucvu;
            nv.NgaySinh = _ns;
            nv.GioiTinh = _gt;
            nv.SoDT = _sdt;
            nv.TenDangNhap = _username;
            nv.Email = _mail;
            nv.MatKhau = _password;
            nv.QuanTriVien = _qtv;
            nv.Quyen = _quyen;

            DB.NhanViens.InsertOnSubmit(nv);

            DB.SubmitChanges();
        }

        public void Sua(int maNV, string tenNV, string chucVu, DateTime ngaySinh, int gioiTinh, string soDT, string tenDangNhap, string email, string matKhau, bool quanTriVien,int quen)
        {
            NhanVien nv = layTheoMa(maNV);

            nv.TenNV = tenNV;
            nv.ChucVu = chucVu;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.SoDT = soDT;
            nv.TenDangNhap = tenDangNhap;
            nv.Email = email;
            nv.MatKhau = matKhau;
            nv.QuanTriVien = quanTriVien;
            nv.Quyen = quen;

            DB.SubmitChanges();
        }

        public void CapNhat(int maNV, string tenNV, string chucVu, DateTime ngaySinh, int gioiTinh, string soDT, string tenDangNhap, string email)
        {
            NhanVien nv = layTheoMa(maNV);

            nv.TenNV = tenNV;
            nv.ChucVu = chucVu;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.SoDT = soDT;
            nv.TenDangNhap = tenDangNhap;
            nv.Email = email;

            DB.SubmitChanges();
        }

        public void DoiMatKhau(int maNV, string matKhau)
        {
            NhanVien nv = layTheoMa(maNV);

            nv.MatKhau = matKhau;

            DB.SubmitChanges();
        }


        public void Xoa(int maNV)
        {
            NhanVien nv = layTheoMa(maNV);
            DB.NhanViens.DeleteOnSubmit(nv);
            DB.SubmitChanges();
        }
        public void xoa_nv(int _id_d)
        {
            NhanVien nv_d=new NhanVien();
            nv_d.MaNV = _id_d;
            NhanVien nhanvien_d = DB.NhanViens.Where(xoanv => xoanv.MaNV == _id_d).FirstOrDefault();
            if(nhanvien_d != null)
            {
                DB.NhanViens.DeleteOnSubmit(nhanvien_d);
                DB.SubmitChanges();
            }
        }

        public void adm_themnv(string tenNV, string chucVu, DateTime ngaySinh, int gioiTinh, string soDT, string tenDangNhap, string email, string matKhau, bool quanTriVien,int quyen)
        {
            NhanVien nv = new NhanVien();

            nv.TenNV = tenNV;
            nv.ChucVu = chucVu;
            nv.NgaySinh = ngaySinh;
            nv.GioiTinh = gioiTinh;
            nv.SoDT = soDT;
            nv.TenDangNhap = tenDangNhap;
            nv.Email = email;
            nv.MatKhau = matKhau;
            nv.QuanTriVien = quanTriVien;
            nv.Quyen= quyen;

            DB.NhanViens.InsertOnSubmit(nv);

            DB.SubmitChanges();
        }

        public void adm_suanv(int id_up,string _tennv,string _chucvu,int _quyen)
        {
            NhanVien nv_up = DB.NhanViens.Where(nvsua => nvsua.MaNV == id_up).FirstOrDefault();
            if (nv_up != null)
            {
                nv_up.TenNV = _tennv;
                nv_up.ChucVu = _chucvu;
                nv_up.Quyen = _quyen;
                DB.SubmitChanges();
            }
        }

    }
}
