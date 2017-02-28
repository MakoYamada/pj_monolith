<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiPrintCsv_bk.aspx.vb" Inherits="Bayer.TaxiPrintCsv_bk" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
		<tr id="TrNoData" runat="server">
			<td align="left">
				<asp:Label ID="LabelNoData" runat="server" Text="対象となるデータがありません。" CssClass="NoData"></asp:Label>
			</td>
		</tr>
		<tr>
			<td align="left">
				<asp:Button ID="BtnCsv" runat="server" Text="印刷用CSVファイル作成" Width="180px" CssClass="Button" />
			</td>
		</tr>
	</table>
</asp:Content>
