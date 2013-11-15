<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="Preview.aspx.vb" Inherits="Bayer.Preview" %>
<%@ Register TagPrefix="ActiveReportsWeb" Namespace="DataDynamics.ActiveReports.Web"
    Assembly="ActiveReports.Web, Version=6.5.4530.1, Culture=neutral, PublicKeyToken=cc4967777c49a3ff" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
	html, body, form, #ctl00_ContentPlaceHolder1_WebViewer1_fvo, #ctl00_ContentPlaceHolder1_WebViewer1_controlDiv
	{
		width: 100%;
		height: 100%;
		margin: 0;
	}
</style>
<script language="javascript" type="text/javascript">
	window.onload = function() {
		var ch = document.documentElement.clientHeight;
		var ctr = document.getElementById("ctl00_ContentPlaceHolder1_TrWebViewer");
		ctr.style.height = ch - 140 - 30 + "px";
		var cwvfvo = document.getElementById("ctl00_ContentPlaceHolder1_WebViewer1_fvo");
		cwvfvo.style.height = ch - 140 - 30 + "px";
		var cwvdiv = document.getElementById("ctl00_ContentPlaceHolder1_WebViewer1_controlDiv");
		cwvdiv.style.height = ch - 14- 30 + "px";
	}
</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="0" cellspacing="0" style="height: 100%; width: 100%">
		<tr valign="top">
			<td align="left">
				<table cellspacing="0" cellpadding="2" border="0" style="width: 100%;" id="TblWebViewer" runat="server">
					<tr style="height: 30px;">
						<td align="left">
							<asp:Button ID="BtnBack" runat="server" Text="‘O‚Ì‰æ–Ê‚É–ß‚é" Width="130px" CssClass="Button" />
						</td>
					</tr>
					<tr valign="top" id="TrWebViewer" runat="server">
						<td align="left">
							<ActiveReportsWeb:WebViewer ID="WebViewer1" runat="server" Width="100%" Height="100%" ViewerType="FlashViewer">
								<FlashViewerOptions MultiPageViewColumns="1" MultiPageViewRows="1"></FlashViewerOptions>
							</ActiveReportsWeb:WebViewer>
							<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>