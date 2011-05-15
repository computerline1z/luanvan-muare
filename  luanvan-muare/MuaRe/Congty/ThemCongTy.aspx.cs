using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;
using System.Data.SqlClient;

namespace MuaRe.Congty
{
    public partial class ThemCongTy : System.Web.UI.Page
    {       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInfo();
            }                
        }

        protected void LoadInfo()
        {
            try
            {
                ViewState["mact"] = Int32.Parse(Request.QueryString["mact"]);

                CongTyBUS ctBus = new CongTyBUS();
                CongTy congty = ctBus.TimKiem((int)ViewState["mact"]);
                tenctTxt.Text = congty.Tenct + "";
                nguoiDaiDienTxt.Text = congty.NguoiDaiDien + "";
                diaChiTxt.Text = congty.DiaChi + "";
                dienThoaiTxt.Text = congty.DienThoai + "";
                emailTxt.Text = congty.Email + "";
                websiteUrlTxt.Text = congty.WebsiteUrl + ""; 
                faxTxt.Text = congty.Fax + "";
                gioiThieuTxt.Text = congty.GioiThieu + "";

                capnhatBtn.Visible = true;
            }
            catch (ArgumentNullException)
            {
                luuBtn.Visible = true;
            }            
        }

        protected void luuBtn_Click(object sender, EventArgs e)
        {
            CongTy congty = new CongTy();
            congty.Tenct = tenctTxt.Text;
            congty.NguoiDaiDien = nguoiDaiDienTxt.Text;
            congty.DiaChi = diaChiTxt.Text;
            congty.DienThoai = dienThoaiTxt.Text;
            congty.Email = emailTxt.Text;
            congty.WebsiteUrl = websiteUrlTxt.Text;
            congty.Fax = faxTxt.Text;
            congty.GioiThieu = gioiThieuTxt.Text;

            CongTyBUS ctBus = new CongTyBUS();
            ctBus.Them(congty);
            Response.Redirect("DanhSachCongTy.aspx");
            
        }

        protected void capnhatBtn_Click(object sender, EventArgs e)
        {            
            CongTy congty = new CongTy();
            congty.Mact = (int)ViewState["mact"];
            congty.Tenct = tenctTxt.Text;
            congty.NguoiDaiDien = nguoiDaiDienTxt.Text + "";
            congty.DiaChi = diaChiTxt.Text + "";
            congty.DienThoai = dienThoaiTxt.Text + "";
            congty.Email = emailTxt.Text + "";
            congty.WebsiteUrl = websiteUrlTxt.Text + "";
            congty.Fax = faxTxt.Text + "";
            congty.GioiThieu = gioiThieuTxt.Text + "";
            
            CongTyBUS ctBus = new CongTyBUS();
            ctBus.Sua(congty);
            Response.Redirect("DanhSachCongTy.aspx");
        }
    }
}