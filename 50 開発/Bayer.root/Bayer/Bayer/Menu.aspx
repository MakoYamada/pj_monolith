<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="Menu.aspx.vb" Inherits="Bayer.Menu1" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="2" cellspacing="0" style="width: 100%;">
		<tr valign="top">
			<td align="center">
				<table border="0" cellpadding="2" cellspacing="0">
					<tr valign="top">
						<td align="center">
							&nbsp;</td>
						<td style="width: 10px;"></td>
						<td align="center">
							&nbsp;</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<table border="0" cellpadding="2" cellspacing="0" class="style1">
		<tr>
			<td align="center">
				<table cellpadding="3" cellspacing="2" border="0">
					<tr valign="middle">
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="3">
                            ■新着情報一覧
                        </td>
					</tr>					
					<tr valign="top">
						<td align="center" style="width: 210px;" colspan="3">
							<asp:Button ID="BtnKouenkaiList" runat="server" Text="講演会基本情報" Width="200px" 
                                CssClass="Button" />
							<div class="FontSize1" style="height: 10px; display: none;"></div>
						</td>
						<td align="center" style="width: 5px;">
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnKaijoList" runat="server" Text="会場手配" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">						
							<asp:Button ID="BtnKotsuList" runat="server" Text="宿泊・交通" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnBentoList" runat="server" Text="お弁当" Width="200px" CssClass="Button" />
						</td>
					</tr>
					<tr>
					    <td></td>
					</tr>
					<tr valign="middle">
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="3">
                            ■登録済　講演会検索・回答登録
                        </td>
					</tr>					
					<tr valign="top">
						<td align="center" style="width: 210px;" colspan="3">
							<asp:Button ID="BtnKouenkai" runat="server" Text="講演会情報" Width="200px" 
                                CssClass="Button" />
							<div class="FontSize1" style="height: 10px; display: none;"></div>
						</td>
					</tr>
					<tr>
					    <td></td>
					</tr>
					<tr valign="middle">
                        <td align="left" valign="middle" class="TdTitleHeader" colspan="3">
                            ■マスタメンテナンス
                        </td>
					</tr>					
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnJigyosho" runat="server" Text="事業部マスタ" Width="200px" 
                                CssClass="Button" />
							<div class="FontSize1" style="height: 10px; display: none;"></div>
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnArea" runat="server" Text="エリアマスタ" Width="200px" 
                                CssClass="Button" />
							<div class="FontSize1" style="height: 10px; display: none;"></div>
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnEigyosho" runat="server" Text="営業所マスタ" Width="200px" 
                                CssClass="Button" />
							<div class="FontSize1" style="height: 10px; display: none;"></div>
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnShisetsu" runat="server" Text="施設マスタ" Width="200px" 
                                CssClass="Button" />
							<div class="FontSize1" style="height: 10px; display: none;"></div>
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnUser" runat="server" Text="ユーザマスタ" Width="200px" 
                                CssClass="Button" />
							<div class="FontSize1" style="height: 10px; display: none;"></div>
						</td>
						<td align="center" style="width: 210px;">
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">

		<style type="text/css">
            .style1
            {
                width: 100%;
            }
        </style>

</asp:Content>

