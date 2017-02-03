<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiJissekiOTH.aspx.vb" Inherits="Bayer_Past.TaxiJissekiOTH" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<table cellpadding="2" cellspacing="0" border="0" width="900px">
					<tr style="width:100%">
						<td align="left" style="width:15%">
						    取込ファイル
						</td>
						<td align="left">
						    <asp:FileUpload ID="FileUpload1" runat="server" />
						</td>
					</tr>					
					<tr style="height: 50px;" valign="bottom">
						<td align="left" colspan="2">
							<asp:Button ID="BtnTorikomi" runat="server" Text="取込開始" Width="180px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<table cellspacing="0" cellpadding="2" border="0">
		<tr id="TrError" runat="server">
			<td align="left" colspan="2" style="font-weight: bold; color: #cb1a1a;">
				エラーがありました。<br />
				詳細は操作ログ照会でご確認ください。

				<br />
				&nbsp;&nbsp;
				<asp:TextBox ID="LabelErrorMessage" runat="server" Width="900px" Height="350px" TextMode="MultiLine" ForeColor="#cb1a1a" TabIndex="-1" ReadOnly="true"></asp:TextBox>
			</td>
		</tr>
		<tr id="TrEnd" runat="server">
			<td align="left" colspan="2" style="font-weight: bold; color:#003399;">
				正常に終了しました。

				<br />
				処理件数：

				<asp:Label ID="LabelUpdatedCount" runat="server"></asp:Label>件
			</td>
		</tr>
	</table>
</asp:Content>
