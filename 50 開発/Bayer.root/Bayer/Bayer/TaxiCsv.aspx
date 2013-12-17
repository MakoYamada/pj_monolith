<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiCsv.aspx.vb" Inherits="Bayer.TaxiCsv" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<asp:Button ID="BtnCsv" runat="server" Text="CSVファイル作成" Width="180px" CssClass="Button" />
			</td>
		</tr>
	</table>
</asp:Content>
