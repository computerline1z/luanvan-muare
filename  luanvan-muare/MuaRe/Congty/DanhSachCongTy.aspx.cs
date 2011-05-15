using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Collections;
using BUS;
using DTO;

namespace MuaRe.Congty
{
    public partial class DanhSachCongTy : System.Web.UI.Page
    {
        private DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            getData();
        }

        protected void getData()
        {            
            CongTy congty = new CongTy();
            CongTyBUS ctBus = new CongTyBUS();

            dt = ctBus.LayBang();
            danhSachGrid.DataSource = dt;
            danhSachGrid.DataBind();
            foreach (GridViewRow gr in this.danhSachGrid.Rows)
            {
                ImageButton xoa = (ImageButton)gr.FindControl("xoaBtn");
                xoa.Attributes.Add("onclick", "return confirm_delete()");
            }            
        }

        protected void danhSachGrid_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            danhSachGrid.PageIndex = e.NewPageIndex;
            getData();
        }

        protected void Sua_ImageBtn(object sender, CommandEventArgs e)
        {
            string mact = e.CommandArgument.ToString();
            Response.Redirect("ThemCongTy.aspx?mact=" + mact);            
        }

        protected void Xoa_ImageBtn(object sender, CommandEventArgs e)
        {                                    
            try
            {
               int mact = Int32.Parse(e.CommandArgument.ToString());
               CongTyBUS ctBus = new CongTyBUS();
               ctBus.Xoa(mact);
            }
            catch (ArgumentNullException) { }
            Response.Redirect("DanhSachCongTy.aspx");
        }

        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod]
        public static string[] GetCompletionList(string prefixText, int count, string contextKey)
        {            
           List<string> list = new List<string>();
           CongTy congty = new CongTy();
           CongTyBUS ctBus = new CongTyBUS();

           DataTable dt = ctBus.LayBang();
            foreach (DataRow r in dt.Rows)
            {
                list.Add(r["tenct"].ToString());
            }           

            // Return matching movies  
            return (from m in list.ToArray() where m.StartsWith(prefixText, StringComparison.CurrentCultureIgnoreCase) select m).Take(count).ToArray();
        }

        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string tenct = searchTxt.Text;
            CongTyBUS ctBus = new CongTyBUS();
            dt = ctBus.TimKiem(tenct);
            danhSachGrid.DataSource = dt;
            danhSachGrid.DataBind();
        }       
    }
}