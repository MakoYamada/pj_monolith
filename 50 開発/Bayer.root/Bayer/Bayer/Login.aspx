<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="Base.Master" CodeBehind="Login.aspx.vb" Inherits="Bayer.Login" %>
<%@ MasterType virtualPath="Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="0" cellspacing="0" style="width: 100%;">
		<tr>
			<td align="center">
				<br />
				<table cellpadding="3" cellspacing="0" style="border-collapse: collapse;" border="1" bordercolor="#4f5b61">
					<tr>
						<td style="width: 110px;" align="right" class="TdTitle">
							ログインID
							&nbsp;
						</td>
						<td style="width: 160px;" align="center" class="TdItem">
							<asp:TextBox ID="LOGIN_ID" runat="server" Width="150px" MaxLength="10"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="right" class="TdTitle">
							パスワード							&nbsp;
						</td>
						<td align="center" class="TdItem">
							<asp:TextBox ID="PASSWORD" runat="server" Width="150px" MaxLength="10" TextMode="Password"></asp:TextBox>
						</td>
					</tr>
				</table>
				<div class="FontSize1" style="height: 15px;"></div>
				<asp:Button ID="BtnLogin" runat="server" Width="150px" Text="ログイン" CssClass="Button" />
				<div class="FontSize1" style="height: 5px;"></div>
			</td>
		</tr>
	</table>
</asp:Content>
