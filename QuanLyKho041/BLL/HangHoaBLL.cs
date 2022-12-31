using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using DAL;

namespace BLL
{
    public class HangHoaBLL
    {
        QLKhoDataContext DB = new QLKhoDataContext();

        public HangHoaBLL()
        {

        }

        public List<HangHoa> danhsach()
        {
            return DB.HangHoas.ToList();
        }

        public void them(string ten,string mota,string hinhanh,int maNhomHang, string xuatxu)
        {
            HangHoa hh = new HangHoa();
            hh.TenHH = ten;
            hh.MoTa = mota;
            hh.HinhAnh = hinhanh;
            hh.MaNH = maNhomHang;
            hh.XuatXu = xuatxu;

            DB.HangHoas.InsertOnSubmit(hh);
            DB.SubmitChanges();
        }

        //sua hh
        public void sua(int _id_u,string _name_u,string _mota_u,string _ha_u,int _idlh_u,string _xuatxu_u)
        {
            HangHoa hh_u = DB.HangHoas.Where(shh => shh.MaHH == _id_u).FirstOrDefault();
            if(hh_u!=null)
            {
                hh_u.TenHH = _name_u;
                hh_u.MoTa = _mota_u;
                hh_u.HinhAnh= _ha_u;
                hh_u.MaNH = _idlh_u;
                hh_u.XuatXu = _xuatxu_u;
                DB.SubmitChanges();
            }
        }

        //xoa hh
        public void xoa(int _id_d)
        {
            HangHoa hh_d = new HangHoa();
            hh_d.MaHH = _id_d;
            HangHoa hhx = DB.HangHoas.Where(xhh => xhh.MaHH == _id_d).FirstOrDefault();
            if(hhx!=null)
            {
                DB.HangHoas.DeleteOnSubmit(hhx);
                DB.SubmitChanges();
            }
        }
    }
}
