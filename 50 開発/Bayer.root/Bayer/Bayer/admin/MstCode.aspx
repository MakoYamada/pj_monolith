<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="MstCode.aspx.vb" Inherits="Bayer.MstCode" %>
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
							コード区分
							<asp:DropDownList ID="JokenCODE" runat="server" Width="250px">
								<asp:ListItem Value="0" Text="--- 選択してください ---"></asp:ListItem>
								<asp:ListItem Value="01" Text="性別"></asp:ListItem>
								<asp:ListItem Value="02" Text="レイアウト"></asp:ListItem>
								<asp:ListItem Value="03" Text="参加者役割"></asp:ListItem>
								<asp:ListItem Value="04" Text="依頼：ホテル喫煙"></asp:ListItem>
								<asp:ListItem Value="05" Text="回答：ホテル喫煙"></asp:ListItem>
								<asp:ListItem Value="06" Text="交通機関"></asp:ListItem>
								<asp:ListItem Value="07" Text="座席区分"></asp:ListItem>
								<asp:ListItem Value="08" Text="座席希望"></asp:ListItem>
								<asp:ListItem Value="09" Text="社員臨席希望"></asp:ListItem>
								<asp:ListItem Value="10" Text="社員ホテル禁煙"></asp:ListItem>
							</asp:DropDownList>
						</td>
						<td align="right">
							&nbsp;&nbsp;
							<asp:Button ID="BtnSearch" runat="server" Text="選択" Width="110px" CssClass="Button" />
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
				<table cellpadding="2" cellspacing="0" border="0" id="TblInsert" runat="server" style="border: 1px solid  #738891;">
					<tr style="background-color: #738891;">
						<td align="left" style="font-weight: bold; color: #ffffff;">
							新しいコードを追加
						</td>
					</tr>
					<tr>
						<td align="left">
							<table cellpadding="2" cellspacing="2" border="0">
								<tr>
									<td class="TdTitle" align="center">
										&nbsp;
										コード
										&nbsp;
									</td>
									<td align="center" class="TdTitle">
										&nbsp;
										名称
										&nbsp;
									</td>
									<td align="right" rowspan="2" style="width: 130px;" valign="top">
										<asp:Button ID="BtnInsert" runat="server" Text="登録" Width="100px" CssClass="Button" />
										&nbsp;
									</td>
								</tr>
								<tr>
									<td align="center" style="width: 60px;">
										<asp:TextBox ID="DISP_VALUE" runat="server" Width="50px" MaxLength="10"></asp:TextBox>
									</td>
									<td align="center" style="width: 280px;">
										<asp:TextBox ID="DISP_TEXT" runat="server" Width="270px" MaxLength="50"></asp:TextBox>
									</td>
								</tr>
							</table>
						</td>
					</tr>
				</table>
			</td>
		</tr>
		<tr>
			<td align="left">
				<table cellpadding="2" cellspacing="0" border="0" id="TblUpdate" runat="server" style="border: 1px solid  #738891;">
					<tr style="background-color: #738891;">
						<td align="left" style="font-weight: bold; color: #ffffff;" colspan="2">
							名称の変更
						</td>
					</tr>
					<tr>
						<td align="left">
							<table cellpadding="0" cellspacing="0" border="0">
								<tr>
									<td align="left">
										<asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" CellSpacing="2" GridLines="None"
										 AutoGenerateColumns="false" ShowHeader="true" ShowFooter="false" 
										 AllowPaging="false" PageSize="10"
										 DataKeyNames="CODE,DATA_ID" DataSourceID="SqlDataSource1">
											<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
											<AlternatingRowStyle Wrap="false" BackColor="#ffffff" />
											<RowStyle Wrap="false" BackColor="#ffffff" />
											<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
											<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
											<Columns>
												<asp:BoundField DataField="DISP_VALUE" HeaderText="コード" ItemStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="60px" />
												<asp:TemplateField HeaderText="名称" ItemStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="280px">
													<ItemTemplate>
														<asp:TextBox ID="DISP_TEXT" runat="server" Width="270px" MaxLength="50"></asp:TextBox>
													</ItemTemplate>
												</asp:TemplateField>
												<asp:BoundField DataField="DISP_TEXT" />
												<asp:BoundField DataField="CODE" />
												<asp:BoundField DataField="DATA_ID" />
											</Columns>
										</asp:GridView>
										<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
									</td>
								</tr>
							</table>
						</td>
						<td align="right" style="width: 132px;" valign="top">
							<div class="FontSize1" style="height: 2px;"></div>
							<asp:Button ID="BtnUpdate" runat="server" Text="変更" Width="100px" CssClass="Button" />
							&nbsp;
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<asp:HiddenField ID="CODE" runat="server" />
</asp:Content>
