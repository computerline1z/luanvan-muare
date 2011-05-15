using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class CongTyBUS
    {
        // Them
        public void Them(CongTy pDto)
        {
            CongTyDAO pDao = new CongTyDAO();
            pDao.Them(pDto);
        }
        // Xoa
        public void Xoa(int mact)
        {
            CongTyDAO pDao = new CongTyDAO();
            pDao.Xoa(mact);
        }
        // Sua
        public void Sua(CongTy pDto)
        {
            CongTyDAO pDao = new CongTyDAO();
            pDao.Sua(pDto);
        }
        // Tim Kiem
        public CongTy TimKiem(int mact)
        {
            CongTyDAO pDao = new CongTyDAO();
            return (pDao.TimKiem(mact));
        }
        public DataTable TimKiem(string tenct)
        {
            CongTyDAO pDao = new CongTyDAO();
            return (pDao.TimKiem(tenct));
        }
        // Lay Bang
        public DataTable LayBang()
        {
            CongTyDAO pDao = new CongTyDAO();
            DataTable dt = pDao.LayBang();
            return dt;
        }
        // Cap Nhat Bang
        public void CapNhatBang(DataTable dt)
        {
            CongTyDAO pDao = new CongTyDAO();
            pDao.CapNhatBang(dt);
        }
        // Lay Danh Sach
        public IList LayDanhSach()
        {
            CongTyDAO pDao = new CongTyDAO();
            IList ds;
            ds = pDao.LayDanhSach();
            return ds;
        }
    }
}
