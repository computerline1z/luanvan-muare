using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class CongTyDAO
    {
        public IList LayDanhSach()
        {
            ArrayList ds = new ArrayList();
            SqlConnection cn;
            string strSQL;
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            strSQL = "Select * From CongTy";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            CongTy obj = new CongTy();
            while (dr.Read())
            {
                obj.Mact = (int)dr["mact"];
                obj.Tenct = (string)dr["tenct"];
                obj.NguoiDaiDien = (string)dr["nguoiDaiDien"];
                obj.DiaChi = (string)dr["diaChi"];
                obj.DienThoai = (string)dr["dienThoai"];
                obj.Email = (string)dr["email"];
                obj.WebsiteUrl = (string)dr["websiteUrl"];
                obj.Fax = (string)dr["fax"];
                obj.GioiThieu= (string)dr["gioiThieu"];
                ds.Add(obj);
            }
            // B5: Dong ket noi CSDL
            cn.Close();
            return ds;
        }

        public DataTable LayBang()
        {
            DataTable dt = new DataTable();
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Select * From CongTy";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
            da.Fill(dt);
            // B5: Dong ket noi CSDL
            cn.Close();
            return dt;
        }

        public void CapNhatBang(DataTable dt)
        {
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Select * From CongTy";
            SqlDataAdapter da = new SqlDataAdapter(strSQL, cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            // B5: Dong ket noi CSDL
            cn.Close();
        }

        public CongTy TimKiem(int mact)
        {
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Select * From CongTy Where mact = @mact";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.Add("@mact", SqlDbType.Int);
            cmd.Parameters["@mact"].Value = mact;
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            CongTy obj = new CongTy();
            while (dr.Read())
            {
                obj.Mact = (int)dr["mact"];
                obj.Tenct = (string)dr["tenct"];
                obj.NguoiDaiDien = (string)dr["nguoiDaiDien"];
                obj.DiaChi = (string)dr["diaChi"];
                obj.DienThoai = (string)dr["dienThoai"];
                obj.Email = (string)dr["email"];
                obj.WebsiteUrl = (string)dr["websiteUrl"];
                obj.Fax = (string)dr["fax"];
                obj.GioiThieu = (string)dr["gioiThieu"];               
            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();
            return obj;
        }

        public DataTable TimKiem(string tenct)
        {
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Select * From CongTy Where tenct like '%"  + tenct + "%'";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            //cmd.Parameters.Add("@tenct", SqlDbType.VarChar);
            //cmd.Parameters["@tenct"].Value = "star war";
            //strSQL = "Select * From CongTy";
            //SqlCommand cmd = new SqlCommand(strSQL, cn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("mact");
            dt.Columns.Add("tenct");
            dt.Columns.Add("nguoiDaiDien");
            dt.Columns.Add("diaChi");
            dt.Columns.Add("dienThoai");
            dt.Columns.Add("email");
            dt.Columns.Add("websiteUrl");
            dt.Columns.Add("fax");
            dt.Columns.Add("gioiThieu");
            while (dr.Read())
            {
                DataRow r = dt.NewRow();
                r["mact"] = (int)dr["mact"];
                r["tenct"] = (string)dr["tenct"];
                r["nguoiDaiDien"] = (string)dr["nguoiDaiDien"];
                r["diaChi"] = (string)dr["diaChi"];
                r["dienThoai"] = (string)dr["dienThoai"];
                r["email"] = (string)dr["email"];
                r["websiteUrl"] = (string)dr["websiteUrl"];
                r["fax"] = (string)dr["fax"];
                r["gioiThieu"] = (string)dr["gioiThieu"];
                dt.Rows.Add(r);
            }
            // B5: Dong ket noi CSDL
            dr.Close();
            cn.Close();
            return dt;
        }

        public void Them(CongTy obj)
        {
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Insert into CongTy(tenct,nguoiDaiDien,diaChi,dienThoai,email,websiteUrl,fax,gioiThieu) values(@tenct,@nguoiDaiDien,@diaChi,@dienThoai,@email,@websiteUrl,@fax,@gioiThieu)";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.Add("@tenct", SqlDbType.VarChar).Value = obj.Tenct;
            cmd.Parameters.Add("@nguoiDaiDien", SqlDbType.VarChar).Value = obj.NguoiDaiDien;
            cmd.Parameters.Add("@diaChi", SqlDbType.VarChar).Value = obj.DiaChi;
            cmd.Parameters.Add("@dienThoai", SqlDbType.VarChar).Value = obj.DienThoai;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
            cmd.Parameters.Add("@websiteUrl", SqlDbType.VarChar).Value = obj.WebsiteUrl;
            cmd.Parameters.Add("@fax", SqlDbType.VarChar).Value = obj.Fax;
            cmd.Parameters.Add("@gioiThieu", SqlDbType.VarChar).Value = obj.GioiThieu;

            cmd.ExecuteNonQuery();
            // B5: Dong ket noi CSDL
            cn.Close();
        }

        public void Xoa(int mact)
        {
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            SqlConnection cn;
            cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Delete From CongTy Where mact = @mact";
            SqlCommand cmd = new SqlCommand(strSQL, cn);
            cmd.Parameters.Add("@mact", SqlDbType.Int);
            cmd.Parameters["@mact"].Value = mact;
            cmd.ExecuteNonQuery();
            // B5: Dong ket noi CSDL
            cn.Close();
        }

        public void Sua(CongTy obj)
        {
            // B1 & B2: Tao chuoi ket noi, mo ket noi bang doi tuong ket noi
            SqlConnection cn = DataProvider.ConnectionData();
            // B3: Tao chuoi strSQL thao tac CSDL
            string strSQL;
            strSQL = "Update CongTy Set tenct = @tenct,nguoiDaiDien = @nguoiDaiDien,diaChi = @diaChi,dienThoai = @dienThoai,fax = @fax,email = @email,gioiThieu = @gioiThieu Where mact = @mact";
            SqlCommand cmd = new SqlCommand(strSQL, cn);

            cmd.Parameters.Add("@tenct", SqlDbType.VarChar).Value = obj.Tenct;
            cmd.Parameters.Add("@nguoiDaiDien", SqlDbType.VarChar).Value = obj.NguoiDaiDien;
            cmd.Parameters.Add("@diaChi", SqlDbType.VarChar).Value = obj.DiaChi;
            cmd.Parameters.Add("@dienThoai", SqlDbType.VarChar).Value = obj.DienThoai;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = obj.Email;
            cmd.Parameters.Add("@fax", SqlDbType.VarChar).Value = obj.Fax;
            cmd.Parameters.Add("@gioiThieu", SqlDbType.VarChar).Value = obj.GioiThieu;
            cmd.Parameters.Add("@mact", SqlDbType.Int).Value = obj.Mact;

            cmd.ExecuteNonQuery();

            // B5: Dong ket noi CSDL
            cn.Close();
        }
    }
}
