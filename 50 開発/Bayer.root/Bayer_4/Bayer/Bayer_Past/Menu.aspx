<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="Menu.aspx.vb" Inherits="Bayer_Past.Menu1" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <table border="0" cellpadding="2" cellspacing="0" class="style1" style="margin-top: 10px;">
		<tr>
			<td align="center">
				<table cellpadding="3" cellspacing="2" border="0">
					<tr valign="middle" id="TrNewTitle" runat="server" visible="false">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■新着情報一覧
						</td>
					</tr>
					<tr valign="top" id="TrNew" runat="server" visible="false">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewKoenkaiList" runat="server" Text="【新着】基本情報" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewKaijoList" runat="server" Text="【新着】会場手配" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewKotsuList" runat="server" Text="【新着】交通・手配" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;" id="TdBentou" runat="server" visible="false">
							<asp:Button ID="BtnNewBentoList" runat="server" Text="お弁当" Width="200px" CssClass="Button" />
						</td>
					</tr>
					<tr valign="top" id="TrNewCsv" runat="server" visible="false">
						<td align="center" style="width: 210px;">
						</td>
						<td align="center" style="width: 210px;">
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnNewKotsuCsv" runat="server" Text="【新着】交通・手配CSV出力" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
						</td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■登録済　会合検索・回答登録
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnKoenkaiList" runat="server" Text="【検索】基本情報" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnKaijoList" runat="server" Text="【検索】会場手配" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnKotsuList" runat="server" Text="【検索】交通・手配" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnBentoList" runat="server" Text="お弁当" Width="200px" CssClass="Button" visible="false"/>
						</td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle" id="TrMstMenteTitle" runat="server" visible="false" >
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■マスタメンテナンス
						</td>
					</tr>
					<tr valign="top" id="TrMstMente" runat="server" visible="false" >
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnMstShisetsu" runat="server" Text="施設マスタ" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnMstUser" runat="server" Text="TOP担当者マスタ" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnMstCode" runat="server" Text="【ステータス】コードマスタ" Width="200px" 
                                CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
						    <asp:Button ID="BtnMstCostcenter" runat="server" Text="コストセンターマスタ" Width="200px" CssClass="Button" Visible="false" />
						</td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle" id="TrLogTitle" runat="server" visible="false" >
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■ログ照会
						</td>
					</tr>
					<tr valign="top" id="TrLog" runat="server" visible="false" >
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnLogFile" runat="server" Text="送受信ログ照会" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnLogSousa" runat="server" Text="操作ログ照会" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnLogManuImport" runat="server" Text="手動取込ログ照会" Width="200px" CssClass="Button" />
						</td>
						<td></td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■精算関連業務
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnSeisan" runat="server" Text="精算処理" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnSap" runat="server" Text="WPAデータ作成" Width="200px" 
                                CssClass="Button" Visible="False" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnToptour" runat="server" Text="WPAデータ作成(TOPTOUR用)" 
                                Width="200px" CssClass="Button" Visible="False" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnCost" runat="server" Text="コストセンター別費用入力" Width="200px" CssClass="Button" Visible="false" />
						</td>
					</tr>
					<tr valign="top" runat="server" id="BUNSEKI_TR">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnKaigouHiyouCsv" runat="server" Text="会合費用総合一覧CSV" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnSankashaRyohiCsv" runat="server" Text="参加者旅費一覧CSV" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnMRRyohiCsv" runat="server" Text="社員旅費一覧CSV" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiJissekiCsv" runat="server" Text="タクチケ一覧CSV" 
                                Width="200px" CssClass="Button" />
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
						<td>
							<asp:Button ID="BtnTaxiMenu" runat="server" Text="タクシーチケット管理" Width="200px" CssClass="Button" />
						</td>
					</tr>
					<tr>
						<td colspan="4"></td>
					</tr>
					<tr valign="middle" id="TrDataMenteTitle" runat="server" visible="false" >
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■データメンテナンス
						</td>
					</tr>
					<tr valign="top" id="TrDataMente" runat="server" visible="false" >
						<td>
							<asp:Button ID="BtnKotsuMaintenance" runat="server" Text="交通・宿泊データメンテナンス" Width="200px" 
                                CssClass="Button" />
						</td>
						<td>
							<asp:Button ID="BtnTaxiMaintenance" runat="server" Text="タクチケデータメンテナンス" Width="200px" 
                                CssClass="Button" />
						</td>
						<td>
							<asp:Button ID="BtnSeisanMaintenance" runat="server" Text="精算データメンテナンス" Width="200px" 
                                CssClass="Button" />
						</td>
						<td>
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
