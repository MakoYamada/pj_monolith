<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiMenu.aspx.vb" Inherits="Bayer.TaxiMenu" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="0" cellpadding="2" cellspacing="0" class="style1" style="margin-top: 10px;">
		<tr>
			<td align="center">
				<table cellpadding="3" cellspacing="2" border="0">
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■タクシーチケット管理
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiNouhinTorikomi" runat="server" Text="タクチケ納品データ取込" 
                                Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiPrintCsv" runat="server" Text="タクチケ印刷データ作成" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiScan" runat="server" Text="タクチケスキャンデータ取込" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiMaintenance" runat="server" Text="タクチケメンテナンス" 
                                Width="200px" CssClass="Button" />
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiJisseki" runat="server" Text="タクチケ実績データ取込" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiMiseisan" runat="server" Text="精算未完了リスト" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiMiketsu" runat="server" Text="タクチケ未決処理" Width="200px" 
                                CssClass="Button" />
						</td>
						<td>
							<asp:Button ID="BtnTaxiMiseisanCsv" runat="server" Text="タクチケ実績未精算CSV" Width="200px" 
                                CssClass="Button" />
						</td>
					</tr>
					<tr valign="top" visible="true">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiJissekiOTH" runat="server" Text="その他タクチケ実績データ取込" 
                                Width="200px" CssClass="Button" Visible="true" />
						</td>
						<td></td>
						<td></td>
						<td></td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiMeisaiCsv" runat="server" Text="タクチケ管理台帳" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiSoufujoIkkatsu" runat="server" Text="送付状・確認票一括印刷" 
                                Width="200px" CssClass="Button" />
						</td>
						<td></td>
						<td></td>
					</tr>
					<tr>
					    <td colspan="4"></td>
					</tr>
					<tr valign="middle">
						<td align="left" valign="middle" class="TdTitleHeader" colspan="4">
							■タクシーチケット自動精算
						</td>
					</tr>
					<tr valign="top">
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiSeisanImport" runat="server" Text="タクチケ精算用CSV取込" Width="200px" CssClass="Button" />
						</td>
						<td align="center" style="width: 210px;">
							<asp:Button ID="BtnTaxiSeisanAuto" runat="server" Text="タクチケ自動精算指示" Width="200px" CssClass="Button" />
						</td>
						<td>
							<asp:Button ID="BtnTaxiSeisanAutoCsv" runat="server" Text="自動精算済タクチケCSV DL" Width="200px" CssClass="Button" />
						</td>
						<td>
							<asp:Button ID="BtnSeisanshoAuto" runat="server" Text="総合精算書PDF DL" Width="200px" CssClass="Button" />
						</td>
					</tr>
					<tr>
					    <td>
							<asp:Button ID="BtnTaxiSeisanToNozomi" runat="server" Text="Nozomi送信対象精算データ取込" Width="200px" CssClass="Button" />
					    </td>
					    <td>
					    </td>
					    <td>
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
