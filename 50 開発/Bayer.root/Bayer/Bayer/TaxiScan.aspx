<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiScan.aspx.vb" Inherits="Bayer.TaxiScan" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				ファイルを選択してください：
			</td>
			<td align="left">
				<asp:FileUpload ID="FileUpload1" runat="server" Width="500px" />
			</td>
		</tr>
		<tr style="height: 40px;">
			<td align="right" colspan="2">
				<asp:Button ID="BtnUpload" runat="server" Text="スキャンデータ取込" Width="180px" CssClass="Button" />
			</td>
		</tr>
		<tr id="TrError" runat="server">
			<td align="left" colspan="2" style="font-weight: bold; color: #cb1a1a;">
				エラーがありました。
				<br />
				&nbsp;&nbsp;
				<asp:TextBox ID="ErrorMessage" runat="server" Width="500px" Height="200px" TextMode="MultiLine" ForeColor="#732929"></asp:TextBox>
			</td>
		</tr>
		<tr id="TrEnd" runat="server">
			<td align="left" colspan="2" style="font-weight: bold; color:#003399;">
				正常に終了しました。
			</td>
		</tr>
	</table>
</asp:Content>
