<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="NewKaijoList.aspx.vb" Inherits="Bayer_Past.NewKaijoList" %>
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
							BU
							<asp:DropDownList ID="JokenBU" runat="server" Width="120px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							エリア
							<asp:DropDownList ID="JokenKIKAKU_TANTO_AREA" runat="server" Width="200px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							区分							<asp:DropDownList ID="JokenREQ_STATUS_TEHAI" runat="server" Width="140px"></asp:DropDownList>
						</td>
						<td align="right">
							&nbsp;&nbsp;&nbsp;
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
					<tr style="height: 40px;">
						<td align="left">
							<asp:Button ID="BtnKaijoPrint1" runat="server" Text="手配書印刷" Width="130px" CssClass="Button" />
							&nbsp;
							<asp:Button ID="BtnNewKaijoListPrint1" runat="server" Text="手配依頼一覧印刷" Width="130px" CssClass="Button" />
							&nbsp;
							<asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" CssClass="Button" />
						</td>
					</tr>
				</table>
				<span id="SpnCheckPrint" runat="server">
					手配書印刷：
					<asp:LinkButton ID="LnkCheckALL" runat="server" CssClass="link">全てにチェック</asp:LinkButton>
					&nbsp;
					<asp:LinkButton ID="LnkCheckClear" runat="server" CssClass="link">全てのチェックを解除</asp:LinkButton>
				</span>
                <div class="FontSize1" style="height:2px;"></div>
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
						<asp:TemplateField HeaderText="手配書<br />印刷" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="75px">
							<ItemTemplate>
								<asp:CheckBox ID="ChkPrint" runat="server" />
							</ItemTemplate>
						</asp:TemplateField>
						<asp:BoundField DataField="BU" HeaderText="&nbsp;BU&nbsp;" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="エリア" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="営業所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KIKAKU_TANTO_NAME" HeaderText="企画担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="FROM_DATE" HeaderText="開催日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KOUENKAI_NO" HeaderText="会合番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KOUENKAI_NAME" HeaderText="会合名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TEHAI_ID" HeaderText="会合手配番号" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TIME_STAMP_BYL" HeaderText="Timestamp" ItemStyle-Wrap="false" ItemStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="REQ_STATUS_TEHAI" HeaderText="区分" ItemStyle-Wrap="false" ItemStyle-HorizontalAlign="Left" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Regist" ControlStyle-CssClass="ButtonList" ControlStyle-Width="44px" ItemStyle-Width="56px" ItemStyle-BackColor="#e4e9d1" />
						<asp:BoundField DataField="SALEFORCE_ID" />
						<asp:BoundField DataField="TO_DATE" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
	<table cellspacing="0" cellpadding="2" border="0">
		<tr style="height: 40px;">
			<td align="left">
				<asp:Button ID="BtnKaijoPrint2" runat="server" Text="手配書印刷" Width="130px" CssClass="Button" />
				&nbsp;
                <asp:Button ID="BtnNewKaijoListPrint2" runat="server" Text="手配依頼一覧印刷" Width="130px" CssClass="Button" />
				&nbsp;
				<asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" CssClass="Button" />
            </td>
        </tr>
    </table>
</asp:Content>
