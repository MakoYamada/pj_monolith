<%@ Page Title=""  Language="vb" AutoEventWireup="false" MasterPageFile="~/Base.Master" CodeBehind="KouenkaiRireki.aspx.vb" Inherits="Bayer.KouenkaiRireki" %>
<%@ MasterType virtualPath="~/Base.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<table cellspacing="0" cellpadding="2" border="0">
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
						<asp:BoundField DataField="BU" HeaderText="BU" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="100px"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="KIKAKU_TANTO_AREA" HeaderText="エリア" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="80px"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="KIKAKU_TANTO_EIGYOSHO" HeaderText="営業所" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="100px"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="FROM_DATE" HeaderText="実施日" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False"></ItemStyle>
                        </asp:BoundField>
						<asp:BoundField DataField="KIKAKU_TANTO_NAME" HeaderText="担当者" ItemStyle-Wrap="false" 
                            HeaderStyle-Wrap="false" >
<HeaderStyle Wrap="False"></HeaderStyle>

<ItemStyle Wrap="False" HorizontalAlign="Center" Width="100px"></ItemStyle>
                        </asp:BoundField>
						<asp:ButtonField ButtonType="Button" HeaderText="" Text="詳細" 
                            ItemStyle-Wrap="false" HeaderStyle-Wrap="false" 
                            ItemStyle-HorizontalAlign="Center" CommandName="Kaijo" 
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
	</table>
    <table cellspacing="0" cellpadding="2" border="0">
        <tr align="center">
            <td>
                <asp:Button ID="BtnBack" runat="server" Text="戻る" Width="130px" CssClass="Button" />
            </td>
        </tr>
    </table>
</asp:Content>