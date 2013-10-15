<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="LogFile.aspx.vb" Inherits="Bayer.LogFile" %>
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
							送信／受信
							<asp:DropDownList ID="JokenEXPORTIMPORT" runat="server" Width="80px">
								<asp:ListItem Value="0" Text="---"></asp:ListItem>
								<asp:ListItem Value="E" Text="送信"></asp:ListItem>
								<asp:ListItem Value="I" Text="受信"></asp:ListItem>
							</asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							処理名
							<asp:DropDownList ID="JokenSYORI_NAME" runat="server" Width="250px">
								<asp:ListItem Value="0" Text="---"></asp:ListItem>
								<asp:ListItem Value="講演会基本情報ファイル取込" Text="講演会基本情報ファイル取込"></asp:ListItem>
								<asp:ListItem Value="会場手配ファイル取込" Text="会場手配ファイル取込"></asp:ListItem>
								<asp:ListItem Value="会場手配回答ファイル作成" Text="会場手配回答ファイル作成"></asp:ListItem>
								<asp:ListItem Value="交通宿泊手配依頼ファイル取込" Text="交通宿泊手配依頼ファイル取込"></asp:ListItem>
								<asp:ListItem Value="交通宿泊手配回答ファイル作成" Text="交通宿泊手配回答ファイル作成"></asp:ListItem>
								<asp:ListItem Value="参加者出席ファイル取込" Text="参加者出席ファイル取込"></asp:ListItem>
								<asp:ListItem Value="精算ファイル作成" Text="精算ファイル作成"></asp:ListItem>
								<asp:ListItem Value="タクシーチケット" Text="タクシーチケット"></asp:ListItem>
							</asp:DropDownList>
							<div class="FontSize1" style="height: 4px;"></div>
							処理日
							<asp:TextBox ID="JokenINPUT_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="JokenINPUT_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="JokenINPUT_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							&nbsp;&nbsp;&nbsp;
							処理結果
							<asp:DropDownList ID="JokenSTATUS" runat="server" Width="100px">
								<asp:ListItem Value=" " Text="---"></asp:ListItem>
								<asp:ListItem Value="0" Text="正常"></asp:ListItem>
								<asp:ListItem Value="1" Text="エラー"></asp:ListItem>
							</asp:DropDownList>
						</td>
						<td align="right" valign="bottom">
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
						<asp:TemplateField HeaderText="送受信" ItemStyle-HorizontalAlign="Center" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
							<ItemTemplate>
								<asp:Label ID="EXPORTIMPORT" runat="server"></asp:Label>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:BoundField DataField="INPUT_DATE" HeaderText="送受信日時" ItemStyle-HorizontalAlign="Center" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SYORI_NAME" HeaderText="処理名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:TemplateField HeaderText="処理結果" ItemStyle-Wrap="false" HeaderStyle-Wrap="false">
							<ItemTemplate>
								<asp:Label ID="STATUS" runat="server"></asp:Label>
								<div id="DivNOTE" runat="server" style="color: #cb1a1a;">
									<asp:Label ID="NOTE" runat="server"></asp:Label>
								</div>
							</ItemTemplate>
						</asp:TemplateField>
						<asp:BoundField DataField="STATUS" />
						<asp:BoundField DataField="NOTE" />
						<asp:BoundField DataField="INPUT_USER" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
</asp:Content>
