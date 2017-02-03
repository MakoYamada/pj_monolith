<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="TaxiMeisaiCsv.aspx.vb" Inherits="Bayer_Past.TaxiMeisaiCsv" %>
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
							BYL企画担当者
							<asp:TextBox ID="JokenKIKAKU_TANTO_ROMA" runat="server" Width="170px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							BYL手配担当者
							<asp:TextBox ID="JokenTEHAI_TANTO_ROMA" runat="server" Width="170px"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							製品名
							<asp:DropDownList ID="JokenSEIHIN" runat="server" Width="240px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
						</td>
					</tr>
					<tr>
						<td align="left" colspan="2">
							会合番号
							<asp:TextBox ID="JokenKOUENKAI_NO" runat="server" Width="140px" MaxLength="14"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
							会合名
							<asp:TextBox ID="JokenKOUENKAI_NAME" runat="server" Width="350px" MaxLength="200"></asp:TextBox>
							&nbsp;&nbsp;&nbsp;
						</td>
					</tr>
					<tr>
						<td align="left" colspan="2">
							開催日
							<asp:TextBox ID="JokenFROM_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="JokenFROM_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="JokenFROM_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							～
							<asp:TextBox ID="JokenTO_DATE_YYYY" runat="server" Width="50px" MaxLength="4"></asp:TextBox>年
							<asp:TextBox ID="JokenTO_DATE_MM" runat="server" Width="30px" MaxLength="2"></asp:TextBox>月
							<asp:TextBox ID="JokenTO_DATE_DD" runat="server" Width="30px" MaxLength="2"></asp:TextBox>日
							&nbsp;&nbsp;&nbsp;
						</td>
					</tr>
					<tr>
						<td align="left" colspan="2">
							BYL企画担当者名BU
							<asp:DropDownList ID="JoKenBU" runat="server" Width="120px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							BYL企画担当者名エリア
							<asp:DropDownList ID="JoKenKIKAKU_TANTO_AREA" runat="server" Width="200px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;
							TOP担当者
							<asp:DropDownList ID="JoKenTTANTO_ID" runat="server" Width="200px"></asp:DropDownList>
							&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
						</td>
					</tr>
					<tr>
						<td align="left">
							抽出条件
							<asp:RadioButton ID="JokenTKT_ENTA_ALL" runat="server" GroupName="TKT_ENTA" Text="全て" />
							&nbsp;
							<asp:RadioButton ID="JokenTKT_ENTA_N_Igai" runat="server" GroupName="TKT_ENTA" Text="請求不可をのぞく" />
							&nbsp;
							<asp:RadioButton ID="JokenTKT_ENTA_N_Only" runat="server" GroupName="TKT_ENTA" Text="請求不可のみ" />
						</td>
						<td align="right" style="padding-top: 15px;">
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
						<asp:BoundField DataField="FROM_DATE" HeaderText="開催日" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="KOUENKAI_NAME" HeaderText="会合名" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:BoundField DataField="TIME_STAMP" HeaderText="Timestamp" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" />
						<asp:BoundField DataField="UPDATE_DATE" HeaderText="更新日時" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" />
						<asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" />
						<asp:ButtonField ButtonType="Button" Text="CSV出力" ItemStyle-Wrap="false" HeaderStyle-Wrap="false" ItemStyle-HorizontalAlign="Center" CommandName="Csv" ControlStyle-CssClass="ButtonList" ControlStyle-Width="70px" ItemStyle-Width="82px" ItemStyle-BackColor="#e4e9d1" />
						<asp:BoundField DataField="KOUENKAI_NO" />
						<asp:BoundField DataField="TO_DATE" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
			</td>
		</tr>
	</table>
</asp:Content>
