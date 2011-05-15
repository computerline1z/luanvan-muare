using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class CongTy
    {
        
        #region field
        int mact;
        String tenct;
        String diaChi;
        String email;
        String nguoiDaiDien;
        String websiteUrl;
        String dienThoai;
        String fax;
        String gioiThieu;
        #endregion
        #region properties
        public int Mact
        {
            get { return mact; }
            set { mact = value; }
        }


        public String Tenct
        {
            get { return tenct; }
            set { tenct = value; }
        }


        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }


        public String Email
        {
            get { return email; }
            set { email = value; }
        }


        public String NguoiDaiDien
        {
            get { return nguoiDaiDien; }
            set { nguoiDaiDien = value; }
        }


        public String WebsiteUrl
        {
            get { return websiteUrl; }
            set { websiteUrl = value; }
        }


        public String DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }


        public String Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public String GioiThieu
        {
            get { return gioiThieu; }
            set { gioiThieu = value; }
        }

        #endregion
        public CongTy()
        {

        }
    }
}
