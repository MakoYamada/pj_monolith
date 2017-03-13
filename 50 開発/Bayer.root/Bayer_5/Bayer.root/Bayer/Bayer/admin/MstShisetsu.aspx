<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="MstShisetsu.aspx.vb" Inherits="Bayer.MstShisetsu" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<table cellpadding="2" cellspacing="0" border="0">
					<tr>
						<td align="left" colspan="2">
							都道府県
							<asp:DropDownList ID="JokenADDRESS1" runat="server" Width="100px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							施設名
							<asp:TextBox ID="JokenSHISETSU_NAME" runat="server" Width="250px" MaxLength="200"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							<asp:CheckBox ID="JokenSTOP_FLG" runat="server" Text="利用停止" />
						</td>
					</tr>
					<tr>
						<td align="left">
							<asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" />
							&nbsp;&nbsp;
							<asp:Button ID="BtnAllData" runat="server" Text="全データ" Width="130px" CssClass="Button" />
						</td>
						<td align="right">
							&nbsp;&nbsp;
							<asp:Button ID="BtnRegist" runat="server" Text="新規施設登録" Width="150px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<hr style="width: 100%;" />
	<div ID="DivMessage" runat="server" style="margin-bottom: 10px;">
		<asp:Label ID="LabelMessage" runat="server" Font-Bold="true">
			施設情報を登録しました。 <br />
			<br />
			施設名＝◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎<br />
			住所＝〒888-888&nbsp;◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎◎
		</asp:Label>
	</div>
	<table cellspacing="0" cellpadding="2" border="0" id="TblRegist" runat="server" style="margin: 5px 5px 5px 2px; border: #999999 1px solid;">
		<tr>
			<td align="left" style="padding: 3px;">
				<table border="0" cellpadding="2" cellspacing="2">
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							施設名
							&nbsp;
						</td>
						<td align="left" class="TdItem" colspan="4">
							<asp:TextBox ID="SHISETSU_NAME" runat="server" Width="500px" MaxLength="200"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							施設名(カナ)
							&nbsp;
						</td>
						<td align="left" class="TdItem" colspan="4">
							<asp:TextBox ID="SHISETSU_KANA" runat="server" Width="500px" MaxLength="200"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							郵便番号
							&nbsp;
						</td>
						<td align="left" class="TdItem" colspan="4">
							<asp:TextBox ID="ZIP" runat="server" Width="100px" MaxLength="7"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							都道府県・住所
							&nbsp;
						</td>
						<td align="left" class="TdItem" colspan="4">
							<asp:DropDownList ID="ADDRESS1" runat="server" Width="100px"></asp:DropDownList>
							<asp:TextBox ID="ADDRESS2" runat="server" Width="400px" MaxLength="200"></asp:TextBox>
							&nbsp;
							&nbsp;
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							電話番号
							&nbsp;
						</td>
						<td align="left" class="TdItem" colspan="4">
							<asp:TextBox ID="TEL" runat="server" Width="160px" MaxLength="15"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							チェックイン時間
							&nbsp;
						</td>
						<td align="left" class="TdItem">
							<asp:TextBox ID="CHECKIN_TIME_1" runat="server" Width="30px" MaxLength="2"></asp:TextBox>
							：
							<asp:TextBox ID="CHECKIN_TIME_2" runat="server" Width="30px" MaxLength="2"></asp:TextBox>
						</td>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							チェックアウト時間
							&nbsp;
						</td>
						<td align="left" class="TdItem">
							<asp:TextBox ID="CHECKOUT_TIME_1" runat="server" Width="30px" MaxLength="2"></asp:TextBox>
							：
							<asp:TextBox ID="CHECKOUT_TIME_2" runat="server" Width="30px" MaxLength="2"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
						</td>
						<td align="left">&nbsp;</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							ホームページURL
							&nbsp;
						</td>
						<td align="left" class="TdItem" colspan="4">
							<asp:TextBox ID="SHISETSU_URL" runat="server" Width="500px" MaxLength="100"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							利用停止
							&nbsp;
						</td>
						<td align="left" class="TdItem" colspan="4">
							<asp:CheckBox ID="STOP_FLG" runat="server" Text="利用停止にする"></asp:CheckBox>
						</td>
					</tr>
					<tr>
						<td align="center" colspan="2" style="padding-top: 5px; padding-bottom: 5px;">
							<asp:Button ID="BtnSubmit" runat="server" Text="登録" Width="150px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<asp:HiddenField ID="SYSTEM_ID" runat="server" />
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
				<asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" CellSpacing="0" 
				 AutoGenerateColumns="false" ShowHeader="true" ShowFooter="false" 
				 AllowPaging="false" PageSize="10"
				 DataKeyNames="SYSTEM_ID" DataSourceID="SqlDataSource1">
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
						<asp:ButtonField ButtonType="Button" Text="変更" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Regist" ControlStyle-CssClass="ButtonList" ControlStyle-Width="44px" ItemStyle-Width="56px" ItemStyle-BackColor="#e4e9d1" />
						<asp:BoundField DataField="SHISETSU_NAME" HeaderText="施設名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="ADDRESS1" HeaderText="都道府県" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="ADDRESS2" HeaderText="住所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="STOP_FLG" HeaderText="使用停止" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SYSTEM_ID" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
</asp:Content>
