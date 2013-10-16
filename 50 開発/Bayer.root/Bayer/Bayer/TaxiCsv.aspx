<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiCsv.aspx.vb" Inherits="Bayer.TaxiCsv" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<table cellpadding="2" cellspacing="0" border="0">
					<tr>
						<td align="left">
							企画担当者
							<asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="230px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							手配担当者
							<asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="230px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							製品名
							<asp:TextBox ID="JokenSEIHIN_NAME" runat="server" Width="200px"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left">
							講演会番号
							<asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="140px" MaxLength="14"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							講演会名
							<asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="350px" MaxLength="200"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left">
							実施日
							<asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							～
							<asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							&nbsp;&nbsp;&nbsp;
							BU
							<asp:TextBox ID="JokenBU" runat="server" Width="150px" MaxLength="40"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							エリア
							<asp:TextBox ID="JokenKIKAKU_TANTO_AREA" runat="server" Width="200px" MaxLength="80"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left">
							トップツアー担当者
							<asp:TextBox ID="JokenTTANTO_ID" runat="server" Width="100px" MaxLength="10"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td style="border-bottom: 1px solid #acacac;">
							&nbsp;
						</td>
					</tr>
					<tr style="height: 50px;" valign="bottom">
						<td align="center">
							<asp:Button ID="BtnCsv" runat="server" Text="CSVファイル作成" Width="180px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
