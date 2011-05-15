<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ThemCongTy.aspx.cs" Inherits="MuaRe.Congty.ThemCongTy" EnableViewState="True" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
		<asp:ValidationSummary ID="ValidationSummary1"
		ShowMessageBox="true"
		ShowSummary="false"
		HeaderText="Vui lòng nhập đầy đủ các giá trị sau:"
		EnableClientScript="true"
		runat="server"/>
		<table width="100%" border="0" cellpadding="0" cellspacing="1" class="list">
			<tr >
				<td colspan="2" class="list_heading">Thông tin công ty</td>
			</tr>
			<tr>
				<td class="list_detail"><asp:Label ID="Label4" runat="server" Text="Tên công ty (*)"></asp:Label></td>
				<td class="list_detail"><asp:TextBox ID="tenctTxt" Width="300px" runat="server" 
                        ViewStateMode="Enabled"></asp:TextBox>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1"
						 ControlToValidate="tenctTxt"
						 ErrorMessage="Tên công ty"
						 Text = "*"
						 runat="server"/>
			   </td>                   
			</tr>
			<tr>
				<td class="list_detail"><asp:Label ID="Label5" runat="server" Text="Người đại diện (*)"></asp:Label></td>
				<td class="list_detail"><asp:TextBox ID="nguoiDaiDienTxt" Width="300px" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator2"
						 ControlToValidate="nguoiDaiDienTxt"
						 ErrorMessage="Người đại diện"
						 Text = "*"
						 runat="server"/>
				</td>
			</tr>
			<tr>
				<td class="list_detail"><asp:Label ID="Label2" runat="server" Text="Địa chỉ (*)"></asp:Label></td>
				<td class="list_detail"><asp:TextBox ID="diaChiTxt" Width="300px" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator3"
						 ControlToValidate="diaChiTxt"
						 ErrorMessage="Địa chỉ"
						 Text = "*"
						 runat="server"/>
				</td>
			</tr>
			<tr>
				<td class="list_detail"><asp:Label ID="Label1" runat="server" Text="Website Url"></asp:Label></td>
				<td class="list_detail"><asp:TextBox ID="websiteUrlTxt" Width="300px" runat="server"></asp:TextBox></td>
			</tr>
			<tr>
				<td class="list_detail"><asp:Label ID="Label3" runat="server" Text="Email (*)"></asp:Label></td>
				<td class="list_detail"><asp:TextBox ID="emailTxt" Width="300px" runat="server"></asp:TextBox>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator5"
						 ControlToValidate="emailTxt"
						 ErrorMessage="Email"
						 Text = "*"
						 runat="server"/>
				</td>
			</tr>
			<tr>
				<td class="list_detail"><asp:Label ID="Label7" runat="server" Text="Điện thoại"></asp:Label></td>
				<td class="list_detail"><asp:TextBox ID="dienThoaiTxt" runat="server"></asp:TextBox></td>

			</tr>
			<tr>
				<td class="list_detail"><asp:Label ID="Label6" runat="server" Text="Fax"></asp:Label></td>
				<td class="list_detail"><asp:TextBox ID="faxTxt" runat="server"></asp:TextBox></td>
			</tr>
			<tr>
				<td colspan="2" class="list_detail"><asp:Label ID="Label8" runat="server" Text="Giới thiệu (*)"></asp:Label></td>				
			</tr>
			<tr>				
				<td colspan="2" class="list_detail">
					<CKEditor:CKEditorControl ID="gioiThieuTxt" runat="server"></CKEditor:CKEditorControl>
					<asp:RequiredFieldValidator ID="RequiredFieldValidator6"
						 ControlToValidate="gioiThieuTxt"
						 ErrorMessage="Giới Thiệu"
						 Text = "Nhập nội dung giới thiệu về công ty"
						 runat="server"/>
				</td>
			</tr>
			<tr>
				<td colspan="2" class="list_detail">
					<asp:Button ID="luuBtn" runat="server" 
							Text="Lưu" onclick="luuBtn_Click" Visible="False" />
							<asp:Button ID="capnhatBtn" runat="server" 
							Text="Cập nhật" onclick="capnhatBtn_Click" Visible="False" />
				</td>                
			</tr>
		</table>
</div>
	<div>
	</div>
		
</asp:Content>
