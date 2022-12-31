using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.Linq;

namespace BLL
{
    public class LoaiHangBLL
    {
        QLKhoDataContext DB = new QLKhoDataContext();

        public LoaiHangBLL()
        {

        }

        //them loai hang
        public void them(string ten, string mota)
        {
            LoaiHang lh = new LoaiHang();
            lh.TenNH = ten;
            lh.MoTa = mota;

            DB.LoaiHangs.InsertOnSubmit(lh);
            DB.SubmitChanges();
        }

        //load danh sach
        public List<LoaiHang> danhsach()
        {
            return DB.LoaiHangs.ToList();
        }

        //sua loai hang
        public void sua(int _id_u,string _name_u,string _catdesc_u)
        {
            LoaiHang lh_u = DB.LoaiHangs.Where(slh => slh.MaNH == _id_u).FirstOrDefault();
            if(lh_u != null)
            {
                lh_u.TenNH = _name_u;
                lh_u.MoTa = _catdesc_u;
                DB.SubmitChanges();
            }

        }

        //xoa loai hang
        public void xoa(int _id_d)
        {
            LoaiHang lh_x = new LoaiHang();
            lh_x.MaNH = _id_d;
            LoaiHang lh_d = DB.LoaiHangs.Where(xlh => xlh.MaNH == _id_d).FirstOrDefault();
            if(lh_d != null)
            {
                DB.LoaiHangs.DeleteOnSubmit(lh_d);
                DB.SubmitChanges();
            }
        }
    }
}
