<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="Preview.aspx.vb" Inherits="Bayer.Preview" %>
<%@ Register TagPrefix="ActiveReportsWeb" Namespace="DataDynamics.ActiveReports.Web"
    Assembly="ActiveReports.Web, Version=6.5.4530.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0" style="width: 100%; height: 500px;">
		<tr>
			<td align="left">
				<asp:Button ID="BtnBack" runat="server" Text="‘O‚Ì‰æ–Ê‚É–ß‚é" Width="130px" CssClass="Button" />
			</td>
		</tr>
		<tr>
			<td align="left">
				<ActiveReportsWeb:WebViewer ID="WebViewer1" runat="server" Height="430px" Width="100%" ViewerType="FlashViewer">
					<FlashViewerOptions MultiPageViewColumns="1" MultiPageViewRows="1"></FlashViewerOptions>
				</ActiveReportsWeb:WebViewer>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
</asp:Content>