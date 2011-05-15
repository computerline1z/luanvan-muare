<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DanhSachCongTy.aspx.cs" Inherits="MuaRe.Congty.DanhSachCongTy" EnableEventValidation="False" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
<script language=javascript type="text/javascript">
    function confirm_delete() {
        var del = confirm('Bạn có thật sự muốn xóa công ty này không ?');
        return (del);
    }
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div class="list">  
    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" 
        EnablePageMethods="True">
    </asp:ToolkitScriptManager>
    <div style="padding-bottom:10px">
        <asp:TextBox ID="searchTxt" runat="server"></asp:TextBox>
        <asp:Button ID="searchBtn" runat="server" Text="Search" 
            onclick="searchBtn_Click" />
    </div>
    <asp:AutoCompleteExtender ID="TextBox1_AutoCompleteExtender" runat="server" 
        DelimiterCharacters="" Enabled="True" ServiceMethod="GetCompletionList" 
        ServicePath="" TargetControlID="searchTxt" UseContextKey="True" CompletionInterval="300" MinimumPrefixLength="1">
    </asp:AutoCompleteExtender>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="searchBtn" />
        </Triggers>
        <ContentTemplate>
             <asp:GridView ID="danhSachGrid" runat="server" BackColor="White" 
        BorderColor="White" BorderStyle="Ridge" BorderWidth="0px" CellPadding="3" 
        CellSpacing="1" GridLines="None" Width="100%" AllowPaging="True" 
        AutoGenerateColumns="False" 
        onpageindexchanging="danhSachGrid_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="mact" HeaderText="Mã công ty" Visible="False" />
            <asp:BoundField DataField="tenct" HeaderText="Tên công ty" />
            <asp:BoundField DataField="nguoiDaiDien" HeaderText="Người đại diện" />
            <asp:BoundField DataField="diaChi" HeaderText="Địa chỉ" />
            <asp:BoundField DataField="websiteUrl" HeaderText="Website" />
            <asp:BoundField DataField="dienThoai" HeaderText="Điện Thoại" />
            <asp:BoundField DataField="fax" HeaderText="Fax" />
            <asp:TemplateField HeaderText="Thao tác" ItemStyle-HorizontalAlign="Center">
                <ItemTemplate>
                    <asp:ImageButton ID="suaBtn" runat="server" ImageUrl="~/Hinhanh/edit.png" OnCommand="Sua_ImageBtn" CommandArgument='<%# Bind("mact") %>'/>
                    <asp:ImageButton ID="xoaBtn" runat="server" ImageUrl="~/Hinhanh/delete.png" OnCommand="Xoa_ImageBtn" CommandArgument='<%# Bind("mact") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#3366FF" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Blue" HorizontalAlign="Right" Font-Overline="False" BorderStyle="Solid" />
        <RowStyle BackColor="#F1F1F1" ForeColor="Black" />
        <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#594B9C" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#33276A" />
    </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</div> 
</asp:Content>
