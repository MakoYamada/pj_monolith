<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="LogSousa.aspx.vb" Inherits="Bayer.LogSousa" %>
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
							ログインID
							<asp:TextBox ID="JokenINPUT_USER" runat="server" Width="150px" MaxLength="10"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							画面名
							<asp:DropDownList ID="JokenSYORI_NAME" runat="server" Width="300px"></asp:DropDownList>
						</td>
					</tr>
					<tr>
						<td align="left">
							処理日
							<asp:TextBox ID="JokenINPUT_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="JokenINPUT_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="JokenINPUT_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							&nbsp;&nbsp;&nbsp;
							処理結果
							<asp:DropDownList ID="JokenSTATUS" runat="server" Width="100px"></asp:DropDownList>
						</td>
						<td align="right">
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
				 AllowPaging="true" PageSize="15"
				 DataKeyNames="INPUT_DATE,INPUT_USER,SYORI_NAME" DataSourceID="SqlDataSource1">
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
						<asp:BoundField DataField="INPUT_DATE" HeaderText="操作日時" ItemStyle-HorizontalAlign="Center" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="INPUT_USER" HeaderText="ログイン者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SYORI_NAME" HeaderText="画面名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:TemplateField HeaderText="処理結果" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
							<ItemTemplate>
								<asp:Label ID="STATUS" runat="server"></asp:Label>
								<div id="DivNOTE" runat="server">
									<asp:Label ID="NOTE" runat="server"></asp:Label>
								</div>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:BoundField DataField="USER_NAME" />
						<asp:BoundField DataField="STATUS" />
						<asp:BoundField DataField="NOTE" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
</asp:Content>
