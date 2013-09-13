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
						<td align="left">
							<table cellpadding="2" cellspacing="0" border="0">
								<tr>
									<td>
										事業部
										<asp:DropDownList ID="TEHAI_TANTO_JIGYOBU" runat="server" Width="150px"></asp:DropDownList>
										&nbsp;&nbsp;&nbsp;
										エリア
										<asp:DropDownList ID="TEHAI_TANTO_AREA" runat="server" Width="150px"></asp:DropDownList>
										&nbsp;&nbsp;&nbsp;
										会合名
										<asp:TextBox ID="KOUENKAI_NAME" runat="server" Width="350px" MaxLength="200"></asp:TextBox>
									</td>
								</tr>
								<tr>
									<td>
										担当者
										<asp:TextBox ID="TTANTO_ID" runat="server" Width="100px" MaxLength="10"></asp:TextBox>
									</td>
								</tr>
							</table>
						</td>
						<td align="left" valign="bottom">
							&nbsp;
							<asp:Button ID="BtnSearch" runat="server" Text="検索" Width="130px" CssClass="Button" />
						</td>
					</tr>
				</table>
				<hr style="width:100%" />
			</td>
		</tr>
	</table>
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
						<asp:BoundField DataField="TEHAI_TANTO_JIGYOBU" HeaderText="事業部" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TEHAI_TANTO_AREA" HeaderText="エリア" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TEHAI_TANTO_EIGYOSHO" HeaderText="営業所" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="YOTEI_DATE" HeaderText="実施日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KOUENKAI_NAME" HeaderText="会合名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TIME_STAMP" HeaderText="Timestamp" ItemStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TANTO_NAME" HeaderText="担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:ButtonField ButtonType="Button" Text="詳細" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Detail" ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" ItemStyle-Width="52px" />
						<asp:BoundField DataField="KOUENKAI_NO" />
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
