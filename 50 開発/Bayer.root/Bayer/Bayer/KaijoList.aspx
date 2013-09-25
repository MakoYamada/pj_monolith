<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KaijoList.aspx.vb" Inherits="Bayer.KaijoList" %>
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
							企画担当者
							<asp:TextBox ID="KIKAKU_TANTO_ROMA" runat="server" Width="230px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							手配担当者
							<asp:TextBox ID="TEHAI_TANTO_ROMA" runat="server" Width="230px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							製品名
							<asp:TextBox ID="SEIHIN_NAME" runat="server" Width="200px"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" colspan="2">
							講演会番号
							<asp:TextBox ID="KOUENKAI_NO" runat="server" Width="100px" MaxLength="10"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							講演会名
							<asp:TextBox ID="KOUENKAI_NAME" runat="server" Width="350px" MaxLength="200"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" colspan="2">
							実施日
							<asp:TextBox ID="FROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="FROM_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="FROM_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							～
							<asp:TextBox ID="TO_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="TO_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="TO_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							&nbsp;&nbsp;&nbsp;
							BU
							<asp:DropDownList ID="KIKAKU_TANTO_BU" runat="server" Width="150px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							エリア
							<asp:DropDownList ID="KIKAKU_TANTO_AREA" runat="server" Width="150px"></asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td align="left">
							トップツアー担当者
							<asp:TextBox ID="TTANTO_ID" runat="server" Width="100px" MaxLength="10"></asp:TextBox>
						</td>
						<td align="right">
							<asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<hr style="width: 100%;" />
	<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<div class="FontSize1" style="height: 4px;"></div>
				<asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
				<asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" CellSpacing="0" 
				 AutoGenerateColumns="false" ShowHeader="true" ShowFooter="false" 
				 AllowPaging="true" PageSize="13"
				 DataKeyNames="KOUENKAI_NO" DataSourceID="SqlDataSource1">
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
						<asp:BoundField DataField="KIKAKU_TANTO_BU" HeaderText="BU" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="エリア" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="営業所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="FROM_DATE" HeaderText="実施日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KOUENKAI_NAME" HeaderText="講演会名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="USER_NAME" HeaderText="担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:ButtonField ButtonType="Button" HeaderText="会場手配" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Kaijo" ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" ItemStyle-Width="68px" />
						<asp:ButtonField ButtonType="Button" HeaderText="参加者" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="HotelKotsu" ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" ItemStyle-Width="56px" />
						<asp:BoundField DataField="KOUENKAI_NO" />
						<asp:BoundField DataField="TO_DATE" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
	<table cellspacing="0" cellpadding="2" border="0">
        <tr align="center">
            <td>
                <asp:Button ID="BtnBack" runat="server" Text="戻る" Width="130px" CssClass="Button" />
            </td>
        </tr>
    </table>
</asp:Content>
