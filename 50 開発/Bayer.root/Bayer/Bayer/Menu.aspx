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
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■新着情報一覧
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewKoenkaiList" runat="server" Text="講演会基本情報" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewKaijoList" runat="server" Text="会場手配" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewKotsuList" runat="server" Text="宿泊・交通" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewBentoList" runat="server" Text="お弁当" Width="200px" CssClass="Button" />
						</td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■登録済　講演会検索・回答登録
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnKoenkaiList" runat="server" Text="講演会基本情報" Width="200px" CssClass="Button" />
						</td>
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
						<td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■マスタメンテナンス
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnMstShisetsu" runat="server" Text="施設マスタ" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnMstUser" runat="server" Text="ユーザマスタ" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnMstCode" runat="server" Text="コードマスタ" Width="200px" CssClass="Button" />
						</td>
						<td></td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■ログ照会
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnLogFile" runat="server" Text="送受信ログ照会" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnLogSousa" runat="server" Text="操作ログ照会" Width="200px" CssClass="Button" />
						</td>
						<td></td>
						<td></td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■精算処理
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnSeisan" runat="server" Text="精算金額入力" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnSap" runat="server" Text="SAPデータ作成" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnKouenkaiCsv" runat="server" Text="講演会・コストセンター別集計" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnSankashaCsv" runat="server" Text="参加者一覧" Width="200px" CssClass="Button" />
						</td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■タクシーチケット管理
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiCsv" runat="server" Text="CSVファイル作成" Width="200px" CssClass="Button" />
						</td>
						<td></td>
						<td></td>
						<td></td>
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
