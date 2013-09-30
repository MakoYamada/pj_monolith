<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="MstUser.aspx.vb" Inherits="Bayer.MstUser" %>
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
							<asp:TextBox ID="JokenLOGIN_ID" runat="server" Width="80px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							氏名
							<asp:TextBox ID="JokenUSER_NAME" runat="server" Width="160px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							権限
							<asp:RadioButton ID="JokenKENGEN_1" runat="server" Text="？？？？？" GroupName="KENGEN" />
							&nbsp;&nbsp;
							<asp:RadioButton ID="JokenKENGEN_2" runat="server" Text="？？？？？" GroupName="KENGEN" />
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
							<asp:Button ID="BtnRegist" runat="server" Text="新規ユーザ登録" Width="150px" CssClass="Button" />
						</td>
					</tr>
				</table>
			</td>
		</tr>
	</table>
	<hr style="width: 100%;" />
	<div ID="DivMessage" runat="server">
		<asp:Label ID="LabelMessage" runat="server" Font-Bold="true">
			ユーザ情報を登録しました。 <br /><br />
			ログインID＝1234567890<br />
			氏名＝斗津府 太郎
		</asp:Label>
	</div>
	<table cellspacing="0" cellpadding="2" border="0" id="TblRegist" runat="server" style="margin: 5px 5px 5px 2px; border: #999999 1px solid;">
		<tr>
			<td align="left" style="padding: 3px;">
				<table border="0" cellpadding="2" cellspacing="2">
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							ログインID
							&nbsp;
						</td>
						<td align="left" class="TdItem">
							<asp:TextBox ID="LOGIN_ID" runat="server" Width="100px" MaxLength="10"></asp:TextBox>
							<asp:Label ID="DispLOGIN_ID" runat="server"></asp:Label>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							パスワード
							&nbsp;
						</td>
						<td align="left" class="TdItem">
							<asp:TextBox ID="PASSWORD" runat="server" Width="200px" MaxLength="20"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							氏名
							&nbsp;
						</td>
						<td align="left" class="TdItem">
							<asp:TextBox ID="USER_NAME" runat="server" Width="300px" MaxLength="100"></asp:TextBox>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							権限
							&nbsp;
						</td>
						<td align="left" class="TdItem">
							<asp:RadioButton ID="KENGEN_1" runat="server" Text="権限その１" GroupName="KENGEN"></asp:RadioButton>
							&nbsp;&nbsp;
							<asp:RadioButton ID="KENGEN_2" runat="server" Text="権限その２" GroupName="KENGEN"></asp:RadioButton>
						</td>
					</tr>
					<tr>
						<td align="left" style="background-color: #e9f7e3; color: #555555; font-weight: bold;">
							&nbsp;
							利用停止
							&nbsp;
						</td>
						<td align="left" class="TdItem">
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
						<asp:ButtonField ButtonType="Button" Text="変更" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Regist" ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" ItemStyle-Width="68px" />
						<asp:BoundField DataField="LOGIN_ID" HeaderText="ログインID" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KENGEN" HeaderText="権限" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="USER_NAME" HeaderText="氏名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="STOP_FLG" HeaderText="使用停止" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="SYSTEM_ID" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
</asp:Content>
