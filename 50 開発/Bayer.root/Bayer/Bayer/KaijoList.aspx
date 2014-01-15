<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KaijoList.aspx.vb" Inherits="Bayer.KaijoList" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	W<table cellspacing="0" cellpadding="2" border="0">
		<tr>
			<td align="left">
				<table cellpadding="2" cellspacing="0" border="0">
					<tr>
						<td align="left" colspan="2">
							BYL企画担当者
							<asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="170px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							BYL手配担当者
							<asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="170px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							製品名
							<asp:DropDownList ID="JokenSEIHIN" runat="server" Width="240px"></asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td align="left" colspan="2">
							講演会番号
							<asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="140px" MaxLength="14"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							講演会名
							<asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="350px" MaxLength="200"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" colspan="2">
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
							<asp:DropDownList ID="JokenBU" runat="server" Width="120px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							エリア
							<asp:DropDownList ID="JokenKIKAKU_TANTO_AREA" runat="server" Width="200px"></asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td align="left">
							TOP担当者
							<asp:DropDownList ID="JoKenTTANTO_ID" runat="server" Width="200px"></asp:DropDownList>
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
				<table cellspacing="0" cellpadding="2" border="0" id="TblButton1" runat="server">
					<tr align="center" style="height: 40px;">
						<td>
							<asp:Button ID="BtnKaijoListPrint1" runat="server" Text="手配依頼一覧印刷" Width="130px" CssClass="Button" />
							&nbsp;
							<asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" CssClass="Button" />
						</td>
					</tr>
				</table>
				<asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" CellSpacing="0" 
				 AutoGenerateColumns="false" ShowHeader="true" ShowFooter="false" 
				 AllowPaging="true" PageSize="40"
				 DataKeyNames="KOUENKAI_NO" DataSourceID="SqlDataSource1">
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<PagerSettings Mode="NumericFirstLast" Position="TopAndBottom" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
						<asp:BoundField DataField="BU" HeaderText="BU" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="エリア" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="営業所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="FROM_DATE" HeaderText="実施日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KOUENKAI_NAME" HeaderText="講演会名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="Timestamp" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SEND_FLAG" HeaderText="NOZOMI<br />送信" HtmlEncode="false" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" />
						<asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:ButtonField ButtonType="Button" HeaderText="" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Regist" ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" ItemStyle-Width="56px" ItemStyle-BackColor="#e4e9d1" />
						<asp:BoundField DataField="SALEFORCE_ID" />
						<asp:BoundField DataField="TEHAI_ID" />
						<asp:BoundField DataField="KOUENKAI_NO" />
						<asp:BoundField DataField="TO_DATE" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
	<table cellspacing="0" cellpadding="2" border="0">
		<tr align="center" style="height: 40px;">
			<td>
				<span id="SpnBtnKaijoListPrint2" runat="server">
				<asp:Button ID="BtnKaijoListPrint2" runat="server" Text="手配依頼一覧印刷" Width="130px" CssClass="Button" />
				&nbsp;</span>
				<asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" CssClass="Button" />
			</td>
		</tr>
	</table>
</asp:Content>
