<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiPrinterCsv.aspx.vb" Inherits="Bayer.TaxiPrinterCsv" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<asp:Button ID="BtnCsv" runat="server" Text="印刷用CSVファイル作成" Width="180px" CssClass="Button" />
			</td>
		</tr>
	</table>
</asp:Content>
