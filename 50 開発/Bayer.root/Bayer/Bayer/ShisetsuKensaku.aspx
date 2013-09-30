<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="ShisetsuKensaku.aspx.vb" Inherits="Bayer.ShisetsuKensaku" %>
<%@ MasterType VirtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table border="0" cellpadding="4" cellspacing="0" style="width: 100%;">
		<tr>
			<td align="left">
				<table cellpadding="2" cellspacing="0" border="0">
					<tr>
						<td align="left">
							都道府県
							<asp:DropDownList ID="ADDRESS1" runat="server" Width="100px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							市区町村
							<asp:TextBox ID="ADDRESS2" runat="server" Width="300px" MaxLength="200"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
						</td>
					</tr>
					<tr>
						<td align="left">
							施設名
							&nbsp;&nbsp;&nbsp;
							<asp:TextBox ID="SHISETSU_NAME" runat="server" Width="300px" MaxLength="200"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							施設名カナ
							<asp:TextBox ID="SHISETSU_NAME_KANA" runat="server" Width="300px" MaxLength="200"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left">
							<asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<hr style="width:100%" />
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<div class="FontSize1" style="height: 4px;"></div>
				<asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
				<asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" CellSpacing="0" 
				 AutoGenerateColumns="false" ShowHeader="true" ShowFooter="false" 
				 AllowPaging="true" PageSize="13"
				 DataKeyNames="SYSTEM_ID" DataSourceID="SqlDataSource1">
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
						<asp:ButtonField ButtonType="Button" HeaderText="選択" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="OK" ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" ItemStyle-Width="56px" />
						<asp:BoundField DataField="ADDRESS1" HeaderText="都道府県" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SHISETSU_NAME" HeaderText="施設名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="ADDRESS2" HeaderText="住所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TEL" HeaderText="電話番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SYSTEM_ID" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
		<tr>
			<td align="left" style="padding-top: 15px; padding-bottom: 10px;">
				<input type="button" value="戻る" style="width: 130px;" class="Button" onclick="window.close()" />
			</td>
		</tr>
	</table>
</asp:Content>
