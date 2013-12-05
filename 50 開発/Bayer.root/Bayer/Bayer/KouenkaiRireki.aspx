<%@ Page Title=""  Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KouenkaiRireki.aspx.vb" Inherits="Bayer.KouenkaiRireki" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
		<tr id="TrKOUENKAI_NAME" runat="server">
			<td align="left" style="font-weight: bold;">
				<asp:Label ID="KOUENKAI_NO" runat="server"></asp:Label>
				：
				<asp:Label ID="KOUENKAI_NAME" runat="server"></asp:Label>
			</td>
		</tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td style="width:50%">
                            <asp:Button ID="BtnPrint1" runat="server" Text="印刷" Width="130px" 
                                CssClass="Button" TabIndex="1" />
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnBack1" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="2" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
		<tr>
		    <td>
		        <asp:Label ID="LabelNoData" runat="server" CssClass="NoData">対象データが登録されていません。</asp:Label>
		    	<asp:GridView ID="GrvList" runat="server" TabIndex="-1" CellPadding="2" 
				 AutoGenerateColumns="False" 
				 AllowPaging="True" PageSize="13"
				 DataKeyNames="KOUENKAI_NO" DataSourceID="SqlDataSource1">
					<HeaderStyle Wrap="false" HorizontalAlign="Center" CssClass="TdTitle" />
					<AlternatingRowStyle Wrap="false" BackColor="#f2f2f2" />
					<RowStyle Wrap="false" BackColor="#ffffff" />
					<PagerSettings Mode="NumericFirstLast" Position="Top" PreviousPageText="&lt;" NextPageText="&gt;" FirstPageText="&lt;&lt;" LastPageText="&gt;&gt;" />
					<PagerStyle BackColor="#ffffff" Font-Bold="true" CssClass="pagerlink" />
					<Columns>
					    <asp:BoundField DataField="TIME_STAMP" HeaderText="Timestamp" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="140px"></ItemStyle>
                        </asp:BoundField>
					    <asp:BoundField DataField="UPDATE_DATE" HeaderText="更新日時" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="180px"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="BU" HeaderText="BYL企画担当BU" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="100px"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="BYL企画担当エリア" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="80px"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="BYL企画担当営業所" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="100px"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="FROM_DATE" HeaderText="実施日" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="USER_NAME" HeaderText="TOP担当者" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="100px"></ItemStyle>
                        </asp:BoundField>
						<asp:ButtonField ButtonType="Button" HeaderText="" Text="詳細" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" 
                            ItemStyle-HorizontalAlign="Center" CommandName="Detail" 
                            ControlStyle-CssClass="ButtonList" ControlStyle-Width="46px" 
                            ItemStyle-Width="68px" >
<ControlStyle CssClass="ButtonList" Width="46px"></ControlStyle>

<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle HorizontalAlign="Center" Wrap="False" Width="68px"></ItemStyle>
                        </asp:ButtonField>
						<asp:BoundField DataField="KOUENKAI_NO" />
						<asp:BoundField DataField="TO_DATE" />
					</Columns>
				</asp:GridView>
				<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
		    </td>
		</tr>
        <tr>
            <td>
                <table cellpadding="2" cellspacing="0" border="0" width="900px">
                    <tr>
                        <td style="width:50%">
                            <asp:Button ID="BtnPrint2" runat="server" Text="印刷" Width="130px" 
                                CssClass="Button" TabIndex="7" />
                        </td>
                        <td style="width:50%" align="right">
                            <asp:Button ID="BtnBack2" runat="server" Text="戻る" Width="130px" 
                                CssClass="Button" TabIndex="7" />
                        </td>
                    </tr>
                </table> 
            </td>
        </tr>
	</table>
</asp:Content>